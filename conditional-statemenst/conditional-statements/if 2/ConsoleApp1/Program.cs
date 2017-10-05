using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

       
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan:");
            string userInput = Console.ReadLine();

            
            int number = int.Parse(userInput);
           // int.TryParse(userInput, out int number);

            int i = 0;
            int f = 1;
        
            do{

                i = i + 1;
                f = f * i;

              //  Console.WriteLine($"{number} != {f}");

                // tai console.writeline($"{i} kertoma on yhtäsuuri kuin 

            // ota tehtävässä writeline tästä välistä pois
            } while (i < number);
            
            Console.WriteLine($"Syötit: { number} \nVastaus: { f} ");

            // \n tekee rivin vaihdon writelinelle

            //tehtävässä tämän tilalle console.writeline($syötit {i} \n vastaus: {f}");

            Console.ReadKey();
        }
    }
}
// tai

    // while ( i<5)
    // { 
    // console.writeline(i);
    // i++;
    // }

    //tai
    // f* = i;  on sama kuin f = f *i;