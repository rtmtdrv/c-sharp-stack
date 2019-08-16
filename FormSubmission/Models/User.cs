using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    { 
        [Display(Name="First Name")]
        [Required]
        [MinLength(4, ErrorMessage="First name must be at least 4 chracters long")]
        public string FirstName {get; set;}

        [Display(Name="Last Name")]
        [Required]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters long")]
        public string LastName {get; set;}

        [Required]
        [Range(0, 200, ErrorMessage="Age must be greater than 0")]
        public int Age {get; set;}

        [Display(Name="Email")]
        [EmailAddress]
        [Required]
        public string Email {get; set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long")]
        public string Password {get;set;}
    }
}