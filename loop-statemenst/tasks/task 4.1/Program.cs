using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t\t{Math.Sqrt(i):f2}");
            }
            Console.ReadKey();
        }
    }
}
