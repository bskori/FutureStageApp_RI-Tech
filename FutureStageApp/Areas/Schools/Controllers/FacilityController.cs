using FutureStageApp.CustFilter;
using FutureStageApp.Models;
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
    public class FacilityController : Controller
    {
        FutureStageAppContext cntx;
        public FacilityController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.SchoolFacilities.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Facility = new SelectList(this.cntx.Facilities.ToList(), "FacilityID", "FaclilityTitle");
            ViewBag.School = new SelectList(this.cntx.Schools.ToList(), "SchoolID", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(SchoolFacility rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.SchoolFacilities.Add(rec);
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
