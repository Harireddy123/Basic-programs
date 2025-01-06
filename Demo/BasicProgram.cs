using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class BasicProgram
    {

        public static void countVowelsAndConst()
        {
            int voelCount = 0;
            int constCount = 0;
            String s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'E' || ch == 'U')
                {
                    voelCount++;
                }
                else
                {
                    constCount++;
                }
            }
            Console.WriteLine(voelCount);
            Console.WriteLine(constCount);
        }
        public static void sumDigits()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n != 0)
            {
                int d = n % 10;
                sum += d;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
