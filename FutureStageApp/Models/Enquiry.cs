using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("EnquiryTbl")]
    public class Enquiry
    {
        [Key]
        public Int64 EnquiryID { get; set; }
       
        public string EnquiryDesc { get; set; }
        public DateTime EnquiryDate { get; set; }
        [ForeignKey("Parent")]
        public Int64 ParentID { get; set; }
        public virtual Parent Parent { get; set; }
       
        [ForeignKey("School")]
        public Int64 SchoolID { get; set; }
        public virtual School School { get; set; }
        public virtual List<GeneralEnquiryReply> GeneralEnquiryReplies { get; set; }
        public virtual List<AddmissionConfirmation> AddmissionConfirmations { get; set; }
    }
}
