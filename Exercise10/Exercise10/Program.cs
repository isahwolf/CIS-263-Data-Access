
using Exercise10;



var db = new AdventureWorksContext();

string term = "chicago";

//Filter and sort server side
//Duration: 17ms
db.Addresses
    .Where(x =>
        x.City.ToLower().Contains(term))
    .OrderBy(x => x.AddressLine1)
    .ToList().ForEach(a =>
    Console.WriteLine(
        $"{a.AddressLine1,-30}" +
        $"{a.City,-15}" +
        ""));

//Filter and sort client side
//Duration: 207ms
db.Addresses
    .ToList()
    .Where(x =>
        x.City.ToLower().Contains(term))
    .OrderBy(x => x.AddressLine1)
    .ToList().ForEach(a =>
    Console.WriteLine(
        $"{a.AddressLine1,-30}" +
        $"{a.City,-15}" +
        ""));