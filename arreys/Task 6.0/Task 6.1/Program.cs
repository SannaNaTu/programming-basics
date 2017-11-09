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
            //int addnumber; //kumpi?
            int doublenumber;
            while (i < 7)
            {
                int rndIndex = rnd.Next(0, 39 + 1);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 1;
                    i++;
                }
            }
            while (true)
            {
                int rndIndex = rnd.Next(0, 39 + 1);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 2;
                    break;
                }
            }
            string lottonumbers = "";

            for (i = 0; i < lotto.Length; i++)
                if (lotto[i] == 1)
                    lottonumbers += $"{i + 1} ";
            int extranumber = 0;
            for (i = 0; i < lotto.Length; i++)
                if (lotto[i] == 2)
                {
                    extranumber = i + 1;
                    break;
                }
            for (i = 0; i < lotto.Length; i++)
            {
                {
                    doublenumber = rnd.Next(0, 39 + 1);
                }
                {
                    Console.WriteLine($"Lottonumerosi ovat:{lottonumbers} lisänumero:{extranumber} ja tuplausnumero:{doublenumber}");
                }
                // Lotto arvonta
                //Lisänumeron arvonta
                //Lottonron tulostus
                //Lisänron tulostus
                //Tuplausnro
                Console.ReadKey();
            }

        }
    }
}
