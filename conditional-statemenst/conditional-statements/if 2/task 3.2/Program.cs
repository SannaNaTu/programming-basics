using System;

namespace task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna luku ykkösestä ylöspäin. Ohjelma laskee yhteen antamasi numeron + yhdeksän seuraavaa lukua");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number < 1)
            {
                //if (number > 1)
                Console.WriteLine("Annoit liian pienen arvon.");
            }
            else 
           {
                Console.WriteLine($"Syötit: { number} \nVastaus: {number + number + 1 + number + 2 + number + 3 + number + 4 + number + 5 + number + 6 + number + 7 + number + 8 + number + 9 } ");
            }
                Console.ReadKey();
        }
    }
}
