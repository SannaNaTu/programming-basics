using System;

namespace task_3._3
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
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    evensum += i;
                else
                    oddsum += i;
            }
            Console.WriteLine($"Parittomien vastaus on {oddsum}");
            Console.WriteLine($"Parillisten vastaus on {evensum}");
            Console.ReadKey();
                }

            }
        }
    

        


