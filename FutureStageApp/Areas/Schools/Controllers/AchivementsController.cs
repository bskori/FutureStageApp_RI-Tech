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
    public class AchivementsController : Controller
    {
        FutureStageAppContext cntx;
        public AchivementsController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.SchoolAchivements.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.School = new SelectList(this.cntx.Schools.ToList(), "SchoolID", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(SchoolAchivement rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.SchoolAchivements.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.SchoolAchivements.Find(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(SchoolAchivement rec)
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
            var rec = this.cntx.SchoolAchivements.Find(id);
            this.cntx.SchoolAchivements.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
