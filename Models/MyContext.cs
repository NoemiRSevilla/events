using Microsoft.EntityFrameworkCore;

namespace exam.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter alongcopy
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Activitay> activitays { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
    }
} 