using API_MOVIE.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace API_MOVIE.Data
{
    public class MovieDBContext: DbContext
    {
       public MovieDBContext(DbContextOptions<MovieDBContext> options): base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Person> Actors { get; set; }
        public DbSet<MoviePerson> MoviePersons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviePerson>()
                .HasKey(mp => new { mp.MovieId, mp.PersonId });

            modelBuilder.Entity<MoviePerson>()
                .HasOne(mp => mp.Movie)
                .WithMany(m => m.MoviePersons)
                .HasForeignKey(mp => mp.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MoviePerson>()
                .HasOne(mp => mp.Person)
                .WithMany(p => p.MoviePersons)
                .HasForeignKey(mp => mp.PersonId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }


    }
}
