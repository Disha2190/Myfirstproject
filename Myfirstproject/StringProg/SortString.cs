using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class SortString
    {
        public static void LengthSort(string s)
        {
            string[] st = s.Split();
            Console.WriteLine(string.Join(" ",st));
            for(int i=0;i<st.Length;i++)
            {
                for(int j=i+1;j<st.Length;j++)
                {
                    if(st[i].Length > st[j].Length)
                    {
                        string temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",st));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            SortString.LengthSort(str);
        }
    }
}
