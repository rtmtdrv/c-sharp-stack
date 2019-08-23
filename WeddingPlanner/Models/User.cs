using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models 
{
    [Table("users")]
    public class User 
    {
        private const string P = "Password must be atleast 8 characters, foo.";
        private const string V = "Confirm Password";
        private const string V1 = "Password";
        private const string V2 = "First Name";
        private const string V3 = "Last Name";

        [Key]
        public int UserId {get; set;}
        
        [Required]
        [Display(Name= V2)]
        public string FirstName {get;set;}
        
        [Required]
        [Display(Name= V3)]
        public string LastName {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = P)]
        public string Password {get;set;}

        [NotMapped]
        [Display(Name= V)]
        [Compare(V1)]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public List<Response> ResponsesGiven {get;set;}
    }

    public class LoginUser 
    {
        private const string V = "Password";
        private const string V1 = "Email";

        [Required]
        [EmailAddress]
        [Display(Name= V1)]
        public string LoginEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name= V)]
        public string LoginPassword {get;set;}
    }
}