using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
    class Splitt
    {
        static void Main(string[] args)
        {
            string str = "Hello$World";
            char[] st = str.ToCharArray();
            for(int i=0;i<st.Length;i++)
            {
                if(char.IsLetterOrDigit(st[i]))
                {
                    Console.Write(st[i]);
                }
                else
                {
                    Console.Write(" "+st[i]+" ");
                }
            }
        }
    }

    //2.	Write a Java program to find first occurrence of a character in a given string.
    class Occur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            char[] st = str.ToCharArray();
            int count = 0;
            for(int i=0;i<st.Length;i++)
            {
                count = 0;
                for(int k=i-1;k>=0;k--)
                {
                    if(st[i]==st[k])
                    {
                        count++;
                    }
                }
                if(count==0)
                {
                    Console.Write(st[i]+" ");
                }
            }
        }
    }
    //3.	Write a Java program to count occurrences of a character in given string.
    class CountOccure
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] st = str.ToCharArray();
            int count = 1;
            bool ispresent = false;
            for(int i=0;i<st.Length;i++)
            {
                count = 1;
                ispresent = false;
                for(int k=i-1;k>=0;k--)
                {
                    if (st[i] == st[k])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if(ispresent==false)
                {
                    for(int j=i+1;j<st.Length;j++)
                    {
                        if(st[i]==st[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(st[i]+": "+count);
                }
            }
        }
    }
    //4.	Write a Java program to trim leading white space characters in a string.
    class Trimmm
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(str.TrimStart());
        }
    }

    //5.	Write a Java program to count total number of words in a string. 
    class OccWord
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] st = str.Split();
            int count = 0;
            for(int i=0;i<st.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
    //6.	Write a Java program to remove all occurrences of a character from string.
    class RemoveOccChar
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] st = str.ToCharArray();
            int j=0,count = 0;
            Console.WriteLine("Enter char: ");
            char ch = char.Parse(Console.ReadLine());
            for(int i=0;i<st.Length;i++)
            {
                if(st[i]!=ch)
                {
                    st[j++] = st[i];
                }
                else
                {
                    count++;
                }
            }
            while(count>0)
            {
                st[j++] = '\0';
                count--;
            }
            Console.WriteLine(st);
        }
    }

    //7.	Write a Java program to trim trailing white space characters in a string.
    class Trimmmm
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.Write(str.TrimEnd());
        }
    }

    //8.	Write a Java program to toggle case of each character of a string.
    class ToggleStr
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            string st = "";
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsUpper(str[i]))
                {
                    st = st + char.ToLower(str[i]);
                }
                else if(char.IsLower(str[i]))
                {
                    st = st + char.ToUpper(str[i]);
                }
                else
                {
                    st = st + str[i];
                }
            }
            Console.WriteLine(st);
        }
    }

    //9.	Write a Java program to count total number of vowels and consonants in a string.
    class VowelCons
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToLower().ToCharArray();
            int vow = 0, con = 0;
            for(int i=0;i<ch.Length;i++)
            {
                if (char.IsLetter(ch[i]))
                {
                    if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                    {
                        vow++;
                    }
                    else
                    {
                        con++;
                    }
                }
            }
            Console.WriteLine("Vowel:"+vow+"\nConsonant:"+con);
        }
    }

    //10.	Write a Java program to find reverse of a string.
    class RevStr2
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] st = str.Split(" ");
            string Reverse = "";
            for(int i=st.Length-1;i>=0;i--)
            {
                Reverse = Reverse+ st[i]+" ";
            }
            Console.WriteLine(Reverse);
        }
    }
    //11.	Write a Java program to reverse order of words in a given string
    class RevWord
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            string revWord = "";
            string word = "";
            string rev = " ";
            string[] st = str.Split();
            for(int i=0;i<st.Length;i++)
            {
                word = st[i];
                 rev = " ";
                for (int j =0; j < word.Length-1; j++)
                {
                    rev = rev+ word[j];
                }
            }
            Console.WriteLine(rev);
        }
    }

    //12.	Write a Java program to find highest frequency character in a string.
    class HighestFreq
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            char[] st = str.ToCharArray();
            int cnt = 1, count = 1 ;
            char ch='0';
            bool ispresent = false;
            for(int i=0;i<st.Length;i++)
            {
                count = 1;
                ispresent = false;
                for(int k=i-1;k>=0;k--)
                {
                    if (st[i] == st[k])
                    {
                        ispresent = false;
                        break;
                    }
                }
                if(ispresent==false)
                {
                    for(int j=i+1;j<st.Length;j++)
                    {
                        if(st[i]==st[j])
                        {
                            count++;
                        }
                    }
                    if(cnt<count)
                    {
                        cnt = count;
                        ch = st[i];
                    }
                }
            }
            Console.WriteLine(ch+": "+cnt);
        }
    }
    //13.	Write a Java program to find total number of alphabets, digits or special character in a string.
    class Total
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] st = str.ToCharArray();
            int a = 0, d = 0, s = 0;
            for(int i=0;i<st.Length;i++)
            {
                if(char.IsDigit(st[i]))
                {
                    d++;
                }
                else if(char.IsLetter(st[i]))
                {
                    a++;
                }
                else
                {
                    s++;
                }
            }
            Console.WriteLine($"Alphabet: {a}\nDigits: {d}\nSpecial Digits: {s}");
        }
    }
    //14.	Write a program using Regular Expression to check valid mobile number or not .Use matches method

    class ValidMobNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mobile number: ");
            string str = Console.ReadLine();
            int count = 0;
            if(str.Length==10)
            {
                for(int i=0;i<str.Length;i++)
                {
                    if(char.IsDigit(str[i]))
                    {
                        count++;
                    }
                }
                if(count==10)
                {
                    Console.WriteLine("Valid Number");
                }
            }
            else
            {
                Console.WriteLine("Not valid mobile number");
            }
        }
    }

    //1.	Write a java program to find the duplicate words and their number of occurrences in a string
    class DupWords
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] st = str.ToLower().Split();
            int count = 1;
            bool ispresent = false;
            for(int i=0;i<st.Length;i++)
            {
                ispresent = false;
                count = 1;
                for(int k=i-1; k>=0;k--)
                {
                    if(st[i].Equals(st[k]))
                    {
                        ispresent = true;
                        break;
                    }
                }
                if(ispresent==false)
                {
                    for(int j=i+1;j<st.Length;j++)
                    {
                        if(st[i].Equals(st[j]))
                        {
                            count++;
                        }
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine(st[i] + ": " + count);
                }
            }
        }
    }

    //2.	Write a java program to check whether two strings are anagram or not?
    class Anagrammm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string str2 = Console.ReadLine();
            char[] st1 = str1.ToLower().ToCharArray();
            char[] st2 = str2.ToLower().ToCharArray();
            if(st1.Length==st2.Length)
            {
                Array.Sort(st1);
                Array.Sort(st2);
                Console.WriteLine(string.Join("", st1));
                Console.WriteLine(string.Join("", st2));
                string s1= new string(st1);
                string s2 = new string(st2);
                Console.WriteLine(s1 + " " + s2);
                if (s1.Equals(s2))
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
    }

    //4.	WAP to find longest word in the given sentence
    class LongWord
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
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
            for (int i = 0; i < st.Length; i++)
            {
                if (largestWord.Length == st[i].Length)
                {
                    Console.WriteLine(st[i]);
                }
            }
        }
    }
    //5.	How do you swap two string variables without using third or temp variable in java
    class SwapStr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();

        }
    }
    //6.	Accept email_id from user and check valid or not(should contain @,.)
    class CheckEmailAdd
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool ispre = false;
            for(int i=0;i<str.Length;i++)
            {
                if(str.Contains('@'))
                {
                    ispre = true;
                }
            }
            if(ispre)
            {
                Console.WriteLine("Valid mail id");
            }
            else
            {
                Console.WriteLine("Invalid mail id");
            }
        }
    }
    //7.	Accept sentence replace each vowel by next consecutive character
    class ReplaceVowel
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToLower().ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]=='a'|| ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    ch[i] = ch[i + 1];
                }
            }
            Console.WriteLine(string.Join("",ch));
        }
    }
    //8.	Create an array of 10 names sort in descending order
    class DescOrder
    {
        static void Main(string[] args)
        {
            string[] st = new string[10];
            for(int i=0;i<st.Length;i++)
            {
                st[i] = Console.ReadLine();
            }
            for (int i = 0; i < st.Length; i++)
            {
                for (int j = i + 1; j < st.Length; j++)
                {
                    if (st[i].CompareTo(st[j])>0)
                    {
                        string temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }
            Console.WriteLine(".................Sorted array.............");
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i]);
            }
        }
    }
    //13.	   Reverse middle words of a string [1M]
  //  Given a string str, print reverse all words except the first and last words.
  //  Examples:
	///Input  : Hi how are you students
 //   Output  : Hi woh era uoy students
 //   Input : I am fine
  //  Output : I ma fine
    
    class RevMidWor
    {
        static void Main(string[] args)
        {
            string str = "Hi how are you students";
            Console.WriteLine(str);
            string[] st = str.Split();
            string word ="";
            string rev = "";
            string myword = "";
            for(int i=1;i<st.Length-1;i++)
            {
                word = st[i];
                rev = "";
                for(int j=0;j<word.Length;j++)
                {
                    rev = word[j] + rev;
                }
                myword = myword+" " + rev;
            }
            string w = st[0]+" "+ myword +" "+ st[st.Length-1];
            Console.WriteLine(w);
        }
    }
    //14.	Given a sentence and a word, find if the word can be formed from given characters in the sentence.
    //For example, 
   // s1=”THE SKY IS THE LIMIT”
//word = "AXE", -> No
//word = "SIT", -> Yes can be formed
//word = "AMIT", -> Yes can be formed
    
    class SetInWord
    {
        static void Main(string[] args)
        {
            string str = "THE SKY IS THE LIMIT";
            char[] st = str.ToLower().ToCharArray();
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            char[] w = word.ToLower().ToCharArray();
            int count = 0, cnt = 0;
            bool ispre = false,isp=false;
            for(int i=0;i<w.Length;i++)
            {
                ispre = false;
                isp = false;
                for(int k=i-1;k>=0;k++)
                {
                    if(w[i].Equals(w[k]))
                    {
                        ispre = true;
                        break;
                    }
                }
                if (ispre==false)
                {
                    for (int j = 0; j < st.Length; j++)
                    {
                        if (w[i].Equals(st[i]))
                        {
                            isp= true;
                            break;
                        }
                    }
                }
                if(ispre==true)
                {
                    count++;
                }
            }
            if(count==w.Length)
            {
                Console.WriteLine("Yes can be formed");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
