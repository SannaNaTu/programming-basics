using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
       
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Define instructions
            Console.WriteLine("Ohjelma kertoo onko numero positiivinen, negatiivinen vai nolla sekä onko luku pariton vai parillinen. ");
            bool isNumber;
            do
            {

                Console.Write("Syotä luku: ");
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
                        Console.Write($"Numero {evaluetedNumber} on negatiivinen");
                    }
                    else if (evaluetedNumber > 0)
                    {
                        Console.Write($"Numero {evaluetedNumber} on positiivinen");
                    }
                    else
                    {
                        Console.Write($"Numero {evaluetedNumber} on nolla");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita!");
                }

                if (evaluetedNumber % 2 == 0)
                {
                    Console.WriteLine(" ja se on parillinen");
                }
                else
                {
                    Console.WriteLine(" ja se on pariton");
                }
            } while (isNumber == false);


            Console.ReadKey();
        }
    }
}
