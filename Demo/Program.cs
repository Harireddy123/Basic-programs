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

            //Electricity.Calculate();

            //sum();

            //UpperToLower();

            //printNum();

            //CalculareArea();

            //Factorial();

            //PrintGrades();

            //arrayAvg();

            //ArrayReverse();

            // ArraySum();

            //MaxMin();

            //ReverseWords();

            //MoveZeros();

            Primes();

            
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

        public static void ArrayReverse()
        {
            Console.WriteLine("Enter the number of elements to be stored in array");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            for(int i = 0;i < n;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for(int i=ar.Length-1;i>=0;i--)
            {
                Console.Write(ar[i] +" ");
            }
        }

        public static void ArraySum()
        {
            Console.WriteLine("Enter the number of elements to be stored in array");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = ar.Length - 1; i >= 0; i--)
            {
                sum = sum +ar[i];
            }
            Console.WriteLine(sum);
        }

        public static void MaxMin()
        {
            Console.WriteLine("Enter the number of elements in array");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            for(int i=0;i<n;i++)
            {
                ar[i] = int.Parse(Console.ReadLine()) ;
            }
            int large = ar[0];
            for(int i=1;i<ar.Length;i++)
            {
                if (ar[i] > large)
                {
                    large = ar[i];
                }
            }
            int small = ar[0];
            for(int i=1;i<ar.Length;i++)
            {
                if (ar[i] < small)
                {
                    small = ar[i];
                }
            }
            Console.WriteLine("Smallest element in array : " + small);
            Console.WriteLine("Largest element in array : " +large);
        }

        public static void ReverseWords()
        {
            Console.WriteLine("Enter a String");
            String s = Console.ReadLine();

            String[] ar = s.Split(' ');

            for(int i=ar.Length-1;i>=0;i--)
            {
                Console.Write(ar[i] + " ");
            }
        }

        public static void MoveZeros()
        {

            Console.WriteLine("Enter the number elements in array");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            for(int k=0;k<n;k++)
            {
                ar[k] = int.Parse(Console.ReadLine()) ;
            }

            int i = 0, j = 0;

            while(i<ar.Length && j<ar.Length)
            {
                if (ar[i] != 0)
                {
                    ar[j] = ar[i];
                    i++;
                    j++;
                }
                else
                {
                    i++;
                }
            }
            while(j<ar.Length)
            {
                ar[j] = 0 ;
                j++;
            }

             for(int a=0;a<ar.Length;a++)
            {
                Console.Write(ar[a] + " ");
            }
            

        }

        public static bool IsPrime(int n)
        {
             if(n<=1)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Primes()
        {
            Console.WriteLine("Enter the number of elements in array");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            for(int i=0;i<n;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            
            foreach(int i in ar)
            {
                if(IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
