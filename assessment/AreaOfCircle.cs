using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius *radius;  //Formula = Math.PI *Radius*Radius
            Console.WriteLine(area);                 //radius = 5 ,
                                                               //area= 3.14* 5*5 = 78.53
                                                               //area =78.53 
        } 
    }
}
