using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("AddmissionProcessTbl")]
    public class AddmissionProcess
    {
        [Key]
        public Int64 AddmissionProcessID { get; set; }
        [ForeignKey("SchoolStandard")]
        public Int64 SchoolStandardID { get; set; }
        public virtual SchoolStandard SchoolStandard { get; set; }
        public string ProcessTitle { get; set; }
        public string ProcessDesc { get; set; }
    }
}
