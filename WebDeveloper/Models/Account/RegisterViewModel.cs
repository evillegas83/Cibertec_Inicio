using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Models.Account
{
    public class RegisterViewModel
    {
        // [Display(Name = "Client_Id", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This user name is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Compare("Password", ErrorMessage = "The password and confirm password do not match")]
        [Required(ErrorMessage = "This confirm password is requerid")]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
