using System;

namespace Task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Lottokone:");
            Random rnd = new Random();
            int i = 0;
            int[] lotto = new int[40];
            int doublenumber;
            // Arvotaan lottonumero
            while (i < 7)
            {
                int rndIndex = rnd.Next(0, 39 + 1);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 1;
                    i++;
                }
            }
            //Arvotaan lisänumero
            while (true)
            {
                int rndIndex = rnd.Next(0, 39 + 1);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 2;
                    break;
                }
            }
            //Tulostus lottonumeroille
            string lottonumbers = "";

            for (i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 1)
                    lottonumbers += $"{i + 1} ";
            }
            // Tulostus lisänumerolle
            int extranumber = 0;
            for (i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 2)
                {
                    extranumber = i + 1;
                    break;
                }
            }
            //Tulostus tuplausnumerolle
            doublenumber = rnd.Next(0, 39 + 1);
            //Tekstin tulostus
            Console.WriteLine($"Lottonumerosi ovat:{lottonumbers} lisänumero:{extranumber} ja tuplausnumero:{doublenumber}");
            Console.ReadKey();

        }
    }
}
