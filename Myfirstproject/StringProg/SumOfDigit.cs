using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {
            string str = "Hello12 World5 Programming";
            Console.WriteLine("String is: " + str);
            int sum = 0;
            foreach(char ch in str)
            {
                if(ch>=48&&ch<=57)
                sum += int.Parse(ch.ToString());
            }
            Console.WriteLine("Digits sum present in string is: "+sum);
        }
      
    }
}
