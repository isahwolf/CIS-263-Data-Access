using BooksApp;

//using (var db = new BooksContext())
//{
//    var author = new Author()
//    {
//        FirstName = "Isaiah",
//        MidName = "",
//        LastName = "Wolf",
//    };
//    db.Authors.Add(author);
//    db.SaveChanges();
//    Console.WriteLine($"New author added: {author.FirstName} {author.LastName}");
//}

EnsureTitle("123456789", "Book 1", 1, "2025");
EnsureAuthor("Isaiah","", "Wolf");



void EnsureTitle(string isbn, string booktitle, int editionnumber, string copyright)
{
    using (var db = new BooksContext())
    {
        //determine if item exists:
        var existingItem = db.Titles.FirstOrDefault(x => x.ISBN.ToLower()
                                                    == isbn.ToLower());

        if (existingItem == null)
        {
            //doesn't exist, add it.
            var item = new Title()
            {
                ISBN = isbn,
                BookTitle = booktitle,
                EditionNumber = editionnumber,
                Copyright = copyright
            };
            db.Titles.Add(item);
            db.SaveChanges();
            Console.WriteLine($"New Item added: {item.BookTitle}");
        }
    }
}

void EnsureAuthor(string firstname, string midname, string lastname)
{
    using (var db = new BooksContext())
    {
        //determine if item exists:
        var existingItem = db.Authors.FirstOrDefault(x => x.FirstName.ToLower()
                                                    == firstname.ToLower());

        if (existingItem == null)
        {
            //doesn't exist, add it.
            var item = new Author()
            {
                FirstName = firstname,
                MidName = midname,
                LastName = lastname
            };
            db.Authors.Add(item);
            db.SaveChanges();
            Console.WriteLine($"New Item added: {item.FirstName} {item.LastName}");
        }
    }
}
