class Book
{
    string Title;
    string Author;
    string ISBN;
    int Pages;

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
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill 'Wild One' Gates";
        book.Pages = 21;
        book.ISBN = "A1234567"; 

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.Pages = 121;
        book2.ISBN = "B1029384";

        //output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}