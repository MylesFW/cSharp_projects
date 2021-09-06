using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wedding_planner.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }


        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords muct match.")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<UserWeddingPlanner> UserWeddingPlanner {get;set;}

    }
}