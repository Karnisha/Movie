using Microsoft.EntityFrameworkCore;

namespace Movies.Data
{

       public class MoviesDbContext :DbContext
   {
         public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
         {

         }

     public DbSet<Movies> Movies { get; set; }
   }
}

