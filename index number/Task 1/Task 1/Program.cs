using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tarkistaa viitenumeron!");
            Console.Write("Anna numero:");

            string userInput = Console.ReadLine().Replace(" ", "").Replace("-", "");
            string ch = userInput.Substring(userInput.Length - 1, 1);
            string refnumber = userInput.Substring(0, userInput.Length - 1);

            int[] k = {7,3,1};
            int result = 0;
            for(int i=0; i<refnumber.Length;i++)
            {
                int j = refnumber.Length - 1 - i;
                int number = int.Parse(refnumber[j].ToString());
                result += number * k[i % 3];
            }
            int check = (result / 10 + 1) * 10 - result;

            if (check == int.Parse(userInput[userInput.Length - 1].ToString()))
            {
                Console.WriteLine("Viitenumero on kunnossa!");
            }
            else
            {
                Console.WriteLine("Viitenumero on virheellinen!");
            }
            Console.ReadKey();
        }
        
    }
}
