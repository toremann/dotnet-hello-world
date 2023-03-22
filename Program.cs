using System;
using System.Text;
using System.Globalization;

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
            int theNumber = new Random().Next(20);
            bool guessCorrect = false;
            Console.WriteLine("Guess the number!");

            do
            {
                string guessString = Console.ReadLine();
                int guess;
                if (int.TryParse(guessString, out guess))
                {
                    if (guess == theNumber)
                    {
                        Console.WriteLine("You guessed correctly!");
                        guessCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number, try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            } while (!guessCorrect);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
