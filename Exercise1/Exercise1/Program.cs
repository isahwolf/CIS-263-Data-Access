//Exercise1, By Isaiah Wolf
using Exercise1;



using (var db = new Tech2Context())
{
    Console.WriteLine($"{"Name",-20} {"Phone #",15} {"Email",30}");
    Console.WriteLine($"{"----",-20} {"-------",15} {"-----",30}");
    foreach (var person in db.Customers.Take(5))
    {
        Console.WriteLine($"{person.Name, -20} {person.Phone, 15} {person.Email, 30}");
    }
}