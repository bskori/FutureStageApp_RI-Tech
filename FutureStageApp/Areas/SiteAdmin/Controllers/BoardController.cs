using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.SiteAdmin.Controllers
{
    [Area("SiteAdmin")]
    public class BoardController : Controller
    {
        FutureStageAppContext cntx;
        public BoardController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IActionResult Index()
        {
            return View(this.cntx.EducationBoards.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(EducationBoard rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.EducationBoards.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.EducationBoards.Find(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(EducationBoard rec)
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
            var rec = this.cntx.EducationBoards.Find(id);
            this.cntx.EducationBoards.Remove(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
