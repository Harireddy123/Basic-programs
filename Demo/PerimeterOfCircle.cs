using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class PerimeterOfCircle
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter the Radius of a circle");
            int radius = int.Parse(Console.ReadLine());
            float perimeter = 2*3.14f*radius;
            Console.WriteLine(perimeter);
        }
    }
}
