using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("SchoolStadardTbl")]
    public class SchoolStandard
    {
        [Key]
        public Int64 SchoolStandardID { get; set; }
        

        [ForeignKey("Standard")]
        public Int64 StandardID { get; set; }
        public virtual Standard Standard { get; set; }
        [ForeignKey("School")]
        public Int64 SchoolID { get; set; }
        public virtual School School { get; set; }
        public int IntakeCapacity { get; set; }
        public virtual List<StandardSeatQuota> StandardSeatQuotas { get; set; }
        public virtual List<StandardFees> StandardFees { get; set; }
        public virtual List<AddmissionPrerequisite> AddmissionPrerequisites { get; set; }
        public virtual List<AddmissionProcess> AddmissionProcesses { get; set; }
        public virtual List<AddmissionEnquiry> AddmissionEnquiries { get; set; }
        public SchoolStandard()
        {
            StandardSeatQuotas = new List<StandardSeatQuota>();
        }
    }
}
