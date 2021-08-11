using System;
using System.ComponentModel.DataAnnotations;

namespace crud_elicious.Models
{
    public class Dish
    {
        [Key]
        [Required]
        public int DishId {get; set;}
        [Required]

        public string Name {get; set;}
        [Required]

        public string Chef {get; set;}
        [Required]

        public int Tastiness {get; set;}
        [Required]
        [Range(0, 100000)]


        public int Calories {get; set;}
        [Required]

        public string Description {get; set;}
        [Required]

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}