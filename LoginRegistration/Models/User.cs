using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models 
{
    [Table("users")]
    public class User
    {
        [Key]
        public int UserId {get;set;}
        
        [Required]
        [MinLength(2, ErrorMessage="First Name must be at least 2 characters")]
        [Display(Name="First Name")]
        public string FirstName {get;set;}
        
        [Required]
        [Display(Name="Last Name")]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters")]
        public string LastName {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}
       
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters")]
        public string Password {get; set;}

        [NotMapped]
        [Display(Name="Confirm Password")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class LoginUser 
    {
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}