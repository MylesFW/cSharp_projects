using System.ComponentModel.DataAnnotations;

namespace dojo_survey.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string Username {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}
        [Required]
        [MinLength(3)]
        public string Comment {get; set;}
    }
}