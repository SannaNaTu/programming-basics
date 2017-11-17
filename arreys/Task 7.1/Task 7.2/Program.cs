using System;

namespace Task_7._2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Ohjelma arpoo kahteen taulukkoon 10 numeroa väliltä 0-100.");
            int[,] arrTable =  new int[10, 20];

            Console.WriteLine("[ X ,  Y] = ARVO");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (arrTable[i, j] < 10)
                    {
                        arrTable[i, j] = int.Parse(getNum());
                        Console.WriteLine($"[{i:00} , {j:00}] = {arrTable[i, j]:00}");

                    }

                }
            }
            Console.ReadKey();
        }
        static string getNum()
        {
            int N = rnd.Next(0, 100 + 1);
            string num = "";

            if (N < 10)
            {
                num = N.ToString();
            }
            else
            {
                num = N.ToString();
            }
            return num;
        }

    }
}
