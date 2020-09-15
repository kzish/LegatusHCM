using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegatusAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LegatusAdmin.Controllers
{
    [Route("Company")]
    [Authorize(Roles = "admin")]
    public class CompanyController : Controller
    {

        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CompanyController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        dbContext db = new dbContext();
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }
        [HttpGet("")]
        [HttpGet("AllCompanies")]
        public IActionResult AllCompanies()
        {
            ViewBag.title = "All companies";
            return View();
        }

        [HttpGet("ajaxAllCompanies")]
        public IActionResult ajaxAllCompanies()
        {
            var companies = db.MCompany.ToList();
            ViewBag.companies = companies;
            return View();
        }

        [HttpGet("CreateCompany")]
        public IActionResult CreateCompany()
        {
            ViewBag.title = "Create Company";
            return View();
        }

        [HttpPost("CreateCompany")]
        public async Task<IActionResult> CreateCompany(string CompanyName, string Email,string Password)
        {
            try
            {
                var exists = db.MCompany.Where(i => i.CompanyName == CompanyName).Any();
                if (exists)
                {
                    TempData["type"] = "error";
                    TempData["msg"] = $"{CompanyName} Already exists";
                    return RedirectToAction("CreateCompany");
                }
                var new_company = new MCompany()
                {
                    CompanyName = CompanyName,
                };
                db.MCompany.Add(new_company);
                db.SaveChanges();

                //create super user for this company
                var new_super_user = new IdentityUser();
                new_super_user.Email = Email;
                new_super_user.UserName = new_super_user.Email;
                await userManager.CreateAsync(new_super_user, Password);//create super user

                bool x = await roleManager.RoleExistsAsync("super_user");
                if (!x)
                {
                    var role = new IdentityRole("super_user");
                    await roleManager.CreateAsync(role);
                }
                await userManager.AddToRoleAsync(new_super_user, "super_user");//add user to super user role

                //link user to company
                var super_user = db.AspNetUsers.Where(i => i.Email == new_super_user.Email).FirstOrDefault();
                super_user.CompanyId = new_company.Id;
                db.SaveChanges();

                TempData["type"] = "success";
                TempData["msg"] = "Created";
                return RedirectToAction("AllCompanies");
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
                return RedirectToAction("CreateCompany");
            }
        }

        [HttpPost("DeleteCompany")]
        public IActionResult DeleteCompany(string company_id)
        {
            try
            {
                var company = db.MCompany.Find(company_id);
                db.Remove(company);
                db.SaveChanges();
                TempData["type"] = "success";
                TempData["msg"] = "Deleted";
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
            }
            return RedirectToAction("AllCompanies");
        }



    }
}
