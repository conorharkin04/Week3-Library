﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    class Book
    {
        //Properties
        private string title;
        private string author;
        private string isbn;
        private int pages;

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return title; }  // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

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