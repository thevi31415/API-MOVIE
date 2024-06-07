using API_MOVIE.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_MOVIE.Data
{
    public class MovieDBContext: DbContext
    {
       public MovieDBContext(DbContextOptions<MovieDBContext> options): base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Person> Actors { get; set; }
    }
}
