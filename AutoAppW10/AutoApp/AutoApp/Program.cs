using AutoApp;
using Microsoft.EntityFrameworkCore;


var db = new AutoContext();

if (!db.Banks.Any())
{
    db.Banks.Add(new Bank() { RoutingNum = "322271627", Name = "Bank of Edwardsville", State = "IL" });
    db.Banks.Add(new Bank() { RoutingNum = "322271628", Name = "Bank of America", State = "IL" });
    db.Banks.Add(new Bank() { RoutingNum = "322271629", Name = "1st National Bank", State = "IL" });
    db.SaveChanges();
}

if (!db.Autos.Any())
{
    db.Autos.Add(new Auto() { VIN = "12345678901234567", Make = "VW", Model = "Jetta", Year = 2001, Cost = 13000, RoutingNum = "322271627" });
    db.Autos.Add(new Auto() { VIN = "23456789012345678", Make = "Ford", Model = "Escort", Year = 1986, Cost = 6000, RoutingNum = "322271627" });
    db.Autos.Add(new Auto() { VIN = "34567890123456789", Make = "Chevy", Model = "Volt", Year = 2013, Cost = 11000, RoutingNum = "322271627" });
    db.Autos.Add(new Auto() { VIN = "45678901234567890", Make = "Ford", Model = "Fairlane", Year = 1968, Cost = 100, RoutingNum = "322271628" });
    db.Autos.Add(new Auto() { VIN = "56789012345678901", Make = "Mazda", Model = "MPV", Year = 1990, Cost = 17000, RoutingNum = "322271629" });
    db.SaveChanges();
}

if (!db.Customers.Any())
{
    db.Customers.Add(new Customer() { Email = "A8@webemaxmjKd.com", LastName = "Molunguri", FirstName = "A", PhoneNumber = "(705) 555-5237" });
    db.Customers.Add(new Customer() { Email = "AAntosca@netYduo.com", LastName = "Antosca", FirstName = "Andrew", PhoneNumber = "(804) 555-6924" });
    db.Customers.Add(new Customer() { Email = "Abdul70@matminvV.edu", LastName = "Antony", FirstName = "Abdul", PhoneNumber = "(409) 555-8093" });
    db.Customers.Add(new Customer() { Email = "Ajith@xgMaster.edu", LastName = "Johnson", FirstName = "Ajith", PhoneNumber = "(600) 555-4927" });
    db.Customers.Add(new Customer() { Email = "Alan@NsiYYGE.net", LastName = "Rose", FirstName = "Alan", PhoneNumber = "(608) 555-6361" });
    db.SaveChanges();
}

if (!db.Sales.Any())
{
    db.Sales.Add(new Sale() { Email = "AAntosca@netYduo.com", VIN = "34567890123456789", SaleDate = DateTime.Parse("1/1/24") });
    db.Sales.Add(new Sale() { Email = "Abdul70@matminvV.edu", VIN = "45678901234567890", SaleDate = DateTime.Parse("2/1/24") });
    db.Sales.Add(new Sale() { Email = "A8@webemaxmjKd.com", VIN = "56789012345678901", SaleDate = DateTime.Parse("3/1/24") });
    db.Sales.Add(new Sale() { Email = "Ajith@xgMaster.edu", VIN = "12345678901234567", SaleDate = DateTime.Parse("4/1/24") });
    db.Sales.Add(new Sale() { Email = "Alan@NsiYYGE.net", VIN = "23456789012345678", SaleDate = DateTime.Parse("5/1/24") });
    db.SaveChanges();
}


//-----------------------------------Customer's bank

var bc = db.Sales
    .Where(s => s.Customer.Email == "A8@webemaxmjKd.com")
    .Select(s =>
    $"{s.Customer.FirstName,10}" +
    $"{s.Customer.LastName,10}" +
    $"{s.Auto.Make,10}" +
    $"{s.Auto.Model,10}" +
    $"{s.SaleDate.ToShortDateString(),10}" +
    $"{s.Auto.Bank.Name,25}" +
    ""
    );

Console.WriteLine("Bank for customer A8@webemaxmjKd.com");
Console.WriteLine(
    $"{"FirstName",10}" +
    $"{"LastName",10}" +
    $"{"Make",10}" +
    $"{"Model",10}" +
    $"{"SaleDate",10}" +
    $"{"Bank",25}"
);
Console.WriteLine("---------------------------------------------------------------------------------");

bc.ToList().ForEach(x => Console.WriteLine(x));


//-----------------------------------Bank of Edw customers

var bac = db.Sales
    .Where(s => s.Auto.Bank.Name.Contains("Edwardsville"))
    .Select(s =>
    $"{s.Customer.FirstName,10}" +
    $"{s.Customer.LastName,10}" +
    $"{s.Auto.Make,10}" +
    $"{s.Auto.Model,10}" +
    $"{s.SaleDate.ToShortDateString(),10}" +
    $"{s.Auto.Bank.Name,25}" +
    ""
    );

Console.WriteLine();
Console.WriteLine("Customers with loans from Bank of Edwardsville");
Console.WriteLine(
    $"{"FirstName",10}" +
    $"{"LastName",10}" +
    $"{"Make",10}" +
    $"{"Model",10}" +
    $"{"SaleDate",10}" +
    $"{"Bank",25}"
);
Console.WriteLine("---------------------------------------------------------------------------------");

bac.ToList().ForEach(x => Console.WriteLine(x));


Console.WriteLine();
Console.WriteLine("Done!");

///////////////////////////////////

var bankName = db.BankAutoCustomerDTOs
    .Where(b => b.FirstName == "A" && b.LastName == "Molunguri")
    .Select(b => b.Name)
    .FirstOrDefault();

if (bankName != null)
{
    Console.WriteLine($"Bank for A Molunguri: {bankName}");
}
else
{
    Console.WriteLine("Bank for A Molunguri: Not found");
}

//////////////////////////////////////////////

var gbc = db.GetBankCustomersDTOs
    .FromSqlRaw(@"EXECUTE GetBankCustomers '322271628'").ToList()
    .Select(bc =>
    $"{bc.FirstName,-20}" +
    $"{bc.LastName,-20}"
    );

Console.WriteLine();
Console.WriteLine(
    $"{"First Name",20}" +
    $"{"Last Name",20}" +
    "");
Console.WriteLine("----------------------------------------");
gbc.ToList().ForEach(x => Console.WriteLine(x));