using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("SchoolFacilityTbl")]
    public class SchoolFacility
    {
        [Key]
        public Int64 SchoolFacilityID { get; set; }
        [ForeignKey("School")]
        public Int64 SchoolID { get; set; }
        public virtual School School { get; set; }
        [ForeignKey("Facility")]
        public Int64 FacilityID { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
