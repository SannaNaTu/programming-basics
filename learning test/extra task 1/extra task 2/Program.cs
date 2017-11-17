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
            int UserInput = 0;
            int number = rnd.Next(100);
            int sum = 0;
            while (number != UserInput)

            {
                Console.Write("Arvaa luku:");
                int.TryParse(Console.ReadLine(), out UserInput);
                if (UserInput < number)
                {
                    Console.WriteLine("Lukuni on isompi!");
                }
                else if (UserInput > number)
                {
                    
                    Console.WriteLine("Lukuni on pienempi!");
                }
                else 
                {
                    //sum = UserInput;
                    UserInput++;
                    Console.WriteLine($"Oikein! Arvauksia yhteensä: {UserInput} ");
                    break;
                }
            }
            Console.ReadKey();

        }

           
        }
    }

