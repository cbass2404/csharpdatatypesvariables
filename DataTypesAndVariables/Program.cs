﻿using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 69;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            Console.WriteLine("The sum of " + num1  + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.Read();
        }
    }
}
