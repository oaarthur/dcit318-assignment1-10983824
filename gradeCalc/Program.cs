﻿using System;

namespace GradeCalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the Marks ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 90)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80 && a <= 89)
            {
                Console.WriteLine("B");
            }
            else if (a >= 70 && a <= 79)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60 && a <= 69)
            {
                Console.WriteLine("D");
            }
            else if (a < 60)
            {
                Console.WriteLine("F");
            }
        }
    }
}