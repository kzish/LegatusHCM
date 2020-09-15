using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorClient.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Controllers
{
    [Route("SystemUsers")]
    //[Authorize(AuthenticationSchemes = IdentityServerJwtConstants.IdentityServerJwtBearerScheme)]
    //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    [Authorize]
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

    
        public AspNetUsers GetCurrentUser()
        {
            //identify the user
            var asp_net_user = db.AspNetUsers
                .Where(i => i.Email == User.Identity.Name)
                .FirstOrDefault();
            return asp_net_user;
        }

        [HttpGet("Users")]
        public JsonResult Users()
        {
            try
            {
                //identify the user
                //var asp_net_user = GetCurrentUser();

                //users for this users company
                //var users = db.AspNetUsers
                //    .Where(i => i.CompanyId == asp_net_user.CompanyId)
                //    .ToList();

                //var shared_users = new List<BlazorClient.Shared.SystemUsers>();
                //foreach(var user in users)
                //{
                //    var su = new BlazorClient.Shared.SystemUsers()
                //    {
                //        email = user.Email
                //    };
                //    shared_users.Add(su);
                //}
                var userId = User.Identity.Name;
                //Response.Cookies.Append("special cookine", "niggerson");
                return Json(new
                {
                    res = "ok",
                    data = userId
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
        public async Task<JsonResult> Users(string email,string password)
        {
            try
            {
                //identify the user
                var asp_net_user = GetCurrentUser();

                var email_is_taken = db.AspNetUsers.Where(i => i.Email == email).Any();
                if(email_is_taken)
                {
                    return Json(new
                    {
                        res="err",
                        data="This email is taken"
                    });
                }
                var new_user = new IdentityUser()
                {
                    Email=email,
                    UserName=email
                };
                //create user
                await userManager.CreateAsync(new_user, password);
                //link user to company
                var created_user = db.AspNetUsers.Where(i => i.Email == email).FirstOrDefault();
                created_user.CompanyId = asp_net_user.CompanyId;
                await db.SaveChangesAsync();

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
                var asp_net_user = GetCurrentUser();
                var user_to_delete = db.AspNetUsers.Find(user_id);
                db.AspNetUsers.Remove(user_to_delete);
                db.SaveChanges();

                return Json(new
                {
                    res="ok",
                    data="User Deleted"
                });
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
                var asp_net_user = GetCurrentUser();
                var user_to_reset_password = db.AspNetUsers.Find(user_id);
                if (asp_net_user.CompanyId != user_to_reset_password.CompanyId)
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
