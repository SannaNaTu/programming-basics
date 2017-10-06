using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan:");
            string userInput = Console.ReadLine();


            int number = int.Parse(userInput);
            int i = 0;
            int f = 1;

            do
            {

                i = i + 1;
                f = f * i;
            } while (i < number);

            Console.WriteLine($"Syötit: { number} \nVastaus: { f} ");
                
            Console.ReadKey();

        }
    }
}
