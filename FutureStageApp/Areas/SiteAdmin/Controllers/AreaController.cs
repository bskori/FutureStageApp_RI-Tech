using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.SiteAdmin.Controllers
{
    [Area("SiteAdmin")]
    public class AreaController : Controller
    {
        FutureStageAppContext cntx;
        public AreaController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.Areas.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.City = new SelectList(this.cntx.Cities.ToList(), "CityID", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Area rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Areas.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.Areas.Find(id);
            ViewBag.City = new SelectList(this.cntx.Cities.ToList(), "CityID", "CityName", rec.CityID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Area rec)
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
            var rec = this.cntx.Areas.Find(id);
            this.cntx.Areas.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

