using System;

namespace task_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna luku ykkösestä ylöspäin. Ohjelma laskee yhteen sitä edeltäneet parilliset ja parittomat luvut");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int evensum = 0;
            int oddsum = 0;
            int k = 1;
            if (number < 1)
            {
                k = -1;
            }

            for (int i = 1; i <= number*k; i++)
            {
                if (i % 2 == 0)
                    evensum += i;
                else
                    oddsum += i;
            }
            Console.WriteLine($"Parittomien vastaus on {oddsum*k}");
            Console.WriteLine($"Parillisten vastaus on {evensum*k}");
            Console.ReadKey();
        }
    }
}
