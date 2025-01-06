using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Quadrant
    {
        public static void FindQuadrant()
        {
            Console.WriteLine("Enter the value of X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Y");
            int y = int.Parse(Console.ReadLine());
            if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in first quardant");
            }
            else if(x>0 && y<0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in second quardant");
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in third quardant");
            }
            else
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in fourth quardant");
            }
        }
    }
}
