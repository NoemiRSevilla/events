using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam.Models
{

    public class Activitay
    {
        [Key]
        public int ActivitayId { get; set; }
        [Required]
        public string Title { get; set; }
        [FutureDate]
        public DateTime Day { get; set; }
        public int Duration { get; set; }
        public string DurationInfo {get;set;}
        public User Creator { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public List <RSVP> RSVPs {get;set;}

    }
}