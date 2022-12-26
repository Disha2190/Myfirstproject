using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class StringAnagram
    {
        public static bool ISAnagram(string s1,string s2)
        {
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            if(ch1.Length==ch2.Length)
            {
                Array.Sort(ch1);
                Array.Sort(ch2);
                Console.WriteLine(string.Join("",ch1));
                Console.WriteLine(string.Join("",ch2));
                string str = new string(ch1);
                string str2 = new string(ch2);
                Console.WriteLine(str+" "+str2);
                if(str.Equals(str2))
                {
                    return true;
                }    
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st String:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String:");
            string s2 = Console.ReadLine();
           
            bool flag = StringAnagram.ISAnagram(s1, s2);
            Console.WriteLine(flag);
            
            if(flag)
            {
                Console.WriteLine("Both string are anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
