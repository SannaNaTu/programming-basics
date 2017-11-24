using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lause. Ohjelma kertoo merkkien lukumäärän");
            Console.Write("Kirjoita: ");
            string userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            { }
                Console.Write($"Syötteessä on {userInput.Length} merkkiä");
            Console.ReadKey();
        }
    }
}
