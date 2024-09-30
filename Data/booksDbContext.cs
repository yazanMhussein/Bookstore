using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class booksDbContext : DbContext
    {
        public booksDbContext(DbContextOptions<booksDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Start with Why how great leaders inspire everyone to take action",
                    Author = "Simon Sinek",
                    Genre = "Business Books",
                    Price = 5
                }
                );
        }
       
    }

}