﻿using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)

        {


            // Define instructions
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla. ");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // Define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluetedNumber;
                isNumber = int.TryParse(userInput, out evaluetedNumber);

                // program logic
                if (isNumber == true)
                {
                    if (evaluetedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluetedNumber} on negatiivinen");
                    }
                    else if (evaluetedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluetedNumber} on positiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluetedNumber} on nolla");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita!");
                }
            } while (isNumber == false);


            Console.ReadKey();
        }
    }
}
