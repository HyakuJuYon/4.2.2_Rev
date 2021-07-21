using System;

namespace _4._2._2_Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Cycle While");

            int a = 0;

            while (a < 1)

            {
                Console.WriteLine(a);

                Console.WriteLine("Write down your favourite color in English using small letters >");

                switch (Console.ReadLine())

                {
                    case "red":

                        Console.BackgroundColor = ConsoleColor.Red;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is red!");

                        break;

                    case "green":

                        Console.BackgroundColor = ConsoleColor.Green;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is green!");

                        break;

                    case "cyan":

                        Console.BackgroundColor = ConsoleColor.Cyan;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is cyan!");

                        break;

                    default:

                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("You didn't pick up the color!");

                        break;
                } a++;

        }

        Console.WriteLine("Cycle Do While");

            int b = 0;

            do

            {
                Console.WriteLine(a);

                Console.WriteLine("Write down your favourite color in English using small letters >");

                switch (Console.ReadLine())

                {
                    case "red":

                        Console.BackgroundColor = ConsoleColor.Red;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is red!");

                        break;

                    case "green":

                        Console.BackgroundColor = ConsoleColor.Green;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is green!");

                        break;

                    case "cyan":

                        Console.BackgroundColor = ConsoleColor.Cyan;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is cyan!");

                        break;

                    default:

                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("You didn't pick up the color!");

                        break;
                }  b++;

            } while (b < 3);
        }
    }
}
