using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("SchoolAchivementTbl")]
    public class SchoolAchivement
    {
        [Key]
        public Int64 SchoolAchivementID { get; set; }
        public DateTime SchoolAchivementDate { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        [ForeignKey("School")]
        public Int64 SchoolID { get; set; }
        public virtual School School { get; set; }
    }
}
