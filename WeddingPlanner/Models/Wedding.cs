using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models 
{
    [Table("weddings")]
    public class Wedding
    {
        private const string V = "Wedder One";
        private const string V1 = "Wedder Two";

        [Key]
        public int WeddingId {get;set;}

        [Required]
        [Display(Name= V)]
        public string WedderOne {get;set;}

        [Required]
        [Display(Name= V1)]
        public string WedderTwo {get;set;}

        [Required]
        [NoPastDate(ErrorMessage="Date must be a future date")]
        public DateTime Date {get;set;}

        [Required]
        public string Address {get;set;}

        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public int UserId {get; set;}
        public User Planner {get;set;}
        public List<Response> Responses {get;set;}
    }

    public class NoPastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value <= DateTime.Now)
                return new ValidationResult("Date must be in the future");
            return ValidationResult.Success;
        }
    }
}