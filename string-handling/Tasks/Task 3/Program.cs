using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lause. Ohjelma laskee L-kirjainten määrän");
            Console.Write("Kirjoita: ");
            string userInput = Console.ReadLine().ToUpper();
            int count = 0;
            foreach (char letter in userInput)
            {
                if (letter == 'L')
                    count++;
            }

            Console.Write($"Lauseessa on {count} kpl L-kirjaimia");
            Console.ReadKey();
            // foreach
        }
    }
}
