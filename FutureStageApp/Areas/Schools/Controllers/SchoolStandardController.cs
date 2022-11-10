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
    public class SchoolStandardController : Controller
    {
        FutureStageAppContext cntx;
        public SchoolStandardController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.SchoolStandards.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Standard = new SelectList(this.cntx.Standards.ToList(), "StandardID", "StandardTitle");
            ViewBag.School = new SelectList(this.cntx.Schools.ToList(), "SchoolID", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(SchoolStandard rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.SchoolStandards.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {

            var rec = this.cntx.SchoolStandards.Find(id);
            
            ViewBag.Standard = new SelectList(this.cntx.Standards.ToList(), "StandardID", "StandardTitle",rec.StandardID);
            ViewBag.School = new SelectList(this.cntx.Schools.ToList(), "SchoolID", "Name", rec.SchoolID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(SchoolStandard rec)
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
            var rec = this.cntx.SchoolStandards.Find(id);
            this.cntx.SchoolStandards.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
