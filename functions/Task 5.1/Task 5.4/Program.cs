using System;

namespace Task_5._4
{
    class Program
    {
        static void Main(string[] args)
        
            {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Suurin syöttämäsi luku oli " + Numero());
            Console.ReadKey();
            }
            static int Numero()
            {
                int num = 0;
                int max = 0;
                bool isNumber;
                Console.WriteLine("Anna 10 positiivista lukua");
            //Countteri
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i + 1}= ");

                    if (isNumber = int.TryParse(Console.ReadLine(), out num) && num >= 0)
                    {
                        if (max < num)
                    {
                        max = num;
                    }
                }
                    else
                    {
                        Console.WriteLine("Väärä syöte, anna positiivinen luku");
                        i--;
                    }
                }
                return max;
            }
        }
}
