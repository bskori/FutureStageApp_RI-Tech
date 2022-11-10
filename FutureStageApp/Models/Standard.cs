using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("SatndardTbl")]
    public class Standard
    {
        [Key]
        public Int64 StandardID { get; set; }
        public string StandardTitle { get; set; }
        public string StandardDesc { get; set; }
        public virtual List<SchoolStandard> SchoolStandards { get; set; }
    }
}
