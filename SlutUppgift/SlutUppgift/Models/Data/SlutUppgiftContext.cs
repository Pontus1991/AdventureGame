using Microsoft.EntityFrameworkCore;
using SlutUppgift.Models;

namespace SlutUppgift.Data
{
    public class SlutUppgiftContext : DbContext
    {
        public SlutUppgiftContext(DbContextOptions<SlutUppgiftContext> options)
            : base(options)
        {
        }

        public DbSet<Track> Track { get; set; }

        public DbSet<User2> User2 { get; set; }
    }
}

