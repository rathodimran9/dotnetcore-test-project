using System.ComponentModel.DataAnnotations;

namespace PragimTechDotNetCore_Practice.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
