using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SlutProjektHemsida.Models;

namespace SlutProjektHemsida.Data
{
    public class SlutProjektHemsidaContext : DbContext
    {
        public SlutProjektHemsidaContext (DbContextOptions<SlutProjektHemsidaContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
