using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksApp
{
    internal class BooksContext : DbContext
    {
        public DbSet<Title> Titles { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Books;Integrated Security=True;encrypt=false");
    }
}
