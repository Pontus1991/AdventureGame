using Microsoft.EntityFrameworkCore;
using OnlineBibliotek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBibliotek.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { } // Empty constructor

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ReleaseDate> ReleaseDates { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Author_Book> Author_Books { get; set; }
        public DbSet<Rental_Book> Rental_Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>()
                .HasKey(sc => new { sc.AuthurId, sc.BookId });

            modelBuilder.Entity<Author_Book>()
                .HasOne(sc => sc.Author)
                .WithMany(s => s.Author_Book)
                .HasForeignKey(sc => sc.AuthurId);

            modelBuilder.Entity<Author_Book>()
                .HasOne(sc => sc.Book)
                .WithMany(c => c.Author_Book)
                .HasForeignKey(sc => sc.BookId);

            // Nästa tabell nedan 

            modelBuilder.Entity<Rental_Book>()
               .HasKey(sc => new { sc.RentalId, sc.BookId });

            modelBuilder.Entity<Rental_Book>()
                .HasOne(sc => sc.Rental)
                .WithMany(s => s.Rental_Book)
                .HasForeignKey(sc => sc.BookId);

            modelBuilder.Entity<Rental_Book>()
                .HasOne(sc => sc.Book)
                .WithMany(c => c.Rental_Book)
                .HasForeignKey(sc => sc.RentalId);











            //////////////////////////////////////////////////////////////////////////////////// Använda SeedData???? ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////// Använda SeedData???? ////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
