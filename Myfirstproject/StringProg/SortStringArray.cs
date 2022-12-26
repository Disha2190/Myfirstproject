using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class SortStringArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string array:");
            string[] st = new string[6];
            for(int i=0;i<st.Length;i++)
            {
                st[i] = Console.ReadLine();
            }
            for (int i = 0; i < st.Length; i++)
            {
                for (int j = i + 1; j < st.Length; j++)
                {
                    if (st[i].CompareTo(st[j]) > 0)
                    {
                        string t = st[i];
                        st[i] = st[j];
                        st[j] = t;
                    }

                }
            }
            Console.WriteLine("Sorted Array");
            foreach (string name in st)
            {
                Console.WriteLine(name);
            }

        }
    }
}
