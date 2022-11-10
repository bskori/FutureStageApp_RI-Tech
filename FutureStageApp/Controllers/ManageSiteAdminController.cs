using FutureStageApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Controllers
{
    public class ManageSiteAdminController : Controller
    {
        FutureStageAppContext cntx;
        public ManageSiteAdminController(FutureStageAppContext temp)
        {
            this.cntx = temp;
        }

        [HttpGet]
        public IActionResult doLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult doLogin(SiteAdmin rec)
        {
            SiteAdmin sarec = this.cntx.SiteAdmins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            if(sarec != null)
            {
                HttpContext.Session.SetString("SiteAdminID", sarec.SiteAdminID.ToString());
                return RedirectToAction("Index", "Home", new { area = "SiteAdmin" });
            }
            ModelState.AddModelError("", "Invalid Email Address or Password!");
            return View(rec);
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("doLogin", "ManageSiteAdmin");
        }
        
    }
}
