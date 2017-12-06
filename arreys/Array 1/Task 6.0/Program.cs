using System;

namespace Task_6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 100 numeroa välillä 0-50 ja laskee niille keskiarvon");
            int[] number = new int[100];
            double sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(0, 50 + 1);
                Console.WriteLine($"{i + 1}= {number[i]}");

            }
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine($"Lukujen yhteissumma on:{sum} ja keskiarvo on: {sum / 100}");
            Console.ReadKey();
        }


    }
        
    }

