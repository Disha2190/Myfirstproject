using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class StrBuil
    {
        //using string builder
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            s.Append("Pune");
            Console.WriteLine(s);
            s.Append("City");
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb);
            sb.Append(" .net");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);
            sb.Clear();
            Console.WriteLine(sb.Length);
            sb.Append("Program");
            Console.WriteLine(sb);
            sb.Insert(2,'#');
            Console.WriteLine(sb);
            sb.Remove(2, 3);
            Console.WriteLine(sb);
            StringBuilder sb2 = new StringBuilder("Program");
            Console.WriteLine(sb2);
            Console.WriteLine(sb+" "+sb2);
            Console.WriteLine(sb==sb2);
            Console.WriteLine(sb.Equals(sb2));
            

           
        }   
    }
}
