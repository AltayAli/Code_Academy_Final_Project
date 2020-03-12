using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Models
{
    public class RegisterModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(400)]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"^((\(?\+994\)?)|(0))?\d{2}-\d{3}-\d{2}-\d{2}$")]
        public string PhoneNumber { get; set; }
    }
}
