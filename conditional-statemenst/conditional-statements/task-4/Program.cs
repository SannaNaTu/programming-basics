using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Define instructions
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen. Anna ohjelmalle kolme lukua ");

            Console.Write("Syotä luku yksi: ");
            // Define valuables
            string userInput;
            userInput = Console.ReadLine();

            int numberX;
          int.TryParse(userInput, out numberX);

            Console.Write("Syotä luku kaksi: ");
            // Define valuables
          
            userInput = Console.ReadLine();

            int numberY;
            int.TryParse(userInput, out numberY);

            Console.Write("Syotä luku kolme: ");
            // Define valuables
          
            userInput = Console.ReadLine();

            int numberZ;
            int.TryParse(userInput, out numberZ);
            
             if (numberX < numberY) 
            {
                if (numberX < numberZ)

                        
                {
                    if (numberY < numberZ)
                    {
                        Console.WriteLine($"(numberX) (numberY) (numberZ)");

                    }
             else
                   
               
            







        }
    }
}
