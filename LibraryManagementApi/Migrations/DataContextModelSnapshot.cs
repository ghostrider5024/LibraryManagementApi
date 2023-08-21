﻿// <auto-generated />
using System;
using LibraryManagementApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.AuthorEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("Birthday")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeathDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Gender")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookAuthorEntity", b =>
                {
                    b.Property<string>("TitleBookId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AuthorId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TitleBookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BorrowStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TitleBookId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("TitleBookId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookGenreEntity", b =>
                {
                    b.Property<string>("TitleBookId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("GenreId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("TitleBookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.CheckingOutEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("BorrowingDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LibrarianId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LibraryCardId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("LibrarianId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("CheckingOut");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.DetailBorrowingBookEntity", b =>
                {
                    b.Property<string>("BookId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BorrowingId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BorrowStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTimeOffset?>("ReturnDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("BookId", "BorrowingId");

                    b.HasIndex("BorrowingId");

                    b.ToTable("DetailBorrowingBook");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.GenreEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.InvoiceEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTimeOffset?>("InvoiceDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.LibrarianEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Librarian");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.LibraryCardEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTimeOffset?>("ExpirationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Gender")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTimeOffset?>("RegistrationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("LibraryCard");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.PublisherEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.RoleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.TitleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset?>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Gages")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Language")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PublisherId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("PublishingYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookAuthorEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.AuthorEntity", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementApi.Repository.Entity.TitleEntity", "Title")
                        .WithMany("BookAuthors")
                        .HasForeignKey("TitleBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.TitleEntity", "Title")
                        .WithMany("Books")
                        .HasForeignKey("TitleBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Title");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookGenreEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.GenreEntity", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementApi.Repository.Entity.TitleEntity", "Title")
                        .WithMany("BookGenres")
                        .HasForeignKey("TitleBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.CheckingOutEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.InvoiceEntity", "Invoice")
                        .WithMany("Borrowings")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementApi.Repository.Entity.LibrarianEntity", "Librarian")
                        .WithMany("Borrowings")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementApi.Repository.Entity.LibraryCardEntity", "LibraryCard")
                        .WithMany("Borrowings")
                        .HasForeignKey("LibraryCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Librarian");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.DetailBorrowingBookEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.BookEntity", "Book")
                        .WithMany("DetailBorrowingBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementApi.Repository.Entity.CheckingOutEntity", "Borrowing")
                        .WithMany("DetailBorrowingBooks")
                        .HasForeignKey("BorrowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borrowing");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.LibrarianEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.RoleEntity", "Role")
                        .WithMany("Librarians")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.LibraryCardEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.RoleEntity", "Role")
                        .WithMany("LibraryCards")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.TitleEntity", b =>
                {
                    b.HasOne("LibraryManagementApi.Repository.Entity.PublisherEntity", "Publisher")
                        .WithMany("Titles")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.AuthorEntity", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.BookEntity", b =>
                {
                    b.Navigation("DetailBorrowingBooks");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.CheckingOutEntity", b =>
                {
                    b.Navigation("DetailBorrowingBooks");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.GenreEntity", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.InvoiceEntity", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.LibrarianEntity", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.LibraryCardEntity", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.PublisherEntity", b =>
                {
                    b.Navigation("Titles");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.RoleEntity", b =>
                {
                    b.Navigation("Librarians");

                    b.Navigation("LibraryCards");
                });

            modelBuilder.Entity("LibraryManagementApi.Repository.Entity.TitleEntity", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookGenres");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}