using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewModels
{
    public class SchoolRegisterVM
    {
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime EstablishmentDate { get; set; }
        
    }
}
