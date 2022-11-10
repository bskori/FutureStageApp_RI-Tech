using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewComponents
{
    public class SearchArea:ViewComponent
    {
        FutureStageAppContext cntx;
        public SearchArea(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Area = new SelectList(this.cntx.Areas.ToList(), "AreaID", "AreaName");
            return View();
        }
    }
}
