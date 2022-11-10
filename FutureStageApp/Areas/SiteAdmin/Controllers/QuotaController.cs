using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.SiteAdmin.Controllers
{
    [Area("SiteAdmin")]
    public class QuotaController : Controller
    {
        FutureStageAppContext cntx;
        public QuotaController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.Quotas.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Quota rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Quotas.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.Quotas.Find(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Quota rec)
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
            var rec = this.cntx.Quotas.Find(id);
            this.cntx.Quotas.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
