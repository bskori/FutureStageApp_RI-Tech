using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("MediumTbl")]
    public class Medium
    {
        [Key]
        public Int64 MediumID { get; set; }
        public string MediumTitle { get; set; }
    }
}
