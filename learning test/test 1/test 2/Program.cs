using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle sana tai lause!Ohjelma tulostaa yhtä monta riviä kuin kirjaimia on.");
            string userInput = Console.ReadLine();
            string input = userInput.Replace(" ", "");
            for (int i = 0; i < input.Length; i++)
            Console.WriteLine($"{i+1}. {userInput}");
            Console.ReadKey();
        }
    }
}
