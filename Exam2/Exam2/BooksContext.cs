using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class BooksContext : DbContext
    {
        public DbSet<Title> Titles { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<AuthorTitle> AuthorTitles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true,
               reloadOnChange: true).Build().GetConnectionString("BooksCS")!;

            optionsBuilder.UseSqlServer(cs);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                        .Property(a => a.AuthorId)
                        .ValueGeneratedNever();
        }

    }
}
