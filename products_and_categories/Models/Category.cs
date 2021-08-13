using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace products_and_categories.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId {get;set;}
        public string CategoryName {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> CategoryList {get;set;}
        }
}