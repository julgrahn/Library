using System;
using System.Collections.Generic;

namespace Library
{
    public class Bookshelf
    {
        private readonly List<Book> bookshelf = new List<Book>(); //initiera en private lista för böckerna vi kommer använda oss av

        public void Menu()
        {
            Console.WriteLine("Welcome to the library.\n");

            bool isRunning = true; //startvärde för loop

            while (isRunning)
            {
                Console.WriteLine("1. Register a book");
                Console.WriteLine("2. Print all books");
                Console.WriteLine("3. Search for a book");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option: ");

                Int32.TryParse(Console.ReadLine(), out int input); //hantera felinmatning

                switch (input)
                {
                    case 1:
                        RegisterBook();
                        break;
                    case 2:
                        PrintBooks();
                        if (bookshelf.Count == 0)
                            Console.WriteLine("No books to be found!\n"); //om inga böcker finns att printa ut
                        break;
                    case 3:
                        SearchBooks();
                        break;
                    case 4:
                        isRunning = false; //ändra värdet för att avsluta loopen
                        break;
                    default:
                        Console.WriteLine("Invalid entry! Try again.\n");
                        break;
                }
            }
        }

        public void RegisterBook()
        {
            Console.Clear();
            Console.WriteLine("Enter an ISBN for the book: ");
            Int32.TryParse(Console.ReadLine(), out int bookID);  

            Console.WriteLine("Title: ");
            string title = Console.ReadLine();  //kom tyvärr inte på något bra sätt att hantera felaktig inmatning här. om man exempelvis skriver in siffror istället för text.

            Console.WriteLine("Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Is the book a 1. Novel, 2. Journal or 3. Poetry?");

            if (Int32.TryParse(Console.ReadLine(), out int bookType))
            {
                Console.WriteLine("\nSaved\n");
                switch (bookType)
                {
                    case 1:
                        Book.Novel b1 = new Book.Novel(title, author, bookID);
                        //var b1 = new Book.Novel(title, author, "", bookID); //ändrat på begäran
                        bookshelf.Add(b1);
                        break;
                    case 2:
                        Book.Journal b2 = new Book.Journal(title, author, bookID);
                        //var b2 = new Book.Journal(title, author, "", bookID); //ändrat på begäran
                        bookshelf.Add(b2);
                        break;
                    case 3:
                        Book.Poetry b3 = new Book.Poetry(title, author, bookID);
                        //var b3 = new Book.Poetry(title, author, "", bookID); //ändrat på begäran
                        bookshelf.Add(b3);
                        break;
                    default:
                        Console.WriteLine("Invalid entry! Try again.\n");
                        break;
                }
            }
        }

        public void PrintBooks()
        {
            Console.Clear();

            foreach (Book b in bookshelf) //går igenom alla sparade böcker i bookshelf och skriver ut dessa 
            {
                Console.WriteLine("ISBN: " + b.BookID + "\n" + b.ToString() + "\n");
            }
            
        }

        public void SearchBooks()
        {
            Console.Clear();
            Console.WriteLine("Possible ISBNs to search for: ");
            foreach(Book b in bookshelf) //skriver ut alla möjliga ISBNs som användaren kan söka efter
            {
                Console.Write(b.BookID + ", ");
            }
           
            Console.WriteLine("\nEnter an ISBN to search for: "); 
            Int32.TryParse(Console.ReadLine(), out int bookNumber);

            foreach (Book b in bookshelf)
            {
                if (bookNumber == b.BookID)
                {
                    Console.WriteLine("Found a book!\n");
                    Console.WriteLine(b.ToString() + "\n");
                }
            }
        }
    }
}
