using System;

namespace extra_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!");
            Random rnd = new Random();
            int j = rnd.Next(0,100+1);
            int guess = 0;
            int i;
            do
            {
                Console.Write("Arvaa luku:");
                string userInput = Console.ReadLine();
                i = int.Parse(userInput);
                guess++;
                if (j == i)
                {
                    Console.WriteLine($"Oikein! Arvauksia yhteensä: {guess} ");
                }
                else if (j < i)
                {
                    Console.WriteLine("Lukuni on pienempi!");
                }
                else if (j > i)
                {

                    Console.WriteLine("Lukuni on suurempi!");
                }
                if (i > 100 || i < 1)
                {
                    Console.WriteLine("Numerosi ei myöskään ole sallitulla alueella!");
                }
            }
            while (j != i);

                Console.ReadKey();
            }
        }
    }


           
        

           
        
    


