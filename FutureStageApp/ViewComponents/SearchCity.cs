using FutureStageApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewComponents
{
    public class SearchCity:ViewComponent
    {
        FutureStageAppContext cntx;
        public SearchCity(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.City = this.cntx.Cities.ToList();
            ViewBag.Area = this.cntx.Areas.ToList();
            return View();
        }

        public JsonResult FindArea(int id)
        {
            var rec = this.cntx.Areas.Where(p => p.CityID == id).Select(Area => new
            {
                areaID = Area.AreaID,
                areaName = Area.AreaName
            }).ToList();

            return new JsonResult(rec);
        }
    }
}
