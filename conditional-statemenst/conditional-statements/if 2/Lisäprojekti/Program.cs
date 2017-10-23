using System;

namespace Lisäprojekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("*******");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int sum = 0;
            int i = 0;
            if (number < 1)
            {
                Console.WriteLine("Annoit liian pienen arvon.");
            }
            else
            {
                do
                {
                    i--;
                    sum = sum - i;

                } while (i < 10 ); // syötetty arvo - 10
                Console.WriteLine($"vastaus: {sum}");
            }
            Console.ReadKey();
        }
    }
}
