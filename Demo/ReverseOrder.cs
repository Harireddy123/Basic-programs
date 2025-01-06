using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class ReverseOrder
    {
        public static void Example()
        {
            Console.WriteLine("Enter first character");

            char letter = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter second character");

            char letter1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter third character");

            char letter2 = char.Parse(Console.ReadLine());

            Console.Write(letter2 +" "+ letter1 +" "+ letter);
        }
    }
}
