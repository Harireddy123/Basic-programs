using System;
using System.ComponentModel.Design;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BasicProgram.countVowelsAndConst();
            //BasicProgram.sumDigits();
            //Console.WriteLine();

            //Triangle.DispTriangle();

            //PerimeterOfCircle.Calculate();

            //CharacterFind.PrintSymbol();

            //ReverseOrder.Example();

            //ArithmeticOperations.Calculate();

            //LeapYear.LeapYearCheck();

            //LeapYear.Example1();

            //Quadrant.FindQuadrant();

            // MonthAndDays.count();

            Electricity.Calculate();

            //sum();

            //UpperToLower();

            //printNum();

            //CalculareArea();

            //Factorial();

            //PrintGrades();

            //arrayAvg();
            
        }
        public static void sum()
        {
            Console.WriteLine("Enter 2 Numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            float c = a * a + b * b;

            float avg = c / 2;
            Console.WriteLine(avg);
        }

        public static void UpperToLower()
        {
            Console.WriteLine("Enter a place");
            String s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
        }

        public static void printNum()
        {
            Console.WriteLine("Enter a string value");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(s);

            }

        }

        public static void CalculareArea()
        {
            Console.WriteLine("Enter the diameter of a circle");
            float diameter = float.Parse(Console.ReadLine());
            float radius = diameter / 2;
            float area = 3.14f * radius * radius;
            float perimeter = 2 * 3.14f * radius;

            Console.WriteLine("area of circle : " + area);
            Console.WriteLine("perimeter of circle : " + perimeter);
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter a number to calculate factorial");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }

        public static void PrintGrades()
        {
            Console.WriteLine("Enter Student Marks");
            int marks = int.Parse(Console.ReadLine());
            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine('A');
            }
            else if (marks >= 80 && marks <= 99)
            {
                Console.WriteLine('B');
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine('C');
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine('F');
            }
        }

        public static void arrayAvg()
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            float[] ar = new float[n];
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                ar[i] = float.Parse(Console.ReadLine());
            }
            foreach (float f in ar)
            {
                sum = sum + f;
            }
            float avg = sum / n;
            Console.WriteLine(avg);
        }

    }
}
