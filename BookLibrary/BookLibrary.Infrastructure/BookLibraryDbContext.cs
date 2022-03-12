using BookLibrary.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data
{
    public class BookLibraryDbContext : IdentityDbContext
    {
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options)
            : base(options)
        {
        }

       // public DbSet<Author> Authors { get; init; }
        public DbSet<Book> Books { get; init; }
        public DbSet<Category> Categories { get; init; }
       // public DbSet<BookCategory> Bookcategories /{ get; /init; }
       // public DbSet<BookLanguage> BookLanguages /{ get; /init; }
       // public DbSet<Category> Categories { get; init; }
       // public DbSet<Order> Orders { get; init; }
       // public DbSet<Publisher> Publishers { get; /init; }
       // public DbSet<User> Users { get; init; }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);

          //builder
          //    .Entity<BookAuthor>()
          //     .HasKey(b => new { b.BookId, //b.AuthorId });
          //
          //builder
          //    .Entity<BookCategory>()
          //     .HasKey(b => new { b.BookId, //b.CategoryId });
          //
           


            
        }

    }
}