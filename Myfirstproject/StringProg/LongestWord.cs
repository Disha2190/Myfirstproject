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
            string word = "";
            for (int i = 0; i < st.Length; i++)
            {
                for (int j = i + 1; j < st.Length; j++)
                {
                    if (st[i].Length < st[j].Length)
                    {
                        word = st[i];
                        largestWord = st[j];
                    }
                }
            }
            Console.WriteLine("Largest words are: ");
            for(int i=0;i<st.Length;i++)
            {
                if(largestWord.Length==st[i].Length)
                { 
                   Console.WriteLine(st[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            LongestWord.Word(str);
        }
    }
}
