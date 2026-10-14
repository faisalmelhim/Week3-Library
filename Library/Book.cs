using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
       class Book
    {
        private string title; // field
        private string author; // field
        private string isbn; // field

        public string Title
        {
            get {  return title; } // get method
            set { title = value; } // set method
        }

        public string Author
        {
            get { return author; } // get method
            set
            {
                // checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain nymbers");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; } // get method
            set
            {
                // checks that the incoming string is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank");
                }
            }
        }


        // Example of a constructor that allows us to 'construct' a new
        // Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

       public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }

}
