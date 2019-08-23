using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_belt_exam.Models 
{
    [Table("activities")]
    public class Activity
    {
        [Key]
        public int ActivityId {get;set;}

        [Required]
        [Display(Name= "Title")]
        public string Title {get;set;}

        [Display(Name= "Time")]
        public string Time {get;set;}

        [Required]
        [NoPastDate(ErrorMessage="Date must be a future date")]
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}

        public string Duration {get;set;}

        [Required]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public int UserId {get; set;}
        public User Coordinator {get;set;}
        public List<Participant> Participants {get;set;}
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