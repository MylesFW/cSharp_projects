using System.ComponentModel.DataAnnotations;

namespace products_and_categories.Models
{
    public class Association
    {
        [Key]
        [Required]
        public int AssociationId {get;set;}
        public int ProductId {get;set;}
        public int CategoryId {get;set;}
        public Product Product {get;set;}
        public Category Category {get;set;}
    }
}