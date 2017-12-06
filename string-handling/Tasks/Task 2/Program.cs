using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lause. Ohjelma vaihtaa e kirjaimet € -merkkiin");
            Console.Write("Kirjoita: ");
            string userInput = Console.ReadLine();
            string userOutput = userInput.Replace("e", "€");
            Console.Write($"{userOutput}");
            Console.ReadKey();
        }
    }
}
