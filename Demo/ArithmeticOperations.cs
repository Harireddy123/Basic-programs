using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class ArithmeticOperations
    {

        public static void Calculate()
        {
            Console.WriteLine("Enter two digits");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator");
            char ch = char.Parse(Console.ReadLine());

            switch(ch)
            {
                case '+':
                    Console.WriteLine(a+b);
                    break;

                case '-':
                    Console.WriteLine(a-b);
                    break;

                case '*':
                    Console.WriteLine(a*b);
                    break;

                case '/':
                    Console.WriteLine(a/b);
                    break;

                default:
                    Console.WriteLine("Invalid Operateor");
                    break;
            }
        }
    }
}
