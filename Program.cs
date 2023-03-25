using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Somebook", "Author", 123);
            Book b2 = new Book("Another Book", "Another author", 12345);

            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

        }
    }
}