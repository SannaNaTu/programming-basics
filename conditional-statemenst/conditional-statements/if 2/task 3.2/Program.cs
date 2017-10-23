using System;

namespace task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna luku ykkösestä ylöspäin. Ohjelma laskee yhteen antamasi arvon sekä sitä edeltäneet arvot. ");
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
                    i++;
                    sum = sum + i;
                } while (i < number);
                Console.WriteLine($"vastaus: {sum}");
            }
                Console.ReadKey();
        }
    }
}
