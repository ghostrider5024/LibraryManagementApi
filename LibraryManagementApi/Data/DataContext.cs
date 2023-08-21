using LibraryManagementApi.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static LibraryManagementApi.Utilities.Const.WebApiEndPoint;

namespace LibraryManagementApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = config["ConnectionStrings:DefaultConnection"];
            return strConn;
        }

        public DbSet<TitleEntity> Title { get; set; }
        public DbSet<BookEntity> Book { get; set; }
        public DbSet<AuthorEntity> Author { get; set; }
        public DbSet<PublisherEntity> Publisher { get; set; }
        public DbSet<GenreEntity> Genre { get; set; }
        public DbSet<LibraryCardEntity> LibraryCard { get; set; }
        public DbSet<LibrarianEntity> Librarian { get; set; }
        public DbSet<CheckingOutEntity> CheckingOut { get; set; }
        public DbSet<DetailBorrowingBookEntity> DetailBorrowingBook { get; set; }
        public DbSet<BookGenreEntity> BookGenre { get; set; }
        public DbSet<BookAuthorEntity> BookAuthor { get; set; }
        public DbSet<RoleEntity> Role { get; set; }
        public DbSet<InvoiceEntity> Invoice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many relation between Publisher and Title
            modelBuilder.Entity<TitleEntity>()
                .HasOne(pk => pk.Publisher)
                .WithMany(fk => fk.Titles)
                .HasForeignKey(fk => fk.PublisherId);


            // One to Many relation between Title and Book
            modelBuilder.Entity<BookEntity>()
                .HasOne(pk => pk.Title)
                .WithMany(fk => fk.Books)
                .HasForeignKey(fk => fk.TitleBookId);


            // One to Many relation between Role and LibraryCard
            modelBuilder.Entity<LibraryCardEntity>()
                .HasOne(pk => pk.Role)
                .WithMany(fk => fk.LibraryCards)
                .HasForeignKey(fk => fk.RoleId);

            // One to Many relation between Role and Librarian
            modelBuilder.Entity<LibrarianEntity>()
                .HasOne(pk => pk.Role)
                .WithMany(fk => fk.Librarians)
                .HasForeignKey(fk => fk.RoleId);

            // One to Many relation between LibraryCard and CheckingOut
            modelBuilder.Entity<CheckingOutEntity>()
                .HasOne(pk => pk.LibraryCard)
                .WithMany(fk => fk.Borrowings)
                .HasForeignKey(fk => fk.LibraryCardId);


            // One to Many relation between Librarian and CheckingOut
            modelBuilder.Entity<CheckingOutEntity>()
                .HasOne(pk => pk.Librarian)
                .WithMany(fk => fk.Borrowings)
                .HasForeignKey(fk => fk.LibrarianId);

            
            // One to Many relation between Invoice and CheckingOut
            modelBuilder.Entity<CheckingOutEntity>()
                .HasOne(pk => pk.Invoice)
                .WithMany(fk => fk.Borrowings)
                .HasForeignKey(fk => fk.InvoiceId);


            // Many to Many relation between CheckingOut and Book
            modelBuilder.Entity<DetailBorrowingBookEntity>()
                    .HasKey(pk => new { pk.BookId, pk.BorrowingId });
            modelBuilder.Entity<DetailBorrowingBookEntity>()
                    .HasOne(t => t.Borrowing)
                    .WithMany(t => t.DetailBorrowingBooks)
                    .HasForeignKey(f => f.BorrowingId);
            modelBuilder.Entity<DetailBorrowingBookEntity>()
                    .HasOne(t => t.Book)
                    .WithMany(t => t.DetailBorrowingBooks)
                    .HasForeignKey(f => f.BookId);

            // Many to Many relation between Book and Genre
            modelBuilder.Entity<BookGenreEntity>()
                    .HasKey(pk => new { pk.TitleBookId, pk.GenreId });
            modelBuilder.Entity<BookGenreEntity>()
                    .HasOne(t => t.Title)
                    .WithMany(t => t.BookGenres)
                    .HasForeignKey(f => f.TitleBookId);
            modelBuilder.Entity<BookGenreEntity>()
                    .HasOne(t => t.Genre)
                    .WithMany(t => t.BookGenres)
                    .HasForeignKey(f => f.GenreId);

            // Many to Many relation between Book and Author
            modelBuilder.Entity<BookAuthorEntity>()
                    .HasKey(pk => new { pk.TitleBookId, pk.AuthorId });
            modelBuilder.Entity<BookAuthorEntity>()
                    .HasOne(t => t.Title)
                    .WithMany(t => t.BookAuthors)
                    .HasForeignKey(f => f.TitleBookId);
            modelBuilder.Entity<BookAuthorEntity>()
                    .HasOne(t => t.Author)
                    .WithMany(t => t.BookAuthors)
                    .HasForeignKey(f => f.AuthorId);

        }

    }
}
