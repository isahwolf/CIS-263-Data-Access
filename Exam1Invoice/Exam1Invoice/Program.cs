//Exam 1 - Invoice, By Isaiah Wolf
using Exam1Invoice;

Console.WriteLine("Customers who reside in Illinois:");
using (var db = new InvoiceContext())
{
    var ilCustomer = db.Customers.Where(x => x.State == "IL").ToList();
    ilCustomer.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
}