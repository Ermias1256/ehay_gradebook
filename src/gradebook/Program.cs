// See https://aka.ms/new-console-template for more information
using gradebook;

var book = new Book("Math book");
book.AddGrade(45.7);
book.AddGrade(45.7);
book.AddGrade(45.7);

var result = book.GetStatistics();

Console.WriteLine($"The lowest grade is: {result.Lowest}");
Console.WriteLine($"The highest grade is: {result.Highest}");



