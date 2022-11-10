using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("GeneralEnquiryReplyTbl")]
    public class GeneralEnquiryReply
    {
        [Key]
        public Int64 GeneralEnquiryReplyID { get; set; }
        [ForeignKey("Enquiry")]
        public Int64 EnquiryID { get; set; }
        public virtual Enquiry Enquiry { get; set; }
        public DateTime ReplyDate { get; set; }
        public string ReplyDesc { get; set; }
    }
}
