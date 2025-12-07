using Exam4;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var db = new Exam4Context();

Console.WriteLine("Unexcused absences during the month of August:");
Console.WriteLine();
Console.WriteLine(
    $"{"LastName",-15}" +
    $"{"FirstName",-15}" +
    $"{"AbsDate",-20} " +
    ""
);
Console.WriteLine(
    $"{"--------",-15}" +
    $"{"---------",-15}" +
    $"{"-------",-20} " +
    ""
);

db.Employees
    .SelectMany(e => e.Absence)
    .Select(e => new
    {
        LastName = e.Employee.LastName,
        FirstName = e.Employee.FirstName,
        AbsDate = e.AbsDate,
        Excused = e.Excused
    })
    .Where(e => e.AbsDate.Month == 8 && e.Excused == "N")
    .ToList().ForEach(e =>
    {
        Console.WriteLine(
            $"{e.LastName,-15}" +
            $"{e.FirstName,-15}" +
            $"{e.AbsDate,-30}" +
            ""
           );
    });

Console.WriteLine();
Console.WriteLine("Birthdays of the dependents of employees in the MK department:");
Console.WriteLine();
Console.WriteLine(
    $"{"LastName",-15}" +
    $"{"FirstName",-15}" +
    $"{"Birthday",-20} " +
    ""
);
Console.WriteLine(
    $"{"--------",-15}" +
    $"{"---------",-15}" +
    $"{"--------",-20} " +
    ""
);

db.Employees
    .SelectMany(e => e.Dependents)
    .Select(e => new
    {
        LastName = e.Employee.LastName,
        FirstName = e.DepName,
        DeptCode = e.Employee.DeptCode,
        Birthday = e.Birthday
    })
    .Where(e => e.DeptCode == "MK")
    .ToList().ForEach(e =>
    {
        Console.WriteLine(
            $"{e.LastName,-15}" +
            $"{e.FirstName,-15}" +
            $"{e.Birthday,-20} " +
            ""
           );
    });