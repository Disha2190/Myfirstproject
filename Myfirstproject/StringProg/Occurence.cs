using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class Occurence
    {
        public static void FindOccuranceWord(string str)
        {
            string[] s = str.Split();
            for(int i=0;i<s.Length;i++)
            {
                int count = 1;
                bool flag = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(s[i]==s[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag==false)
                {
                    for(int j=i+1;j<s.Length;j++)
                    {
                        if(s[i]==s[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(s[i]+" "+count);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Occurence.FindOccuranceWord(str);
        }
    }
}
