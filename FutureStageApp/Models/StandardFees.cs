using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("StandardFeesTbl")]
    public class StandardFees
    {
        [Key]
        public Int64 StandardFeesID { get; set; }

        [ForeignKey("SchoolStandard")]
        public Int64 SchoolStandardID { get; set; }
        public virtual SchoolStandard SchoolStandard { get; set; }

        [ForeignKey("FeeHead")]
        public Int64 FeeHeadID { get; set; }
        public virtual FeeHead FeeHead { get; set; }
        public decimal? Amount { get; set; }
    }
}
