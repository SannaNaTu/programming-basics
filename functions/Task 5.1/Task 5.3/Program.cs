using System;

namespace Task_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle luku väliltä 20-30");
            int x = 0;
            bool userInput = int.TryParse(Console.ReadLine(), out x);
            if (userInput == true)
            {
                Console.WriteLine($"{minimum(x)}");
            }
            else
            {
                Console.WriteLine("Luku ei ollut annetulta väliltä tai se ei ollut numero");
            }
            Console.ReadKey();

        }
        static string minimum(int x)
        {
            string answer;

            if (x < 30+1 && x > 20-1)
            {
                answer = $"Luku {x} on hyväksytty";
            }

            else
            {
                answer = $"Luku ei ollut annetulta väliltä tai se ei ollut numero";
            }

            return answer;
        }
    }
}
