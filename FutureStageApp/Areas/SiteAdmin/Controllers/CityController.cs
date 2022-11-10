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
    public class CityController : Controller
    {
        FutureStageAppContext cntx;
        public CityController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.Cities.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.State = new SelectList(this.cntx.States.ToList(), "StateID", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(City rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Cities.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.Cities.Find(id);
            ViewBag.State = new SelectList(this.cntx.States.ToList(), "StateID", "StateName", rec.StateID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
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
            var rec = this.cntx.Cities.Find(id);
            this.cntx.Cities.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
