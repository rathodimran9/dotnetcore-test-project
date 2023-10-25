using PragimTechDotNetCore_Practice.Models;
using System.ComponentModel.DataAnnotations;

namespace PragimTechDotNetCore_Practice.ViewModels
{
    public class EmployeeCreateViewModel
    {        
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }        
        public int Age { get; set; }        
        public IFormFile Photo { get; set; }
    }
}
