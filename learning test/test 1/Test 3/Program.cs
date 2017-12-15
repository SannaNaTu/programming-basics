using System;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lukuja. Ohjelma laskee lopulta kaikki antamasi numerot yhteen kun annat -1.");
            int summa = 0;
            int userInput = 0;
            bool isNumber = true;
            while (isNumber)
            {
                Console.Write("Anna luku: ");
                isNumber = int.TryParse(Console.ReadLine(), out userInput);

                if (userInput == -1)
                {
                    break;
                }
                else
                {
                    summa += userInput;
                }
            }
            Console.WriteLine($"Annoit -1 , joten lukujen summa on: {summa}");
            Console.ReadKey();
        }
    }
}
