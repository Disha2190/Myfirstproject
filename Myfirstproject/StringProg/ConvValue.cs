using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class ConvValue
    {
        public static string ConvertValue(string s)
        {
            string newValue = "";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>='A' && s[i]<='Z')
                {
                    newValue = newValue + (char)(s[i] + 32);
                }
                else if(s[i]>='a' && s[i]<='z')
                {
                    newValue = newValue + (char)(s[i] - 32);
                }
                else
                {
                    newValue = newValue + s[i];
                }
            }
            return newValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Console.WriteLine(" " + ConvValue.ConvertValue(str));
        }
    }
    class ConvValue1
    {
        public static string ConvertValue(string s)
        {
            string newValue = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    newValue = newValue + char.ToLower(s[i]);
                }
                else if (char.IsLower(s[i]))
                {
                    newValue = newValue + char.ToUpper(s[i]);
                }
                else
                {
                    newValue = newValue + s[i];
                }
            }
            return newValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Console.WriteLine(" " + ConvValue.ConvertValue(str));
        }
    }
}
