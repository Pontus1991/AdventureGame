﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebbBibliotek.Data;

namespace WebbBibliotek.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210105131918_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebbBibliotek.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ISBN")
                        .HasColumnType("bigint");

                    b.Property<int?>("InventoryId")
                        .HasColumnType("int");

                    b.Property<int?>("RatingId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("char(4)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("BookId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("RatingId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Book_Author", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book_Authors");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LibraryCard")
                        .HasColumnType("int");

                    b.Property<int?>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("RentalId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Rental", b =>
                {
                    b.Property<int>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("InventoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RentalDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("Rented")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RentalId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Book", b =>
                {
                    b.HasOne("WebbBibliotek.Models.Inventory", "Inventory")
                        .WithMany("Books")
                        .HasForeignKey("InventoryId");

                    b.HasOne("WebbBibliotek.Models.Rating", "Rating")
                        .WithMany("Books")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebbBibliotek.Models.Book_Author", b =>
                {
                    b.HasOne("WebbBibliotek.Models.Author", "Author")
                        .WithMany("Book_Authors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebbBibliotek.Models.Book", "Book")
                        .WithMany("Book_Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebbBibliotek.Models.Customer", b =>
                {
                    b.HasOne("WebbBibliotek.Models.Rental", null)
                        .WithMany("Customers")
                        .HasForeignKey("RentalId");
                });

            modelBuilder.Entity("WebbBibliotek.Models.Rental", b =>
                {
                    b.HasOne("WebbBibliotek.Models.Inventory", "Inventory")
                        .WithMany("Rentals")
                        .HasForeignKey("InventoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
