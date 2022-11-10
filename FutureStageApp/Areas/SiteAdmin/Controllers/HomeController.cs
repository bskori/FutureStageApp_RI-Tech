using FutureStageApp.CustFilter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Areas.SiteAdmin.Controllers
{
    [Area("SiteAdmin")]
    [Route("admin")]
    [SiteAdminAuth]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
