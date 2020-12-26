using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbBibliotek.Models;

namespace WebbBibliotek.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Måste säga åt entity Framework hur vi vill att denna many-tomany-ralation ska vara. 
        {
            modelBuilder.Entity<Book_Author>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<Book_Author>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<Book_Author>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(ba => ba.AuthorId);

            //Lånedatum och Returdatum (DateTime)
            modelBuilder.Entity<Rental>()
            .Property(l => l.RentalDate)
            .HasDefaultValueSql("GETDATE()");


        }

    }
}
