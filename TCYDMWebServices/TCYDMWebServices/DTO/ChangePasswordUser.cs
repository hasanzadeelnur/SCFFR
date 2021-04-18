using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.DTO
{
    public class ChangePasswordUser
    {
        [Required(ErrorMessage = "Old Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Minimum password lenght must be 6 characters")]
        [MaxLength(200, ErrorMessage = "Max lenght limit is 200")]
        [Display(Prompt = "Old Password")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Minimum password lenght must be 6 characters")]
        [MaxLength(200, ErrorMessage = "Max lenght limit is 200")]
        [Display(Prompt = "Password")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords are not match")]
        [Display(Prompt = "Confirm Password")]
        public string Password_Compare { get; set; }
        public int id { get; set; }
    }
}
