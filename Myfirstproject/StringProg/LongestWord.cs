using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class LongestWord
    {
        public static void Word(string s)
        {
            string[] st = s.Split();
            string largestWord = "";
            for (int i = 0; i < st.Length; i++)
            {
                for (int j = i + 1; j < st.Length; j++)
                {
                    if (st[i].Length < st[j].Length)
                    {
                        largestWord = st[j];
                    }
                }
            }
            Console.WriteLine("Largest word in string is: "+largestWord);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            LongestWord.Word(str);
        }
    }
}
