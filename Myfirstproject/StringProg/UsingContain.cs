using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class UsingContain //Find Word in string
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Enter string to be found in present string: ");
            string stringToFound = Console.ReadLine();
            bool ispresent = str.Contains(stringToFound);
            if(ispresent)
                Console.WriteLine(stringToFound+" is present in str");
            else
                Console.WriteLine(stringToFound+" is not present in str");
        }
    }
}
