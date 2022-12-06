using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class Stringbuilder
    {
        static void Main(string[] args)
        {
            string str = "jayu";
            string str1 = "jayu";
            Console.WriteLine("Reference for str: "+str.GetHashCode());
            Console.WriteLine("Reference for str: " +str1.GetHashCode());
            str = str + " Dhumal";
            Console.WriteLine("Reference for str: " + str.GetHashCode());
            Console.WriteLine("Reference for str: " + str1.GetHashCode());
            str = str + " Dhumal";
            str = str + " Engineer";
            str = str + " Lives in Pune";
            str = str + " Is a kind hearted person";
            Console.WriteLine("Reference for str: " + str.GetHashCode());
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World");
            Console.WriteLine("Reference for sb: " + str.GetHashCode());
            sb.Append(" C#");
            sb.Append(" Programming");
            Console.WriteLine("String is: "+sb.ToString());
            Console.WriteLine("Reference for sb: "+str.GetHashCode());
            //no new reference is created in this way stringbuilder is mutable
        }
    }
}
