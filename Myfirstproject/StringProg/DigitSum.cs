using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class DigitSum
    {
        public static int FindDigit_Sum(string s)
        {
            int sum = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>='0'&&s[i]<='9')
                {
                    sum = (int)(sum + char.GetNumericValue(s[i]));
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Entr the string: ");
            string str = Console.ReadLine();
            Console.WriteLine(" "+str);
            Console.WriteLine("Sum od Digits  "+DigitSum.FindDigit_Sum(str));
        }
    }
    class DigitSum1
    {
        public static int FindDigit_Sum(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(char.IsDigit(s[i]))
                {
                    sum = (int)(sum + char.GetNumericValue(s[i]));
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Console.WriteLine("Sum of Digits  " + DigitSum1.FindDigit_Sum(str));
        }
    }
}
