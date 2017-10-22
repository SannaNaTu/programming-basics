using System;

namespace if_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttelyn lipunhinta");
            Console.Write("Anna nimesi:");
            string userName = Console.ReadLine();
            float discount = 0;
            float price = 16;
            bool discounted = false;
            // ikä alennus
            Console.Write("Anna Ikäsi:");
            int age = int.Parse(Console.ReadLine());
            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15 && discounted == false)
            {
                discount = 50;
                discounted = true;
            }
            else if (age >= 65 && discounted == false)
            {
                discount = 100;
                discounted = true;
            }
            if (age > 15 && age < 65)
            {
                Console.Write("Oletko varusmies? Y/N : ");
                String conscriptResponse = Console.ReadLine().ToUpper();
                if (conscriptResponse == "Y" )
                {
                    discount = 50;            
                }
                else
                {
                    Console.Write("Oletko MTK:n jäsen? Y/N :");
                    String mtkResponse = Console.ReadLine().ToUpper();
                    if (mtkResponse == "Y" )
                    {
                        discount = 15;                  
                    }
                    Console.Write("Oletko Opiskelija? Y/N :");
                    String studentResponse = Console.ReadLine().ToUpper();
                    if (studentResponse == "Y")
                    {
                        discount = discount + 45;    
                    }
                }
                Console.WriteLine($"Hei {userName} lippusi hinta on: {price-(price*discount/100)}€");
                Console.ReadLine();
            }
        }
    }










}













