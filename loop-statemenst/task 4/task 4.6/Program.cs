using System;

namespace task_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma heittää 1000 kertaa noppaa puolestasi ja kertoo kuinka moni niistä oli kuutonen.");
            Random rnd = new Random();
            int sixCounter = 0;

            for (int number = 0; number < 1000; number++)
            {
                int rndNumber = rnd.Next(1, 7);
                Console.WriteLine($"{number + 1}. {rndNumber}");
                if (rndNumber == 6)
                    sixCounter++;
            }
            Console.WriteLine($"Kutosia esiintyi: {sixCounter}kpl");
            Console.ReadKey();
        }
    }
}
