﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    // Write a program to input age of a person and print if he/she is teenager or not.
    internal class Teenager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 13 && age <= 18)
            {
                Console.WriteLine("teenager");
            }
            else
            {
                Console.WriteLine("Not teenager");
            }
        }
    }
}
