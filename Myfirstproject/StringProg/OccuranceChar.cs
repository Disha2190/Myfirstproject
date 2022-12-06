using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class OccuranceChar
    {
        public static void Occurance(string s)
        {
            char[] ch = s.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                int count = 1;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(ch[i] + " " + count);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine(" "+str);
            OccuranceChar.Occurance(str);
        }
    }
}
