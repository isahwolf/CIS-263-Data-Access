using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Numerics;

using AutoApp;


var db = new AutoContext();

//db.Banks.Add(new Bank() { BankId = "322271627", Name = "Bank of Edwardsville", State = "IL" });
//db.Banks.Add(new Bank() { BankId = "322271628", Name = "Bank of America", State = "IL" });
//db.Banks.Add(new Bank() { BankId = "322271629", Name = "1st National Bank", State = "IL" });

//db.Autos.Add(new Auto() { VIN = "12345678901234567", Make = "VW", Model = "Jetta", Year = 2001, Cost = 13000, BankId = "322271627" });
//db.Autos.Add(new Auto() { VIN = "23456789012345678", Make = "Ford", Model = "Escort", Year = 1986, Cost = 6000, BankId = "322271627" });
//db.Autos.Add(new Auto() { VIN = "34567890123456789", Make = "Chevy", Model = "Volt", Year = 2013, Cost = 11000, BankId = "322271627" });
//db.Autos.Add(new Auto() { VIN = "45678901234567890", Make = "Ford", Model = "Fairlane", Year = 1968, Cost = 100, BankId = "322271628" });
//db.Autos.Add(new Auto() { VIN = "56789012345678901", Make = "Mazda", Model = "MPV", Year = 1990, Cost = 17000, BankId = "322271629" });

//db.Customers.Add(new Customer() { Email = "A8@webemaxmjKd.com", LastName = "Molunguri", FirstName = "A", Phone = "(705) 555-5237" });
//db.Customers.Add(new Customer() { Email = "AAntosca@netYduo.com", LastName = "Antosca", FirstName = "Andrew", Phone = "(804) 555-6924" });
//db.Customers.Add(new Customer() { Email = "Abdul70@matminvV.edu", LastName = "Antony", FirstName = "Abdul", Phone = "(409) 555-8093" });
//db.Customers.Add(new Customer() { Email = "Ajith@xgMaster.edu", LastName = "Johnson", FirstName = "Ajith", Phone = "(600) 555-4927" });
//db.Customers.Add(new Customer() { Email = "Alan@NsiYYGE.net", LastName = "Rose", FirstName = "Alan", Phone = "(608) 555-6361" });

//db.Sales.Add(new Sale() { Email = "AAntosca@netYduo.com", VIN = "34567890123456789", SaleDate = DateTime.Parse("1/1/24") });
//db.Sales.Add(new Sale() { Email = "Abdul70@matminvV.edu", VIN = "45678901234567890", SaleDate = DateTime.Parse("2/1/24") });
//db.Sales.Add(new Sale() { Email = "A8@webemaxmjKd.com", VIN = "56789012345678901", SaleDate = DateTime.Parse("3/1/24") });
//db.Sales.Add(new Sale() { Email = "Ajith@xgMaster.edu", VIN = "12345678901234567", SaleDate = DateTime.Parse("4/1/24") });
//db.Sales.Add(new Sale() { Email = "Alan@NsiYYGE.net", VIN = "23456789012345678", SaleDate = DateTime.Parse("5/1/24") });

//var customerBankEdwardsville = db.Sales
//    .Where(s => s.Auto.Bank.BankId == "322271627")
//    .Select(s => s.Customer.FirstName + s.Customer.LastName);

//Console.WriteLine();
//Console.WriteLine("Customers with auto loans from the Bank of Edwardsville");
//foreach (var line in customerBankEdwardsville)
//{
//    Console.WriteLine(line);
//}

//using contraints
//using (var db = new AutoContext())
//{
//    try
//    {
//        var auto = new Auto()
//        {
//            VIN = "1HGCM82633A12345",
//            Make = "Ford",
//            Model = "Bronco",
//            Year = 2000,
//            Cost = 16000
//        };
//        db.Autos.Add(auto);
//        db.SaveChanges();
//        Console.WriteLine("Vaild Data");
//    } 
//    catch 
//    {
//        Console.WriteLine("Invaild Data");
//    }
//}

