using FutureStageApp.CustFilter;
using FutureStageApp.Models;
using FutureStageApp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.Schools.Controllers
{
    [Area("Schools")]
    [SchoolAuth]
    public class HomeController : Controller
    {
        IWebHostEnvironment iwebhost;
        FutureStageAppContext cntx;
        public HomeController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        
        
    [Route("School")]
    
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Area = new SelectList(this.cntx.Areas.ToList(), "AreaID", "AreaName");
            return View();
        }

        [HttpPost]
        public IActionResult Register(School rec)
        {
            if (ModelState.IsValid)
            {
                
                this.cntx.Schools.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("doLogin","ManageSchool",new {area ="" });
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult EditRegister(Int64 Id)
        {
            var rec = this.cntx.Schools.Find(Id);
            ViewBag.Area = new SelectList(this.cntx.Areas.ToList(), "AreaID", "AreaName",rec.AreaID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditRegister(School rec)
        { 
            if (ModelState.IsValid)
            {
                this.cntx.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cntx.SaveChanges();
                return RedirectToAction("Index","Home",new { id =1});
            }
            return View(rec);
        }

        public IActionResult SchoolProfile( Int64 id)
        {   
            var rec = this.cntx.Schools.Find(id);
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
                Int64 logSchlid = Convert.ToInt64(HttpContext.Session.GetString("SchoolID"));
                var srec = this.cntx.Schools.SingleOrDefault(p => p.SchoolID == logSchlid);
                if(srec.Password == rec.OldPassword)
                {
                    srec.Password = rec.NewPassword;
                    this.cntx.SaveChanges();
                    ViewBag.Message = "Password Changed Succesfully!";
                    return View();
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Old Password!");
                    return View(rec);
                }
            }
            return View(rec);
        }

        
       
    }
}
