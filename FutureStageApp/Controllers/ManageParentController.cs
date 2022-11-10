using FutureStageApp.Models;
using FutureStageApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Controllers
{
    public class ManageParentController : Controller
    {

        FutureStageAppContext cntx;
        public ManageParentController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
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
                Parent prec = this.cntx.Parents.SingleOrDefault(p => p.EnailID == rec.EmailID && p.Password == rec.Password);
                if (prec != null)
                {
                    HttpContext.Session.SetString("ParentID", prec.ParentID.ToString());
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                ModelState.AddModelError("", "Invalid Email Address or Password");
                return View(rec);
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Register()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Register(Parent rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Parents.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("doLogin");
            }
            return View(rec);
        }
    }
}
