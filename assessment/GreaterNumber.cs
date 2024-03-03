using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    //Accept two numbers & find the greater number.
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a NUmber");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a NUmber");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is Greater number:-");
            }
            else
            {
                Console.WriteLine("b is greater Number"); 
            }

        }
    }
}
