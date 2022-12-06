using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class CheckDigit
    {
        // valid string or not
        public static void Valid(string str)
        {
            if (str.Length >= 3)
            {
                char[] ch = str.ToCharArray();
                bool IsDigit = true;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (char.IsLetter(ch[i]))
                    {
                        Console.WriteLine("Error");
                        IsDigit = false;
                        break;
                    }
                }
                if (IsDigit)
                {
                    int StartSum = 0, LastSum = 0;
                    for (int S = 0, L = ch.Length - 1; S < 3; S++, L--)
                    {
                        StartSum += ch[S];
                        LastSum += ch[L];
                    }
                    if (StartSum == LastSum)
                    {
                        Console.WriteLine("Valid String");
                    }
                    else
                    {
                        Console.WriteLine("Not Valid String");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            CheckDigit.Valid(str);
        }
    }
}
