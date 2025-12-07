using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Exam4
{
    internal class Exam4Context : DbContext
    {
        public Exam4Context() { }

        public Exam4Context(DbContextOptions<Exam4Context> options)
            : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Dependent> Dependents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Exam4;Integrated Security=True;encrypt=false");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(SeedData.Employees);
            modelBuilder.Entity<Absence>().HasData(SeedData.Absences);
            modelBuilder.Entity<Dependent>().HasData(SeedData.Dependents);
        }
    }

}
