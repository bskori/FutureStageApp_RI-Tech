using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("SchoolTbl")]
    public class School
    {
        [Key]
        public Int64 SchoolID { get; set; }
        [Required(ErrorMessage ="Name Required!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Address Required!")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Email Address Required")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Contact No. Required!")]
        public string ContactNo { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password Required!")] 
        public string Password { get; set; }
        public DateTime  EstablishmentDate { get; set; }
        
        [ForeignKey("Area")]
        public Int64 AreaID { get; set; }
        public virtual Area Area { get; set; }
        public virtual List<SchoolStandard> SchoolStandards { get; set; }
        public virtual List<SchoolFacility> SchoolFacilities { get; set; }
        public virtual List<SchoolAchivement> SchoolAchivements { get; set; }
        public virtual List<Enquiry> Enquiries { get; set; }
        public virtual List<AddmissionEnquiry> AddmissionEnquiries { get; set; }
    }
}
