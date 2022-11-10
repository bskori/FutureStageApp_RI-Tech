using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewModels
{
    public class QuotaCheckBoxVM
    {
        public bool Selected { get; set; }
        public String Text { get; set; }
        public Int64 Value { get; set; }
        public int NoSeats { get; set; }
    }
}
