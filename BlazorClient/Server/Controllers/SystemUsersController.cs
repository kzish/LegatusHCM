using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper.Mappers;
using BlazorClient.Server.Models;
using BlazorClient.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualBasic;

namespace BlazorClient.Server.Controllers
{
    [Route("SystemUsers")]
    [Authorize(Roles ="super_user,users")]
    public class SystemUsersController : Controller
    {

        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private IHttpContextAccessor httpContextAccessor;

        dbContext db = new dbContext();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        public SystemUsersController(IHttpContextAccessor httpContextAccessor,SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.httpContextAccessor = httpContextAccessor;
        }

    
        public string GetClaim(string claim)
        {
           return User.Claims.Where(i => i.Type == claim).Select(i => i.Value).FirstOrDefault();
        }

        /// <summary>
        /// fetch all the users in this company
        /// </summary>
        /// <returns></returns>
        [HttpGet("Users")]
        public async Task<JsonResult> Users()
        {
            try
            {
                var company_id = GetClaim("company_id");
                var users = db.AspNetUsers.Where(i => i.CompanyId == company_id).ToList();
                var system_users = new List<SystemUsers>();
                foreach(var user in users)
                {
                    var nu = new SystemUsers();
                    nu.id = user.Id;
                    nu.email = user.Email;
                    nu.roles = (List<string>)await userManager.GetRolesAsync(await userManager.FindByNameAsync(user.Email));
                    system_users.Add(nu);
                }
                return Json(new
                {
                    res = "ok",
                    data = system_users
                });
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }

        [HttpPost("Users")]
        public async Task<JsonResult> Users([FromBody]SystemUsers user)
        {
            try
            {
                var company_id = GetClaim("company_id");
                var email_is_taken = db.AspNetUsers.Where(i => i.Email == user.email).Any();
                if(email_is_taken)
                {
                    return Json(new
                    {
                        res="err",
                        data="This email is already taken"
                    });
                }
                var new_user = new IdentityUser()
                {
                    Email=user.email,
                    UserName=user.email
                };
                //create user
                await userManager.CreateAsync(new_user, user.password);
                //link user to company
                var created_user = db.AspNetUsers.Where(i => i.Email == user.email).FirstOrDefault();
                created_user.CompanyId = company_id;
                await db.SaveChangesAsync();
                //add to roles
                foreach(var role in user.roles)
                {
                    //create role if not exist
                    if(!await roleManager.RoleExistsAsync(role))await roleManager.CreateAsync(new IdentityRole(role));
                    //get idettity user
                    var id_user = await userManager.FindByEmailAsync(user.email);
                    //add user to role
                    if (!await userManager.IsInRoleAsync(id_user, role)) await userManager.AddToRoleAsync(id_user, role);
                }
                return Json(new
                {
                    res="ok",
                    data="User created"
                });

            }catch(Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                }); 
            }


        }

        [HttpDelete("Users/{user_id}")]
        public JsonResult Users(string user_id)
        {
            try
            {
                //must be from the same company
                var company_id = GetClaim("company_id");
                var user_to_delete = db.AspNetUsers.Find(user_id);
                if (user_to_delete.CompanyId == company_id)
                {
                    db.AspNetUsers.Remove(user_to_delete);
                    db.SaveChanges();
                    return Json(new
                    {
                        res = "ok",
                        data = "User Deleted"
                    });
                }
                else
                {
                    return Json(new
                    {
                        res = "err",
                        data = "You cannot delete this user"
                    });
                }
            }catch(Exception    ex)
            {
                return Json(new
                {
                    re = "err",
                    data = ex.Message
                });
            }
        }


        [HttpPatch("PasswordReset")]
        public async Task<JsonResult> PasswordReset(string user_id,string new_password)
        {
            try
            {
                var company_id = GetClaim("company_id");
                var user_to_reset_password = db.AspNetUsers.Find(user_id);
                if (company_id != user_to_reset_password.CompanyId)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "You must be from the same company to reset password"
                    });
                }

                var id_user = new IdentityUser()
                {
                    Email = user_to_reset_password.Email,
                    UserName = user_to_reset_password.Email
                };

                var token = await userManager.GeneratePasswordResetTokenAsync(id_user);
                await userManager.ResetPasswordAsync(id_user, token, new_password);
                return Json(new
                {
                    res = "ok",
                    data = "Password is reset"
                });
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    res="err",
                    data=ex.Message
                });
            }
        }


    }
}
