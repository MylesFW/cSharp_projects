using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wedding_planner.Models
{
    public class Wedding
    {
        [Key]
        [Required]
        public int WeddingID {get;set;}


        [Required]
        [Display(Name = "Product Name")]
        public string WedderOne {get;set;}


        [Required]
        [Display(Name = "Product Description")]
        public string WedderTwo {get;set;}


        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<UserWeddingPlanner> UserWeddingPlanner {get;set;}
    }
}