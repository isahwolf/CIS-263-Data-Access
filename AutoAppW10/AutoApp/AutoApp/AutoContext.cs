using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AutoApp
{
    internal class AutoContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public DbSet<BankAutoCustomerDTO> BankAutoCustomerDTOs { get; set; }

        public DbSet<GetBankCustomersDTO> GetBankCustomersDTOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? cs = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true,
               reloadOnChange: true).Build().GetConnectionString("AutoCS");

            optionsBuilder.UseSqlServer(cs);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAutoCustomerDTO>(x =>
            {
                x.HasNoKey();
                x.ToView("BankAutoCustomers");
            });

            modelBuilder.Entity<GetBankCustomersDTO>(x =>
            {
                x.HasNoKey();
                x.ToView("GetBankCustomers");
            });
        }

    }
}
