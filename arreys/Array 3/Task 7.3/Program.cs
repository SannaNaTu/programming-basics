using System;

namespace Task_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma määrittelee kolme taulukkoa, joissa on jokaisessa 10 lukua.");

            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(0, 10);
                //Console.Write($"{i + 1} {Printer(arrT_1[i])}");
            }
            for (int i = 0; i < 10; i++)
            {
                arrT_2[i] = rnd.Next(0, 10);
                //Console.Write($"{Printer(arrT_2[i])} ");
            }
            for (int i = 0; i < 10; i++)
            {
                if (arrT_1[i] < arrT_2[i])
                {
                    arrT_3[i] = arrT_2[i];
                }
                else
                {
                    arrT_3[i] = arrT_1[i];
                }
            }


            Console.ReadKey();
        }
        static string Printer(int[] arrX)
        {
            string res = "";


            return res;

        }
    }
}
