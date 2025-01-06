using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class CharacterFind
    {
        public static void PrintSymbol()
        {
            Console.WriteLine("Enter a Character");
            char ch = char.Parse(Console.ReadLine());
            if((ch>='A' && ch<='Z'))
            {
                if(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    Console.WriteLine("it is a uppercase vowel");
                }
                else
                {
                    Console.WriteLine("it is a uppercase consonant");
                }
            }
            else if(ch>='a' && ch<='z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("it is a lowercase vowel");
                }
                else
                {
                    Console.WriteLine("it is a lowercase consonant");
                }
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("it is a digit");
            }
            else
            {
                Console.WriteLine("it is a special character");
            }
            
        }
    }
}
