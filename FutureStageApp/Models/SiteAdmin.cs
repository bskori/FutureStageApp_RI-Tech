using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("SiteAdminTbl")]
    public class SiteAdmin
    {
        [Key]
        public Int64 SiteAdminID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }

    }
}
