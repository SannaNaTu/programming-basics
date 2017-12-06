using System;

namespace Task_5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle kaksi lukua. Ohjelma kertoo kumpi luvuista on pienempi ja kumpi suurempi");
            int x = 0;
            int y = 0;
            bool userInput = int.TryParse(Console.ReadLine(), out x);
            bool userInput2 = int.TryParse(Console.ReadLine(), out y);

            if (userInput == true && userInput2 == true)
            {
                Console.WriteLine($"{minimum(x, y)}");
            }
            else
            {
                Console.WriteLine("Vain numerot ovat hyväksyttäviä");
            }
            Console.ReadKey();
        }
        static string minimum(int x, int y)
        {
            string answer;

            if (x < y)
            {
                answer = $"Luku {x} on pinempi kuin {y}";
            }

            else
            {
                answer = $"Luku {y} on pienempi kuin {x}";
            }

            return answer;
        }
    }   
}
