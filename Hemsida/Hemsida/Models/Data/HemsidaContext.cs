using Microsoft.EntityFrameworkCore;
using Hemsida.Models;

namespace Hemsida.Data
{
    public class HemsidaContext : DbContext
    {
        public HemsidaContext(DbContextOptions<HemsidaContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Login { get; set; }
    }
}
