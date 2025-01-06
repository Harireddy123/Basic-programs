using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Electricity
    {

        public static void Calculate()
        {
            Console.WriteLine("Enter person id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter number of units");
            int units = int.Parse(Console.ReadLine());

            if(units <= 199)
            {
                Console.WriteLine("Customer IDNO :" + id);
                Console.WriteLine("Customer NAME :" + name);
                Console.WriteLine("UNITS CONSUMED :" +units);
                float charge = 1.20f * units;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit :" + charge);
                Console.WriteLine("Surcharge Amount :" + 0);
                Console.WriteLine("Net Amount Paid By the Customer :" +charge);
            }
            else if(units>=200 && units<400)
            {
                Console.WriteLine("Customer IDNO :" + id);
                Console.WriteLine("Customer NAME :" + name);
                Console.WriteLine("UNITS CONSUMED :" + units);
                float charge = 1.50f * units;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit :" + charge);
                Console.WriteLine("Surcharge Amount :" + 0);
                Console.WriteLine("Net Amount Paid By the Customer :" + charge);
            }
            else if( units>=400 && units<600)
            {
                Console.WriteLine("Customer IDNO :" + id);
                Console.WriteLine("Customer NAME :" + name);
                Console.WriteLine("UNITS CONSUMED :" + units);
                float charge = 1.80f * units;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit :" + charge);
                float surcharge = 15*charge/100;
                Console.WriteLine("Surcharge Amount :" + surcharge);
                charge = charge + surcharge;
                Console.WriteLine("Net Amount Paid By the Customer :" + charge);
            }
            else
            {
                Console.WriteLine("Customer IDNO :" + id);
                Console.WriteLine("Customer NAME :" + name);
                Console.WriteLine("UNITS CONSUMED :" + units);
                float charge = 2.00f * units;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit :" + charge);
                float surcharge = 15*charge/100;
                Console.WriteLine("Surcharge Amount :" + surcharge);
                charge = charge + surcharge;

                Console.WriteLine("Net Amount Paid By the Customer :" + charge);
            }
        }
    }
}
