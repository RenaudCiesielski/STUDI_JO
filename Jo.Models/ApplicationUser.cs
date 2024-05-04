using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo.Models
{
    public class ApplicationUser : IdentityUser 
    {
        [Required]
        public string Name {  get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        public string AddressComplement { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
