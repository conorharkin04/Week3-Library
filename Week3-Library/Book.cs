using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
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

        public void DisplayInfo()
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
    }
}