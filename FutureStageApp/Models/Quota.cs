using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("QuotaTbl")]
    public class Quota
    {
        [Key]
        public Int64 QuotaID { get; set; }
        public string QuotaTitle { get; set; }
        public string QuotaDesc { get; set; }
        public virtual List<StandardSeatQuota> StandardSeatQuotas { get; set; }
    }
}
