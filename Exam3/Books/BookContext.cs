using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class BookContext : DbContext
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

            modelBuilder.Entity<Author>(x => {

                x.HasData(
                    new Author { AuthorId = 1, FirstName = "Paul", LastName = "Deitel" },
                    new Author { AuthorId = 2, FirstName = "Harvey", LastName = "Deitel" },
                    new Author { AuthorId = 3, FirstName = "Abbey", LastName = "Deitel" },
                    new Author { AuthorId = 4, FirstName = "Sue", LastName = "Black" },
                    new Author { AuthorId = 5, FirstName = "John", LastName = "Purple" },
                    new Author { AuthorId = 6, FirstName = "Tim", LastName = "Brown" }
                    );
            });

            modelBuilder.Entity<Title>(x => {

                x.HasData(
                    new Title { ISBN = "132151006", BookTitle = "Internet & World Wide Web How to Program" },
                    new Title { ISBN = "132575655", BookTitle = "Java How to Program, Late Objects Version" },
                    new Title { ISBN = "133406954", BookTitle = "Visual Basic 2012 How to Program" },
                    new Title { ISBN = "133807800", BookTitle = "Java How to Program" },
                    new Title { ISBN = "133965260", BookTitle = "iOS 8 for Programmers: An App-Driven Approach with Swift" },
                    new Title { ISBN = "133976890", BookTitle = "C How to Program" },
                    new Title { ISBN = "134021363", BookTitle = "Swift for Programmers" },
                    new Title { ISBN = "134289366", BookTitle = "Android 6 for Programmers: An App-Driven Approach" },
                    new Title { ISBN = "134444302", BookTitle = "Android How to Program" },
                    new Title { ISBN = "134448235", BookTitle = "C++ How to Program" },
                    new Title { ISBN = "134601548", BookTitle = "Visual C# How to Program" }
                    );
            });

            modelBuilder.Entity<AuthorTitle>(x => {

                x.HasData(
                    new AuthorTitle { ISBN = "132151006", AuthorId = 1 },
                    new AuthorTitle { ISBN = "132575655", AuthorId = 1 },
                    new AuthorTitle { ISBN = "133406954", AuthorId = 1 },
                    new AuthorTitle { ISBN = "133807800", AuthorId = 1 },
                    new AuthorTitle { ISBN = "133965260", AuthorId = 1 },
                    new AuthorTitle { ISBN = "133976890", AuthorId = 1 },
                    new AuthorTitle { ISBN = "134021363", AuthorId = 1 },
                    new AuthorTitle { ISBN = "134289366", AuthorId = 1 },
                    new AuthorTitle { ISBN = "134444302", AuthorId = 1 },
                    new AuthorTitle { ISBN = "134448235", AuthorId = 1 },
                    new AuthorTitle { ISBN = "134601548", AuthorId = 1 },
                    new AuthorTitle { ISBN = "132151006", AuthorId = 2 },
                    new AuthorTitle { ISBN = "132575655", AuthorId = 2 },
                    new AuthorTitle { ISBN = "133406954", AuthorId = 2 },
                    new AuthorTitle { ISBN = "133807800", AuthorId = 2 },
                    new AuthorTitle { ISBN = "133965260", AuthorId = 2 },
                    new AuthorTitle { ISBN = "133976890", AuthorId = 2 },
                    new AuthorTitle { ISBN = "134021363", AuthorId = 2 },
                    new AuthorTitle { ISBN = "134289366", AuthorId = 2 },
                    new AuthorTitle { ISBN = "134444302", AuthorId = 2 },
                    new AuthorTitle { ISBN = "134448235", AuthorId = 2 },
                    new AuthorTitle { ISBN = "134448235", AuthorId = 3 },
                    new AuthorTitle { ISBN = "133406954", AuthorId = 3 },
                    new AuthorTitle { ISBN = "134289366", AuthorId = 4 }
                    );
            });
        }
    }
}
