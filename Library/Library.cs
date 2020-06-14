using System.Collections.Generic;

namespace Library
{
    public class Book
    {
        public string Title { get; set; } //egenskaper
        public string Author { get; set; }
        public string Type { get; set; }
        public int BookID { get; set; }

        public Book(string title, string author, int bookID) //konstruktor med tre argument (använder ingen annan, behöver inte overload)
        {
            Title = title;
            Author = author;
            BookID = bookID;
        }

        public class Novel : Book
        {
            public Novel(string title, string author, int bookID) : base(title, author, bookID)
            {
                Type = "novel";
            }
            public override string ToString()
            {
                return "The name of the book is " + Title + " written by " + Author + " and is of the type " + Type + ".\nThese can be found in bookshelf nr. 50.";
            }
        }

        public class Journal : Book //underklass till klassen Book
        {
            public Journal(string title, string author, int bookID) : base(title, author, bookID)  //ärver klassen Books objekt
            {
                Type = "journal";
            }
            public override string ToString() //ToString-metod som bara har syftet att returnera en sträng
            {
                return "The name of the book is " + Title + " written by " + Author + " and is of the type " + Type + ".\nThese can be found in the newspaper's stand.";
            }
        }


        public class Poetry : Book
        {
            public Poetry(string title, string author, int bookID) : base(title, author, bookID)
            {
                Type = "poetry";
            }

            public override string ToString()
            {
                return "The name of the book is " + Title + " written by " + Author + " and is of the type " + Type + ".\nThese can be found in the poetry section.";
            }
        }
    }  
}
