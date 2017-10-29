using System;

namespace Task_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"OK {NumberFromRange(-2, 10)}");

            Console.ReadKey();
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            string userInput = string.Empty;
            bool isNumber = false;
            int x = 0;
            int retNumber = 0;
            bool isValidNumber = false;

            do
            {
                Console.WriteLine($"Anna ohjelmalle luku {lowerBound} ja {upperBound} väliltä");
                userInput = Console.ReadLine();
                isNumber = int.TryParse(userInput, out x);
                if (isNumber)
                    if (x >= lowerBound && x <= upperBound)
                    {
                        retNumber = x;
                        isValidNumber = true;
                    }
                    else
                    {
                        Console.WriteLine($"Luku {x} ei ollut annetulta väliltä");
                    }
                else
                    Console.WriteLine($"{userInput.ToUpper()} ei ole luku! ");

            } while ((!isNumber || !isValidNumber));


            return retNumber;
        }
    }
}
