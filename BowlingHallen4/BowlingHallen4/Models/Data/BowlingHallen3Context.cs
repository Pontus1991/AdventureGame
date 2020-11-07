using Microsoft.EntityFrameworkCore;
using BowlingHallen4.Models;

namespace BowlingHallen3.Data
{
    public class BowlingHallen4Context : DbContext
    {
        public BowlingHallen4Context(DbContextOptions<BowlingHallen4Context> options)
            : base(options)
        {
        }

        public DbSet<Track> Track { get; set; }
    }
}
