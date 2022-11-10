using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("FacilityTbl")]
    public class Facility
    {
        [Key]
        public Int64 FacilityID { get; set; }
        public string FaclilityTitle { get; set; }
        public string FaclilityDesc { get; set; }
        public virtual List<SchoolFacility> SchoolFacilities { get; set; }
    }
}
