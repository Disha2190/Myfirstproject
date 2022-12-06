using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class NoWords
    {
        static void Main(string[] args)
        {
            String str = "Hello I am Disha";
            Console.WriteLine(str);
            int count = 0;
            string[] word = str.Split();
            foreach(string w in word)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
