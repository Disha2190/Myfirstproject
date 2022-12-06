using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class Vowel1
    {
        public static void Vowel(string s)
        {
            char[] ch = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                char.ToLower(ch[i]);
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("Vowels are: " + count);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Vowel1.Vowel(str);
        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str = "Hello World";
            Console.WriteLine("String is: " + str);
            for (int i = 0; i < str.Length; i++)
            {
               char.ToLower(str[i]); 
            }
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
                {
                    count++;
                }
            }
            Console.WriteLine("Vowels are: "+count);
        }
    }
}
