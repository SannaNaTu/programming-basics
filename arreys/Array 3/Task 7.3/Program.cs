using System;

namespace Task_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma antaa kolme taulukkoa, joissa jokaisessa on 10 satunnaista lukua.");
            Console.WriteLine();
            Random rnd = new Random();
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(51);
                arrT_2[i] = rnd.Next(51);

                if (arrT_1[i] > arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }
                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }
            Console.Write("        ");
            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                {
                    Console.Write($"0{i} ");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }

            Console.Write("        ");
            for (int i = 0; i < 29; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"arrT_1: {Numbers(arrT_1[i])} ");
                }
                else
                {
                    Console.Write($"{Numbers(arrT_1[i])} ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"arrT_2: {Numbers(arrT_2[i])} ");
                }
                else
                {
                    Console.Write($"{Numbers(arrT_2[i])} ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"arrT_3: {Numbers(arrT_3[i])} ");
                }
                else
                {
                    Console.Write($"{Numbers(arrT_3[i])} ");
                }
            }

            Console.ReadKey();
        }
        static string Numbers(int x)
        {
            if (x < 10)
            {
                return "0" + x.ToString();
            }
            else
            {
                return x.ToString();
            }
        }
    }
}

