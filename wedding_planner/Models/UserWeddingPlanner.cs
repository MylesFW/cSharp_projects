using System.ComponentModel.DataAnnotations;

namespace wedding_planner.Models
{
    public class UserWeddingPlanner
    {
        [Key]
        [Required]
        public int UserWeddingPlannerID {get; set;}
        public int UserID {get;set;}
        public User User {get;set;}
        public int WeddingID {get;set;}
        public Wedding Wedding {get;set;}
    }
}