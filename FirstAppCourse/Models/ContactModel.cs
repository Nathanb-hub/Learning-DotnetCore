using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppCourse.Models
{
    public class ContactModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Too Short")]
        public string Name { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(6)]
        public string Password { get; set; }
    }
}
