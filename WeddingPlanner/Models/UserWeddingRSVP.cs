using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class UserWeddingRSVP // Many To Many 'Through' / 'Join' Table
    {
        [Key]
        public int UserWeddingRSVPId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public int UserId { get; set; } // FK
        public User User { get; set; }
        public int WeddingId { get; set; } // Fk
        public Wedding Wedding { get; set; }
    }
}