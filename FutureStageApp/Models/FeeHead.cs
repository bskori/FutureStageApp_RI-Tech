using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("FeeHeadTbl")]
    public class FeeHead
    {
        [Key]
        public Int64 FeeHeadID { get; set; }
        public string FeeHeadTitle { get; set; }
        public string FeeHeadDesc { get; set; }
        public virtual List<StandardFees> StandardFees { get; set; }
    }
}
