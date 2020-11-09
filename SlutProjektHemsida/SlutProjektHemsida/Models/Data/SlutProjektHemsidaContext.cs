using Microsoft.EntityFrameworkCore;
using SlutProjektHemsida.Models;

namespace SlutProjektHemsida.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }


    }
}
