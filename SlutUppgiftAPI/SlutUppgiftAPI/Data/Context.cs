using Microsoft.EntityFrameworkCore;
using SlutUppgiftAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgiftAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { } // Empty constructor
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ReleaseDate> ReleaseDates { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasKey(t => new { t.AuthorId, t.BookId });//FK TILLDELNING

            modelBuilder.Entity<Book_Author>()
                .HasOne(pt => pt.Book)//relationen one
                .WithMany(p => p.Book_Authors)//relationen many
                .HasForeignKey(pt => pt.BookId);//FK kopplingen som vi gjort på rad 25&26

            modelBuilder.Entity<Book_Author>()
                .HasOne(pt => pt.Author)
                .WithMany(t => t.Book_Authors)
                .HasForeignKey(pt => pt.AuthorId);
        }

    }

    // Nästa tabell nedan 





    //////////////////////////////////////////////////////////////////////////////////// Använda SeedData???? ////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////// Använda SeedData???? ////////////////////////////////////////////////////////////////////////////////////
}


       
