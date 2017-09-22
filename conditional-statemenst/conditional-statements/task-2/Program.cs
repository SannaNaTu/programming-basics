using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma selvittaa onko syotetty luku pariton tai parillinen. ");
            bool isNumber;
          
           

                Console.Write("Syota luku: ");
                // Define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluetedNumber;
                isNumber = int.TryParse(userInput, out evaluetedNumber);

            // program logic
            if(evaluetedNumber % 2 == 0)
            {
                Console.WriteLine($"Syotit luvun {evaluetedNumber}, se on parillinen");
            }
            else
            {
                Console.WriteLine($"Syotit luvun {evaluetedNumber}, se on pariton");
            }


            Console.ReadKey();
        }
    }
}
