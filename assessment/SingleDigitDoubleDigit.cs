using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    // Write a program to input a number and compare whether that number is single digit or
    //double digit.

    internal class SingleDigitDoubleDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num < 9)
            {
                Console.WriteLine("Single digit");
            }
            else if(num < 99)
            {
                Console.WriteLine("Double Digit");
            }
            else
            {
                Console.WriteLine("The number is not single digit or double digit");
            }

        }
    }
}
