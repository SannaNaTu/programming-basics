using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle kaksi lukua. Ohjelma kertoo kumpi luvuista on pienempi ja kumpi suurempi");
            int x = 0;
            int y = 0;
            Console.Write("Anna luku yksi: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Anna luku kaksi: ");
            y = int.Parse(Console.ReadLine());
            if (x < y)
            {
                Console.WriteLine($"Luku {y} on isompi kuin luku {x}");
            }
            else
            {
                Console.WriteLine($"Luku {x} on isompi kuin luku {y}");
            }

            Console.ReadKey();
        }

    }
}
