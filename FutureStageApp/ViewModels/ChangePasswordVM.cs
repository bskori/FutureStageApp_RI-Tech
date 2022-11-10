using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.ViewModels
{
    public class ChangePasswordVM
    {
        [Required(ErrorMessage ="Old Password Required!")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required(ErrorMessage ="New Pasword Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage ="Confirm Password Required!")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage ="Password Not Matched!")]
        public string ConfirmPassword { get; set; }
    }
}
