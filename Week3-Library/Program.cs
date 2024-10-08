using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Week3_Library;

class Program { 
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