using System;

namespace _4._2._2_Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Cycle While");

            int a = 0;

            while (true)

            {
                Console.WriteLine(a);

                Console.WriteLine("Write down your favourite color in English using small letters >");

                var text = Console.ReadLine();

                if (text == "stop")

                    Console.WriteLine("Cycle ended");

                    break;
            }

        }
       
    }
}

