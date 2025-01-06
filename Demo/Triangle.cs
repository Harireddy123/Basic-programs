using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Triangle
    {
        public static void DispTriangle()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n-i;j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
        }
    }
}
