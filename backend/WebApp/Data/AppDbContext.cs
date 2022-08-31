using Microsoft.EntityFrameworkCore;
using WebApp.Model;

namespace WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //    optionsBuilder.UseSqlServer();
        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<CinemaHall> cinemaHall { get; set; }
        public DbSet<Reservation> reservation { get; set; }
        public DbSet<Showing> showing { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    movieId = 1,
                    title = "AAA",
                    description = "AA",
                    year = 2022,
                    length = 150,
                    posterURL = "https://i.etsystatic.com/22295500/r/il/bd145e/2433214065/il_794xN.2433214065_q359.jpg"
                }
                );
                
        }
    }
}
