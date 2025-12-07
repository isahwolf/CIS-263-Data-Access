using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AutosMVC.Models;

namespace AutosMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Auto> Autos { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
