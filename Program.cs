using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        /// XML comment
        /// <summary> 
        /// This is the main function
        /// </summary>
        static void Main(string[] args)
        {
            // int i = 10;
            // float f = 2.0f;
            // decimal d = 10.0m;
            // char c = 'c';

            int[] vals = new int[5];
            string[] strs = { "one", "two", "three" };

            int value = 15;

            string a = "Hello", b = "World";

            Console.WriteLine("Hello, World!");

            StringBuilder sb = new StringBuilder("Initial string.", 200);

            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");



            for (int i = 0; i < value; i++) {
                Console.WriteLine("Beep boop {0}", i);
            }

            int password = 123;

            if (password == 1233)
            {
                Console.WriteLine("Password Correct, yay!");
            }
            else
            {
                Console.WriteLine("Password Inncorrect, buuu");
            }

            switch (password)
            {
                case 123:
                    Console.WriteLine("This is correct");
                    break;
                case 1234:
                    Console.WriteLine("This is wrong");
                    break;
                default:
                    Console.WriteLine("Meow");
                    break;
            }
        }
    }
}
