using System;

namespace task_4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9 ");
            for (int i = 1; i < 10; i++)
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
            Console.ReadKey();
        }
    }
}
