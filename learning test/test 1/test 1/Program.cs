﻿using System;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle sana tai lause!");
            string userInput;
            userInput = Console.ReadLine();
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{i} {userInput}");
                Console.ReadKey();
        }
    }
}
