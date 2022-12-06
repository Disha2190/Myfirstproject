using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class Abbreviate
    {
        // name to abbrevation
        public static string Abbr(string s)
        {
            string[] str = s.Split();
            string abbrevation = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    Char[] Word = str[i].ToCharArray();
                    for (int j = 0; j < 1; j++)
                    {
                        if (j == 0)
                        {
                            abbrevation = abbrevation + Word[j] + ". ";
                        }
                    }
                }
                else
                {
                    abbrevation = abbrevation + str[i];
                }
            }
            return abbrevation;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Abbreviate.Abbr(str);
        }
    }
    
}
