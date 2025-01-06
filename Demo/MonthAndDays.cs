using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class MonthAndDays
    {
        public static void count()
        {
            Console.WriteLine("Enter Month");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month has 31 days");  
                    break;
                case 2:
                    Console.WriteLine("Month has 28 days");   
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month has 30 days"); 
                    break;
                default:
                    Console.WriteLine("Invalid Month number");  
                    break;
            }

        }
    }
}
