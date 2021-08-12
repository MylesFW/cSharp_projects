using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login_and_registration.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

            [Required(ErrorMessage = "First Name is required")]
            [MinLength(2, ErrorMessage = "must be at least 2 characters")]
            [Display(Name = "First Name")]
        public string FirstName { get; set; }

            [Required(ErrorMessage = "Last Name is required")]
            [MinLength(2, ErrorMessage = "must be at least 2 characters")]
            [Display(Name = "Last Name")]
        public string LastName { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invaild. Please use a valid Email Address.")]
            [Display(Name = "Email")]
        public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [MinLength(8, ErrorMessage = "must be at least 8 characters")]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
        public string Password { get; set; }

            [NotMapped]
            [Compare("Password")]
            [DataType(DataType.Password)]
            [Display(Name = "Password Confirmation")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        }
    }
