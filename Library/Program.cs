using System;

namespace Library
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Bookshelf bookshelf = new Bookshelf();
            bookshelf.Menu();
        }
    }
}
