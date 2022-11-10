using FutureStageApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Controllers
{
    public class SearchController : Controller
    {
        FutureStageAppContext cntx;
        public SearchController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult SearchSchool(City citymodel, Area areamodel)
        {
            Int64 areaid = areamodel.AreaID;
            Int64 ctyid = citymodel.CityID;
            
            if(areaid == 0 && ctyid == 0)
            {
                return View(this.cntx.Schools.ToList());
            }
            else
            {
                if (ctyid != 0 && areaid == 0)
                {
                    var cty = from t in cntx.Schools
                              join t2 in cntx.Areas
                              on t.AreaID equals t2.AreaID
                              where t2.AreaID == ctyid
                              select t;
                    return View(cty.ToList());
                    
                }
                else
                {
                    var area = this.cntx.Schools.Where(p => p.AreaID == areaid);
                    return View(area.ToList());
                }
            }
        }

        public IActionResult SchoolDetails(Int64 id)
        {
            var scllist = this.cntx.Schools.Find(id);
            return View(scllist);
        }

        [HttpGet]
        public IActionResult GetEnquiry(Int64 id)
        {
            Int64 parentid = Convert.ToInt64(HttpContext.Session.GetString("ParentID"));
            if(parentid != 0)
            {
                var schl = this.cntx.Schools.SingleOrDefault(p => p.SchoolID == id);
                var prnt = this.cntx.Parents.SingleOrDefault(p => p.ParentID == parentid);
                var schlstd = this.cntx.SchoolStandards.SingleOrDefault(p => p.SchoolID == id);
                ViewBag.SchoolName = schl.Name;
                ViewBag.SchoolID = schl.SchoolID;
                ViewBag.ParentName = prnt.Name;
                ViewBag.ParentID = prnt.ParentID;
                ViewBag.SchoolStandardID = schlstd.SchoolStandardID;
                ViewBag.IntakeCapacity = schlstd.IntakeCapacity;
                return View();
            }
            return RedirectToAction("doLogin", "ManageParent", new { area = "" });
        }

        [HttpPost]
        public IActionResult GetEnquiry(AddmissionEnquiry rec)
        {
            
            this.cntx.AddmissionEnquiries.Add(rec);
            this.cntx.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        
    }
}
