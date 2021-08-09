using System.ComponentModel.DataAnnotations;

namespace dojo_survey.Models
{
    public class DojoSurvey
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set;}

        [Required]
        public string Location { get; set;}
        [Required]
        public string Language { get; set;}
        [MaxLength(21)]
        public string Comment { get; set;}
    }
}