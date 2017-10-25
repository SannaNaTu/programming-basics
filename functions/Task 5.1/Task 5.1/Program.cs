using System;

namespace Task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
                Console.WriteLine("Anna ohjelmalle luku. Ohjelma tulostaa näytölle luvun verran tähtiä");

                int s;
                while (true)
                {
                    Console.Write("Tähtien lukumäärä: ");
                    s = int.Parse(Console.ReadLine());
                    if (s < 0)
                    {
                        Console.WriteLine("Luku {0} ei ole sallittu luku", s);
                    }
                    else
                    {
                        break;
                    }
                }
                string asterisks = getNAsterisks(s);
                Console.WriteLine(asterisks);
                Console.ReadKey();
            }

            static string getNAsterisks(int s)
            {
                string res = string.Empty;
                for (int i = 0; i < s; i++)
                {
                    res += '*';
                }
                return res;
            }
        
    }
}
