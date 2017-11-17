using System;

namespace Task_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] numbers = new string[10];

            Console.WriteLine("[X] = Arvo");

            for (int i = 0; i < 10; i++)
            {
                 numbers[i] = getNum();
                Console.WriteLine($"[{i}] = {numbers[i]} "); // random number saatava tänne numbers[i]
            }

            Console.ReadKey();
        }
        static string getNum()
        {
            Random rnd = new Random();
            int N = rnd.Next(1, 20+1);
            string num = "";

            if (N < 10)
            {
                num = "0" + N.ToString();
            }
            else
            {
                num = N.ToString();
            }
            return num;
            Console.ReadKey();
        }
    }
}
