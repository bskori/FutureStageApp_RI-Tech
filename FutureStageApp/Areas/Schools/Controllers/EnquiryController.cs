using FutureStageApp.CustFilter;
using FutureStageApp.Models;
using FutureStageApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.Schools.Controllers
{
    [Area("Schools")]
    [SchoolAuth]
    public class EnquiryController : Controller
    {
        FutureStageAppContext cntx;
        public EnquiryController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult NewEnquiry()
        {
            ViewBag.Remark = this.cntx.AddmissionConfirmations.Select(p => p.Remark).ToList();
            return View(this.cntx.AddmissionEnquiries.ToList());
        }

        [HttpGet]
        public IActionResult ConfirmEnquiry(Int64 id)
        {
            var erec = this.cntx.AddmissionEnquiries.Find(id);
            
            var epec = this.cntx.Parents.SingleOrDefault(p => p.ParentID == erec.ParentID);
            ViewBag.ParentID = erec.ParentID;
            ViewBag.ParentName = erec.Parent.Name;
            ViewBag.SchoolID = erec.SchoolID;
            ViewBag.SchoolName = erec.School.Name;
            ViewBag.EnquiryDescription = erec.EnquiryDescription;
            ViewBag.AdmissionEnquiryID = erec.AddmissionEnquiryID;
            
             return View();
        }

        [HttpPost]
        public IActionResult ConfirmEnquiry(AddmissionConfirmation rec)
        {
            
            if (ModelState.IsValid)
            {
                this.cntx.AddmissionConfirmations.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("NewEnquiry");
            }
            return View(rec);
        }

        public IActionResult ConfirmedEnquiry()
        {

            return View(this.cntx.AddmissionEnquiries.ToList());
        }

        public IActionResult ConfirmedEnquiryDetails(Int64 id)
        {
            var rec = this.cntx.AddmissionConfirmations.FirstOrDefault(p => p.AddmissionEnquiryID == id);
            return View(rec);
        }
    }
}
