using System;
using BookKeeping.Models;
using Microsoft.EntityFrameworkCore;
namespace BookKeeping.Database
{
    public class BookContext : DbContext

    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<books> Books{ get; set; }
        public DbSet<Author> Authors{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<books>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
           
        }
    }
}

