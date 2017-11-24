using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lause. Ohjelma tarkistaa onko lause palindromi vai ei");
            Console.Write("Kirjoita: ");
            string inputString = Console.ReadLine();
            string reversedString = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }
            if
                (inputString.Replace(" ", "") == reversedString.Replace(" ", ""))
                Console.WriteLine("Tämä oli palindromi");
            else
            {
                Console.WriteLine("Tämä ei ole palindromi");
            }
            Console.ReadKey();

        }

        }
    }

