using Microsoft.EntityFrameworkCore;

namespace AuditoriumManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Seat> Seats { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
    }

    public class Seat : Entity
    {
        public Auditorium Auditorium { get; set; }
        public int Row {  get; set; }
        public int Place {  get; set; }
    }

    public class Auditorium : Entity
    {
        public int AuditoriumNumber { get; set; }
    }
}
