using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("AddmissionPrerequisiteTbl")]
    public class AddmissionPrerequisite
    {
        [Key]
        public Int64 AddmissionPrerequisiteID { get; set; }
        public string PrerequisiteTitle { get; set; }
        [ForeignKey("SchoolStandard")]
        public Int64 SchoolStandardID { get; set; }
        public virtual SchoolStandard SchoolStandard { get; set; }
        public string PrerequisiteDesc { get; set; }
    }
}
