using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class NotPrimeNumber : SystemException
    {
        public NotPrimeNumber()
        {
            Console.WriteLine("Number is not prime number");
        }
    }
    class PrimeNumberException
    {
        public static void Prime(int num)
        {
            int count = 0;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                throw new NotPrimeNumber();
            }
            Console.WriteLine("Prime number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            try
            {
                Prime(num);
            }
            catch
            {
                Console.WriteLine("Handled");
            }

        }
    }
    class NullException
    {
        static string s = null;
        static void Main(string[] args)
        {
            try
            {
                if (s == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Handelled......." + e.ToString());
            }
            Console.WriteLine("Hii");
        }
    }
    class Anagram2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            if (ch1.Length == ch2.Length)
            {
                Array.Sort(ch1);
                Array.Sort(ch2);
                Console.WriteLine(string.Join(" ", ch1));
                Console.WriteLine(string.Join(" ", ch2));
                string st1 = new string(ch1);
                string st2 = new string(ch2);
                Console.WriteLine(st1 + " " + st2);
                if (st1.Equals(st2))
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
    class DigitSum3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            int sum = 0;
            string temp = "0";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsDigit(ch))
                {
                    temp += ch;
                }
                else
                {
                    sum += int.Parse(temp);
                    temp = "0";
                }
            }
            sum += int.Parse(temp);
            Console.WriteLine(sum);
        }
    }
    class StrPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch[j]);
                }
                Console.WriteLine();
            }
            for (int i = ch.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch[j]);
                }
                Console.WriteLine();
            }
        }
    }
    class Excp
    {
        int count = 0;

        void A()
        {
            try
            {
                count++;

                try
                {
                    count++;

                    try
                    {
                        count++;
                        throw new Exception();

                    }

                    catch (Exception ex)
                    {
                        count++;
                        throw new Exception();
                    }
                }

                catch (Exception ex)
                {
                    count++;
                }
            }

            catch (Exception ex)
            {
                count++;
            }

        }

        void display()
        {
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Excp obj = new Excp();
            obj.A();
            obj.display();
        }
    }
    class CommonChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            char[] Common = new char[ch1.Length + ch2.Length];
            int C = 0;
            for (int i = 0; i < ch1.Length; i++)
            {
                for (int j = 0; j < ch2.Length; j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        Common[C++] = ch1[i];
                    }
                }
            }
            for(int i=0;i<Common.Length;i++)
            {
                Console.Write(Common[i]+" ");
            }
            Console.WriteLine();
            for (int p = 0; p < C; p++)
            {
                bool IsPrint = false;
                for (int k = p - 1; k >= 0; k--)
                {
                    if (Common[k] == Common[p])
                    {
                        IsPrint = true;
                    }
                }
                if (IsPrint == false)
                {
                    Console.Write(Common[p] + " ");
                }
            }
        }
    }
}
