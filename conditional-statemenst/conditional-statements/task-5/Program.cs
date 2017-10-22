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
            //numero 1 = X
            Console.Write("Syotä luku yksi: ");
            string userInput;
            userInput = Console.ReadLine();
            int numberX;
            int.TryParse(userInput, out numberX);
            //numero 2 = Y
            Console.Write("Syotä luku kaksi: ");
            userInput = Console.ReadLine();
            int numberY;
            int.TryParse(userInput, out numberY);
            //numero 3 = Z
            Console.Write("Syotä luku kolme: ");
            userInput = Console.ReadLine();
            int numberZ;
            int.TryParse(userInput, out numberZ);
            //alla turha rivi
            //Console.WriteLine(numberX + " " +numberY +" "+ numberZ );
            {
                if (numberX < numberY)
                    if (numberX < numberZ)
                    {
                        if (numberY < numberZ)
                        {
                            Console.WriteLine(numberX + " " + numberY + " " + numberZ);
                        }
                        else
                            Console.WriteLine(numberX + " " + numberZ + " " + numberY);
                    }
                    else
                        Console.WriteLine(numberZ + " " + numberX + " " + numberY);
                else
                {
                    if (numberX < numberZ)
                    {
                        Console.WriteLine(numberY + " " + numberX + " " + numberZ);
                    }
                    else
                    if (numberZ < numberY)
                    {
                        Console.WriteLine(numberZ + " " + numberY + " " + numberX);
                    }
                    else
                        Console.WriteLine(numberY + " " + numberZ + " " + numberX);
                }
            }














            {

                Console.WriteLine("Hyvää Päivänjatkoa!");

            }









            Console.ReadKey();



        }
    }
}



