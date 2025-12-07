//Exam2 Books, By Isaiah Wolf
using Exam2;

Console.WriteLine("Hello, World!");

var db = new BooksContext();

if (!db.Titles.Any())
{
    db.Titles.Add(new Title { ISBN = "132151006", BookTitle = "Internet & World Wide Web How to Program" });
    db.Titles.Add(new Title { ISBN = "132575655", BookTitle = "Java How to Program, Late Objects Version" });
    db.Titles.Add(new Title { ISBN = "133406954", BookTitle = "Visual Basic 2012 How to Program" });
    db.Titles.Add(new Title { ISBN = "133807800", BookTitle = "Java How to Program" });
    db.Titles.Add(new Title { ISBN = "133965260", BookTitle = "iOS 8 for Programmers: An App-Driven Approach with Swift" });
    db.Titles.Add(new Title { ISBN = "133976890", BookTitle = "C How to Program" });
    db.Titles.Add(new Title { ISBN = "134021363", BookTitle = "Swift for Programmers" });
    db.Titles.Add(new Title { ISBN = "134289366", BookTitle = "Android 6 for Programmers: An App-Driven Approach" });
    db.Titles.Add(new Title { ISBN = "134444302", BookTitle = "Android How to Program" });
    db.Titles.Add(new Title { ISBN = "134448235", BookTitle = "C# How to Program" });
    db.Titles.Add(new Title { ISBN = "134601548", BookTitle = "Visual C# How to Program" });
    db.SaveChanges();
    Console.WriteLine("Added titles...");
}

if (!db.Authors.Any())
{
    db.Authors.Add(new Author { AuthorId = 1, FirstName = "Paul", LastName = "Deitel" });
    db.Authors.Add(new Author { AuthorId = 2, FirstName = "Harvey", LastName = "Deitel" });
    db.Authors.Add(new Author { AuthorId = 3, FirstName = "Abbey", LastName = "Deitel" });
    db.Authors.Add(new Author { AuthorId = 4, FirstName = "Sue", LastName = "Black" });
    db.Authors.Add(new Author { AuthorId = 5, FirstName = "John", LastName = "Purple" });
    db.Authors.Add(new Author { AuthorId = 6, FirstName = "Gary", LastName = "Brown" });
    db.SaveChanges();
    Console.WriteLine("Added authors...");
}

if (!db.AuthorTitles.Any())
{
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "132151006", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "132575655", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133406954", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133807800", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133965260", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133976890", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134021363", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134289366", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134444302", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134448235", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134601548", AuthorId = 1 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "132151006", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "132575655", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133406954", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133807800", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133965260", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133976890", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134021363", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134289366", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134444302", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134448235", AuthorId = 2 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134448235", AuthorId = 3 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "133406954", AuthorId = 3 });
    db.AuthorTitles.Add(new AuthorTitle { ISBN = "134289366", AuthorId = 4 });
    db.SaveChanges();
    Console.WriteLine("Added author titles...");
}

//Titles
Console.WriteLine();
Console.WriteLine("Title Author Edition Year");
Console.WriteLine("Title    ".PadRight(60) + "Author   ".PadRight(15) + "Edition      ".PadRight(15) + "Year".PadRight(10));
Console.WriteLine("--------".PadRight(60) + "----------".PadRight(15) + "----------".PadRight(15) + "-------".PadRight(10));

var Titles = db.AuthorTitles.Select(t =>
    t.Title.BookTitle.PadRight(60) +
    (t.Author.FirstName + " " + t.Author.LastName).PadRight(15) +
    t.Title.Edtion.ToString().PadRight(15) +
    t.Title.Year.ToString().PadRight(10));
Titles.ToList().ForEach(t => Console.WriteLine(t));

//Authors
Console.WriteLine();
Console.WriteLine("Author Titles");
Console.WriteLine("Author    ".PadRight(15) + "Titles   ".PadRight(60));
Console.WriteLine("--------".PadRight(15) + "----------".PadRight(60));

var Author = db.AuthorTitles.Select(a =>
    (a.Author.FirstName + " " + a.Author.LastName).PadRight(15) +
    a.Title.BookTitle.ToString().PadRight(60));
Author.ToList().ForEach(a => Console.WriteLine(a));

//Author Title with Java
Console.WriteLine();
Console.WriteLine("Books with Java in the title and the Author's last name is Deitel ");
Console.WriteLine("Title    ".PadRight(60));
Console.WriteLine("--------".PadRight(60));

var JavaDeital = db.AuthorTitles
    .Where(j => j.Title.BookTitle.Contains("Java") && j.Author.LastName == "Deitel")
    .Select(j => j.Title.BookTitle.ToString().PadRight(60));
JavaDeital.ToList().ForEach(j => Console.WriteLine(j));