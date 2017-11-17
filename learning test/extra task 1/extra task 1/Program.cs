using System;

namespace extra_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lukuja.");
            Console.WriteLine("Ohjelma päättyy antamalla kaksi samaa lukua, jonka jälkeen se laskee kaikki aiemmat luvut yhteen.");
            int UserInput = 0;
            int sum = 0;
            int last = 0;
            while (last == UserInput)
            {
                Console.Write("Syötä luku:");
                int.TryParse(Console.ReadLine(), out UserInput);
                if (UserInput != last)
                {
                    sum = sum + UserInput;
                    last = UserInput;
                }
                else
                    break;
               }
            Console.WriteLine($"Lukujen summa on: {sum}");
            Console.ReadKey();

        }
    }
}
