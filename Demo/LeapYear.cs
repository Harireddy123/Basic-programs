using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class LeapYear
    {
      public static void LeapYearCheck()
        {
            Console.WriteLine("Enter year");

            int year = int.Parse(Console.ReadLine());

            if(year%4  == 0 && year%100 != 0 || year%400 == 0 )
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }

        public static void Example1()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("not elgible for voting");
            }
        }
    }
}
