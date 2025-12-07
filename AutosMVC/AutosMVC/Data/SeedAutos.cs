using AutosMVC.Data;
using AutosMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMVC.Data
{
    public static class SeedAutos
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext db = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (!db.Banks.Any())
            {
                db.Banks.AddRange(
                    new Bank() { RoutingNum = "322271627", Name = "Bank of Edwardsville", State = "IL" },
                    new Bank() { RoutingNum = "322271628", Name = "Bank of America", State = "IL" },
                    new Bank() { RoutingNum = "322271629", Name = "1st National Bank", State = "IL" }
                );
                db.SaveChanges();
            }

            if (!db.Autos.Any())
            {
                db.Autos.AddRange(
                    new Auto() { VIN = "12345678901234567", Make = "VW", Model = "Jetta", Year = 2001, Cost = 13000, RoutingNum = "322271627" },
                    new Auto() { VIN = "23456789012345678", Make = "Ford", Model = "Escort", Year = 1986, Cost = 6000, RoutingNum = "322271627" },
                    new Auto() { VIN = "34567890123456789", Make = "Chevy", Model = "Volt", Year = 2013, Cost = 11000, RoutingNum = "322271627" },
                    new Auto() { VIN = "45678901234567890", Make = "Ford", Model = "Fairlane", Year = 1968, Cost = 100, RoutingNum = "322271628" },
                    new Auto() { VIN = "56789012345678901", Make = "Mazda", Model = "MPV", Year = 1990, Cost = 17000, RoutingNum = "322271629" }
                );
                db.SaveChanges();
            }

        }
    }
}