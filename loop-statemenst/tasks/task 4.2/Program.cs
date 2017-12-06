using System;

namespace task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50 ");
            Random r = new Random(); 
                Console.WriteLine($"Rivi 1: {r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)}");
                Console.WriteLine($"Rivi 2: {r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)}");
                Console.WriteLine($"Rivi 3: {r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)}");
                Console.WriteLine($"Rivi 4: {r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)},{r.Next(50)}");
                Console.ReadKey();
        }
    }
}

