using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BowlingHallen4.Models;

namespace BowlingHallen4.Data
{
    public class BowlingHallen4Context : DbContext
    {
        public BowlingHallen4Context (DbContextOptions<BowlingHallen4Context> options)
            : base(options)
        {
        }

        public DbSet<BowlingHallen4.Models.Track> Track { get; set; }
    }
}
