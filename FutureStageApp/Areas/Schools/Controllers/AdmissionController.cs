using FutureStageApp.CustFilter;
using FutureStageApp.Models;
using FutureStageApp.ViewModels;
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
    public class AdmissionController : Controller
    {
        FutureStageAppContext cntx;
        public AdmissionController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.cntx.AddmissionPrerequisites.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.SchoolStandard = new SelectList(this.cntx.SchoolStandards.ToList(), "SchoolStandardID", "SchoolStandardTitle");
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddmissionVM rec)
        {
            AddmissionPrerequisite preq = new AddmissionPrerequisite();
            AddmissionProcess proc = new AddmissionProcess();
            if (ModelState.IsValid)
            {
                preq.SchoolStandardID = rec.SchoolStandardID;
                proc.SchoolStandardID = rec.SchoolStandardID;
                preq.PrerequisiteTitle = rec.AdmissionProcess;
                preq.PrerequisiteDesc = rec.PrerequisiteDesc;
                proc.ProcessTitle = rec.AdmissionProcess;
                proc.ProcessDesc = rec.ProcessDesc;
                this.cntx.AddmissionPrerequisites.Add(preq);
                this.cntx.AddmissionProcesses.Add(proc);               
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cntx.SchoolStandards.Find(id);
            var preq = this.cntx.AddmissionPrerequisites.SingleOrDefault(p => p.SchoolStandardID == rec.SchoolStandardID);
            var proc = this.cntx.AddmissionProcesses.SingleOrDefault(p => p.SchoolStandardID == rec.SchoolStandardID);
            ViewBag.SchoolStandard = new SelectList(this.cntx.SchoolStandards.ToList(), "SchoolStandardID", "SchoolStandardTitle",rec.SchoolStandardID);
            AddmissionVM admsn = new AddmissionVM()
            {
                AdmissionPrerequisite = preq.PrerequisiteTitle,
                PrerequisiteDesc = preq.PrerequisiteDesc,
                AdmissionProcess = proc.ProcessTitle,
                ProcessDesc = proc.ProcessDesc
            };
            return View(admsn);
        }

        [HttpPost]
        public IActionResult Edit(AddmissionVM rec)
        {
            AddmissionPrerequisite preq = new AddmissionPrerequisite();
            AddmissionProcess proc = new AddmissionProcess();
            
            if (ModelState.IsValid)
            {
                preq.AddmissionPrerequisiteID = rec.SchoolStandardID;
                preq.PrerequisiteTitle = rec.AdmissionPrerequisite;
                preq.PrerequisiteDesc = rec.ProcessDesc;
                proc.AddmissionProcessID = rec.SchoolStandardID;
                proc.ProcessTitle = rec.AdmissionProcess;
                proc.ProcessDesc = rec.ProcessDesc;
                this.cntx.Entry(preq).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cntx.SaveChanges();
                this.cntx.Entry(proc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        public IActionResult Delete(Int64 id)
        {
            var rec = this.cntx.SchoolStandards.Find(id);
            var preq = this.cntx.AddmissionPrerequisites.SingleOrDefault(p => p.SchoolStandardID == rec.SchoolStandardID);
            var proc = this.cntx.AddmissionProcesses.SingleOrDefault(p => p.SchoolStandardID == rec.SchoolStandardID);
            this.cntx.AddmissionPrerequisites.Remove(preq);
            this.cntx.AddmissionProcesses.Remove(proc);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
