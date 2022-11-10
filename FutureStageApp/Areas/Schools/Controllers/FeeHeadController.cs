using FutureStageApp.CustFilter;
using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.Schools.Controllers
{
    [Area("Schools")]
    [SchoolAuth]
    public class FeeHeadController : Controller
    {
        FutureStageAppContext cntx;
        public FeeHeadController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.FeeHeads.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(FeeHead rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.FeeHeads.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.FeeHeads.Find(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(FeeHead rec)
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
            var rec = this.cntx.FeeHeads.Find(id);
            this.cntx.FeeHeads.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
