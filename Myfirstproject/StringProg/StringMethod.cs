using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class StringMethod
    {
        static void Main(string[] args)
        {
            String str = "Hello";
            String str2 = "Hello";
            String s = new string("Pune");
            Console.WriteLine(str+" "+str2);
            Console.WriteLine(str==str2);
            Console.WriteLine(str.Equals(str2));
            Console.WriteLine(str.GetHashCode());
            str = str + " .Net";
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str+"     "+str2);
            Console.WriteLine(str==str2);
            Console.WriteLine(str.Equals(str2));
        }
    }
    class Compare
    {
        static void Main(string[] args)
        {
            String str = "Hello";
            String str2 = "hello";
            int x = str.CompareTo(str2);//1
            Console.WriteLine(x);
            int y = str2.CompareTo(str);//-1
            Console.WriteLine(y);
        }
    }
    class StrMaethods
    {
        static void Main(string[] args)
        {
            String str = "I Like India Country";
            
            String s = str.ToUpper();
            Console.WriteLine(s);

            String s1 = str.ToLower();
            Console.WriteLine(s1);

            Console.WriteLine(".................");
            char[] ch = str.ToCharArray();
            foreach(char c in ch)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
            Console.WriteLine(str.Substring(4));
            Console.WriteLine("..............................");
            Console.WriteLine(str.Substring(4,6));
            Console.WriteLine("..............................");
            string[] myword = str.Split(",");
            foreach(string w in myword)
            {
                Console.Write(w);
            }
            Console.WriteLine(str.IndexOf('b'));

            Console.WriteLine(str[4]);

            Console.WriteLine(str.Replace("like","love"));
            Console.WriteLine(str.Contains("Like"));
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());
        }
    }
    class StrRev
    {
        public String DoReverse(string s)
        {
            string s2 = "";
            for(int i=0;i<s.Length;i++)
            {
                s2 = s[i] + s2;
            }
            return s2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            String str = Console.ReadLine();

            StrRev r = new StrRev();
            Console.WriteLine(r.DoReverse(str));
        }
    }
    class StrRev1
    {
        public String DoReverse(string s)
        {
            char[] ch = s.ToCharArray();
            string s2 = "";
            for (int i = 0; i < ch.Length; i++)
            {
                s2 = ch[i] + s2;
            }
            return s2;
        }
        public void ToStringConvert(char[]ch)
        {
            String s = new string(ch);
            Console.WriteLine(s);
        }
        public String ReverseWord(string s)
        {
            string[] str = s.Split();
            string myword = "";
            for(int i=0;i<str.Length;i++)
            {
                string wordvalue = str[i];
                string revword = "";
                for(int j=0;j<wordvalue.Length;j++)
                {
                    revword = wordvalue[j] + revword;
                }
                myword = myword + " " + revword;
            }
            return myword;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            String str = Console.ReadLine();

            StrRev1 r = new StrRev1();
            Console.WriteLine(r.DoReverse(str));
            Console.WriteLine(r.ReverseWord(str));

            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join(" ",ch));
            r.ToStringConvert(ch);
        }
    }
}
