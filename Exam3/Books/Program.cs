using Books;
using Microsoft.EntityFrameworkCore;
using System;

var db = new BookContext();

//Java titles written by author with last name "Dietel - using navigation properties"
Console.WriteLine();
Console.WriteLine("Title and author first name of Java titles written by Deitel - using navigation properties");
Console.WriteLine(
    $"{"Book Title",-60}" + 
    $"{"Author First Name",-20}" + 
    "");
Console.WriteLine(
    $"{"----------",-60}" +
    $"{"-----------------",-20}" +
    "");

db.AuthorTitles
    .Where(at => 
        at.Author.LastName == "Deitel" && 
        at.Title.BookTitle.Contains("Java"))
   .Select(at =>
        $"{at.Title.BookTitle,-60}" +
        $"{at.Author.FirstName,-20}" +
        "")
   .ToList().ForEach(l => Console.WriteLine(l));


