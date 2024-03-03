using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    //Accept two angles of the triangle and find the third angle.
    internal class Angle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A angle_1=");
            double angle1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter A angle_2=");
            double angle2 = Convert.ToDouble(Console.ReadLine());

            double angle3 = 180 - angle1 - angle2;
            Console.WriteLine("Third Angle="+angle3);

        }
    }
}
