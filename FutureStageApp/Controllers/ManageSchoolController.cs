using FutureStageApp.Models;
using FutureStageApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Controllers
{
    public class ManageSchoolController : Controller
    {
        FutureStageAppContext cntx;
        public ManageSchoolController(FutureStageAppContext tempcntx)
        {
            this.cntx = tempcntx;
        }
        public IActionResult Index()
        {
            return View(this.cntx.Schools.ToList());
        }

        [HttpGet]
        public IActionResult doLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult doLogin(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                School srec = this.cntx.Schools.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
                if(srec != null)
                {
                    HttpContext.Session.SetString("SchoolID", srec.SchoolID.ToString());
                    HttpContext.Session.SetString("Name", srec.Name.ToString());
                    return RedirectToAction("Index", "Home", new { area = "Schools" });
                }
                ModelState.AddModelError("", "Invalid Email Address or Password");
                return View(rec);
            }
            return View(rec);
        }

        
       
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 logSclId = Convert.ToInt64(HttpContext.Session.GetString("SchoolID"));
                var srec = this.cntx.Schools.SingleOrDefault(p => p.SchoolID == logSclId);
                if (srec.Password == rec.OldPassword)
                {
                    srec.Password = rec.NewPassword;
                    this.cntx.SaveChanges();
                    ViewBag.Message = "Password Changed Succesfully!";
                    return View();
                }
                else
                {
                    ModelState.AddModelError("","Invalid Old Password!");
                     return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("doLogin");
        }
    }
}
