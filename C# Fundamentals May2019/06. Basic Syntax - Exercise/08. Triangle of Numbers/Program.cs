﻿using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finalNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
