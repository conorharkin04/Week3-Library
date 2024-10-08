using System.Diagnostics.CodeAnalysis;
using System.Reflection;

class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int Pages;

    //Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        Pages = bookPages;
    }

    void DisplayInfo()
    {
        //output the book information to the console
        Console.WriteLine("Book Information:");
        Console.WriteLine("--------------");
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book Pages: {Pages}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        //create a new instance of the book class
        Book book = new Book("C# for beginners", "Bill Gates", "A134524306", 21);

        //another instance
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "B123456236", 121);

        //output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}