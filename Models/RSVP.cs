using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam.Models
{
    public class RSVP
    {
        public int RSVPId { get; set; }
        public int ActivitayId { get; set; }
        public int UserId { get; set; }
        public Activitay Activitays { get; set; }
        public User Attendees { get; set; }
    }
}