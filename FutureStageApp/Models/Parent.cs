using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("ParentTbl")]
    public class Parent
    {
        [Key]
        
        public Int64 ParentID { get; set; }
        
        public string Name { get; set; }
      
        public string Address { get; set; }
      
        public string EnailID { get; set; }
       
        public string MobileNo { get; set; }
        
        public string Password { get; set; }
        public virtual List<Enquiry> Enquiries { get; set; }
        public virtual List<AddmissionEnquiry> AddmissionEnquiries { get; set; }
    }
}
