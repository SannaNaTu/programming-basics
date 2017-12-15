using System;

namespace id
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelmaa kertoo onko henkilötunnus oikea!");
            Console.WriteLine("Anna ohjelmalle henkilötunnus:");
            {
                string userInput = Console.ReadLine().Replace(" ", "").ToUpper();

                userInput = Remove(userInput.lenght - 1, 1).userInput.Replace("+", "").userInput.Replace("-", "").userInput.Replace("A", "");

                //int num = int.Parse(userInput);
                string idcheck = "0123456789ABCDEFHJKLMNPRSTUVWXY";
                int 

                if
                {
                    Console.WriteLine("Henkilötunnus on OK");
                }
                else
                {
                    Console.WriteLine("Henkilötunnus on väärin"); 
                }





                //string idcheck = "0123456789ABCDEFHJKLMNPRSTUVWXY";







                //    if ((userInput.Length == 11) || (userInput.Substring(6, 7) != "-") && (userInput.Substring(6, 7) != "+") && (userInput.Substring(6, 7) != "A"))
                //    {
                //        Console.WriteLine("");
                //        Console.ReadLine();
                //    }
                //    else
                //    {
                //        Console.WriteLine("");
                //    }
                //    return realid.ToUpper();

                Console.ReadKey();
                //}

            }
        }
    }
}
