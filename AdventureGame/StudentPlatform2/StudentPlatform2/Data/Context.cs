using Microsoft.EntityFrameworkCore;
using StudentPlatform2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPlatform2.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        
        }
        public DbSet<Student> Students { get; set; } // en tabell som vi kan göra queries som vi kan stoppa in data i. 
    }
}
