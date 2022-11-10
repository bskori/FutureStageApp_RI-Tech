using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("AddmissionEnquiryTbl")]
    public class AddmissionEnquiry
    {
        [Key]
        public Int64 AddmissionEnquiryID { get; set; }
        [ForeignKey("Parent")]
        public Int64 ParentID { get; set; }
        public virtual Parent Parent { get; set; }
        [ForeignKey("School")]
        public Int64 SchoolID { get; set; }
        public virtual School School { get; set; }
        public DateTime EnquiryDate { get; set; }
        [ForeignKey("SchoolStandard")]
        public Int64 SchoolStandardID { get; set; }
        public virtual SchoolStandard SchoolStandard { get; set; }
        public string EnquiryDescription { get; set; }
    }
}
