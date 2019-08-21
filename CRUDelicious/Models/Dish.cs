
using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        [Required]

        [Display(Name="Chef's Name")]
        public string Chef {get; set;}
        [Required]

        [Display(Name="Name of Dish")]
        public string Name {get; set;}
        [Required]

        [Display(Name="# of Calories")]
        public int Calories {get; set;}
        [Required]

        public int Tastiness {get; set;}
        [Required]

        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}