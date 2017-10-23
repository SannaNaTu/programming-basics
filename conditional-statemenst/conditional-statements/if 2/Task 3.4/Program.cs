using System;

namespace Task_3._4
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
            int k = 1;
            if (number < 1)
            {
                k = -1;
            }
           
                do
                {
                    i++;
                    sum = sum + i;
                } while (i < number*k);
                Console.WriteLine($"vastaus: {sum*k}");
            
            Console.ReadKey();
        }
    }
}
