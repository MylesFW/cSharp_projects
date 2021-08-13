using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace chefs_and_dishes.Models
{
    public class Dish
    {
        [Key]
            [Required]
        public int DishId {get;set;}
            [Required]
            [Display(Name = "Name of Dish")]
        public string DishName {get;set;}
            [Required]
            [Display(Name = "# of Calories")]
        public int Calories {get;set;}

            [Required]
            [Display(Name = "Description")]
        public string Description { get; set; }
            [Required]
            [Display(Name = "Tastiness")]

        public int Tastiness { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int ChefId {get;set;}
        public Chef Creator {get;set;}
    }
}