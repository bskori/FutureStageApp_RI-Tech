using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("EducationBoardTbl")]
    public class EducationBoard
    {
        [Key]
        public Int64 EducationBoardID { get; set; }
        public string EducationBoardTitle { get; set; }
        public string EducationBoardDesc { get; set; }
    }
}
