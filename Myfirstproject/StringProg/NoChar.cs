using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class NoChar
    {
        static void Main(string[] args)
        {
            String str = "Hello I am Disha";
            int count = 0;
            Console.WriteLine(str);
            for (int i = 0; i < str.Length;i++)
            {
                if (str[i] != ' ')
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
