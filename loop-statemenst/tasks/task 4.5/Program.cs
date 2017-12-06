using System;

namespace task_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tulostaa vakioveikkauksen 13 riviä ja antaa niille tulokset 1,X,2. ");
            {
                Random rnd = new Random();
                double j;

                for (int i = 0; i < 13; i++)
                {
                    j = rnd.NextDouble();
                    if (j <= 0.40)
                    {
                        Console.WriteLine($"{i+1}. 1");
                    }
                    else if (j <= 0.60)
                    {
                        Console.WriteLine($"{i+1}. X");
                    }
                    else
                    {
                        Console.WriteLine($"{i+1}. 2");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
