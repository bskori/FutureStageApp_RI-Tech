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
    public class StandardFeesController : Controller
    {
        FutureStageAppContext cntx;
        public StandardFeesController(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.cntx.StandardFees.ToList());
        }


        public IActionResult StandardCreateList()
        {
            return View(this.cntx.SchoolStandards.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return PartialView();
        }

       
    }
}
