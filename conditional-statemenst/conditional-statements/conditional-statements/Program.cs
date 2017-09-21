using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla. ");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();

            int evaluetedNumber;
            int.TryParse(userInput, out evaluetedNumber);

            if(evaluetedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluetedNumber} on negatiivinen");
            }
            else if(evaluetedNumber > 0 )
            {
                Console.WriteLine($"Numero {evaluetedNumber} on positiivinen");
            }
            else
            {
                Console.WriteLine($"Numero {evaluetedNumber} on nolla");
            }

           
            Console.ReadKey();
        }
    }
}
