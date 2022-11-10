using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email Address Required!")]
        [EmailAddress(ErrorMessage ="Invalid Email Address!")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Password Required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
