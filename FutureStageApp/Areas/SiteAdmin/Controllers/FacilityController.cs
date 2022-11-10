using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.SiteAdmin.Controllers
{
    [Area("SiteAdmin")]
    public class FacilityController : Controller
    {
        FutureStageAppContext cntx;
        public FacilityController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.Facilities.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Facility rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Facilities.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.Facilities.Find(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Facility rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.cntx.Facilities.Find(id);
            this.cntx.Facilities.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
