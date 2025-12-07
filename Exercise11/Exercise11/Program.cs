using Exercise11;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var db = new AdventureWorksContext();

Console.WriteLine("Query #1");
Console.WriteLine("--------");
Console.WriteLine(
    $"{"SalesOrderID",-15}" +
    $"{"OrderDate",-25}" +
    $"{"FirstName",-20} " +
    $"{"LastName",-20}" +
    $"{"TotalDue",15}" +
    ""
);
Console.WriteLine(
    $"{"------------",-15}" +
    $"{"---------",-25}" +
    $"{"---------",-20} " +
    $"{"--------",-20}" +
    $"{"--------",15}" +
    ""
);

//Query #1
db.SalesOrderHeaders
    .OrderByDescending(s => s.TotalDue)
    .Take(5)
    .Select(s => new
    {
        s.SalesOrderId,
        s.OrderDate,
        s.Customer.Person.FirstName,
        s.Customer.Person.LastName,
        s.TotalDue
    })
    .ToList()
    .ForEach(sp =>
    {
        Console.WriteLine(
            $"{sp.SalesOrderId,-15}" +
            $"{sp.OrderDate,-25}" +
            $"{sp.FirstName,-20}" +
            $"{sp.LastName,-20}" +
            $"{sp.TotalDue,15:c}"
        );
    });
Console.WriteLine();
Console.WriteLine("Query #2");
Console.WriteLine("--------");
Console.WriteLine(
    $"{"SalesOrderID",-15}" +
    $"{"OrderDate",-25}" +
    $"{"FirstName",-20} " +
    $"{"LastName",-20}" +
    $"{"TotalDue",15}" +
    ""
);
Console.WriteLine(
    $"{"------------",-15}" +
    $"{"---------",-25}" +
    $"{"---------",-20} " +
    $"{"--------",-20}" +
    $"{"--------",15}" +
    ""
);

//Query #2
db.SalesOrderHeaders
    .Include(s => s.Customer)
    .ThenInclude(c => c.Person)
    .OrderByDescending(s => s.TotalDue)
    .Take(5)
    .Select(s => new
    {
        s.SalesOrderId,
        s.OrderDate,
        s.Customer.Person.FirstName,
        s.Customer.Person.LastName,
        s.TotalDue
    })
    .ToList()
    .ForEach(sp =>
    {
        Console.WriteLine(
            $"{sp.SalesOrderId,-15}" +
            $"{sp.OrderDate,-25}" +
            $"{sp.FirstName,-20}" +
            $"{sp.LastName,-20}" +
            $"{sp.TotalDue,15:c}"
        );
    });


Console.WriteLine();
Console.WriteLine("Query #3");
Console.WriteLine("--------");
Console.WriteLine(
    $"{"SalesOrderID",-15}" +
    $"{"OrderDate",-25}" +
    $"{"FirstName",-20} " +
    $"{"LastName",-20}" +
    $"{"TotalDue",15}" +
    ""
);
Console.WriteLine(
    $"{"------------",-15}" +
    $"{"---------",-25}" +
    $"{"---------",-20} " +
    $"{"--------",-20}" +
    $"{"--------",15}" +
    ""
);

//Query #3
db.SalesOrderHeaders
    .Include(s => s.Customer)
    .ThenInclude(c => c.Person)
    .OrderByDescending(s => s.TotalDue)
    .Take(5)
    .Select(s => new SalesOrdersDTO
    {
        SalesOrderId = s.SalesOrderId,
        OrderDate = s.OrderDate,
        FirstName = s.Customer.Person.FirstName,
        LastName = s.Customer.Person.LastName,
        TotalDue = s.TotalDue
    })
    .ToList()
    .ForEach(sp =>
    {
        Console.WriteLine(
            $"{sp.SalesOrderId,-15}" +
            $"{sp.OrderDate,-25}" +
            $"{sp.FirstName,-20}" +
            $"{sp.LastName,-20}" +
            $"{sp.TotalDue,15:c}"
        );
    });


