using System;

namespace task_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle kolikon heittojen määrä. "); 
            Console.WriteLine("Tämän jälkeen ohjelma simuloi heittoja ja kertoo kuinka monta kertaa tuli klaava tai kruuna. ");
            Console.WriteLine("Anna ohjelmalle numero:");
            String UserInput;
            UserInput = Console.ReadLine();
            Random rnd = new Random();
            int userThrow = int.Parse(UserInput);
            int heads = 0;
            int tails = 0;
            for ( int i = 0; i < userThrow; i++)
            {
                int j = rnd.Next(2);
                if (j == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.Write($"Klaavoja:{tails}, Kruunia:{heads} ");
            Console.ReadKey();
        }
    }
}
