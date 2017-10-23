using System;

namespace task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50 ");
            for (int i = 1; i <= 50; i++)
            {
                Random rnd = new Random();
                rnd.Next(100);
                Console.WriteLine(i);
            }

                Console.ReadKey();

        }
        
    }
}
