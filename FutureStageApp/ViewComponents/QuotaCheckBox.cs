using FutureStageApp.Models;
using FutureStageApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewComponents
{
    public class QuotaCheckBox:ViewComponent
    {
        FutureStageAppContext cntx;
        public QuotaCheckBox(FutureStageAppContext ctemp)
        {
            this.cntx = ctemp;
        }

        public IViewComponentResult Invoke()
        {
            var v = from t in this.cntx.StandardSeatQuotas join t2 in this.cntx.Quotas on t.StandardSeatQuotaID equals t2.QuotaID into g 
                    from t3 in g.DefaultIfEmpty()
                    select new QuotaCheckBoxVM
                    {
                        Selected = false,
                        Value = t3.QuotaID,
                        Text = t3.QuotaTitle,
                        NoSeats = t.NoOfSeats
                    };
            return View(v.ToList());
        }
    }
}
