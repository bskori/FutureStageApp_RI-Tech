using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("AddmissionConfirmationTbl")]
    public class AddmissionConfirmation
    {
        [Key]
        public Int64 AddmissionConfirmationID { get; set; } 
        [ForeignKey("AddmissionEnquiry")]
        public Int64 AddmissionEnquiryID { get; set; }
        public virtual AddmissionEnquiry AddmissionEnquiry { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public bool Remark { get; set; }
    }
}
 