using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan:");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 0;
            int f = 1;
            if (number < 0)
            {
                Console.WriteLine("Virheellinen syöte");
                //    Console.ReadLine();
                //    return;
                // nämä voisi olla alla olevan elsen tilalla
            }
            else
            { 
            //do // tämä on vaihtoehto for lausekkeelle
            //{
            //    i = i + 1;
            //    f = f * i;
            //} while (i < number);

             for (i=1;i<=number;i++)
                {
                    f = f * i;
                    Console.WriteLine($"{i} !={ f} "); // esim. 5! =120


                }
            Console.WriteLine($"Syötit: { number} \nVastaus: { f} ");
            }
            Console.ReadKey();

        }
    }
}
