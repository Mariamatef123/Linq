using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
     "Data Source=.;Initial Catalog=bookstore;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet", Price = 40.00M },
                new Book { Id = 2, Title = "Pro ASP.NET Core MVC", Author = "Adam Freeman", Price = 50.00M },
                new Book { Id = 3, Title = "Clean Code", Author = "Robert C. Martin", Price = 45.00M },
                new Book { Id = 4, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Price = 55.00M },
                new Book { Id = 5, Title = "Design Patterns", Author = "Erich Gamma", Price = 60.00M },
                new Book { Id = 6, Title = "Refactoring", Author = "Martin Fowler", Price = 65.00M }



            );
        }
    }
}
