using Microsoft.EntityFrameworkCore;

namespace AuditoriumManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Cinema;Username=postgres;Password=admin");
        }

        public DbSet<Seat> Seats { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
    }

    public class Seat : Entity
    {
        public int AuditoriumId { get; set; }
        public Auditorium Auditorium { get; set; }
        public int Row {  get; set; }
        public int Place {  get; set; }
    }

    public class Auditorium : Entity
    {
        public int AuditoriumNumber { get; set; }
    }
}
