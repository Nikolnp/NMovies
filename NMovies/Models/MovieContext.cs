using Microsoft.EntityFrameworkCore;


namespace NMovies.Models
{
    public class MovieContext:DbContext
    {
      
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Movie>().HasMany(m=> m.MovieRatings).WithOne(r => r.Movie).HasForeignKey(r => r.MovieId);
            modelBuilder.Entity<MovieRating>().HasOne(mr => mr.Movie).WithMany(mrtngs => mrtngs.MovieRatings).HasForeignKey(mrtngs => mrtngs.MovieId);
            modelBuilder.Entity<MovieRating>().HasOne(u => u.User).WithMany(u => u.MovieRatings).HasForeignKey(u => u.UserId);
            modelBuilder.Entity<User>().HasMany(u => u.MovieRatings).WithOne(r => r.User).HasForeignKey(r => r.UserId);

                modelBuilder.Seed();
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<MovieRating> Ratings { get; set; }

       
    }
    
}
