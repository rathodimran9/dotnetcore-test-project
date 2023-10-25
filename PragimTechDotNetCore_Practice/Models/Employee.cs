using System.ComponentModel.DataAnnotations;

namespace PragimTechDotNetCore_Practice.Models
{
    public class Employee
    {
        
        public int Id { get; set; }
        [Required, StringLength(50)]        
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string PhotoPath { get; set; }
    }
}
