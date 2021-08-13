using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace products_and_categories.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId {get;set;}
        public string ProductName {get;set;}
        public string ProductDescription {get;set;}
        public double ProductPrice {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> ProductList {get;set;}
    }
}