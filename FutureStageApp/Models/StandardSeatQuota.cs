using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("StandardSeatQuotaTbl")]
    public class StandardSeatQuota
    {
        public Int64 StandardSeatQuotaID { get; set; }
        [ForeignKey("SchoolStandard")]
      
        public Int64 SchoolStandardID { get; set; }
        public virtual SchoolStandard SchoolStandard { get; set; }
       [ForeignKey("Quota")]
        public Int64 QuotaID { get; set; }
        public virtual Quota Quota { get; set; }
        public int NoOfSeats { get; set; }
    }
}
