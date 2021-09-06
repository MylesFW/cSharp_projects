using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
  public class Wedding
  {
    [Key]
    public int WeddingId { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
    public string WedderOne { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
    public string WedderTwo { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime Date {get; set; }
    [Required]
    [MinLength(5, ErrorMessage = "must be at least 5 characters.")]
    public string Address  { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int UserId { get; set; } //1 user : many weddings
    public User CreatedBy { get; set; }
    public List<UserWeddingRSVP> RSVPs { get; set; }
  }
}