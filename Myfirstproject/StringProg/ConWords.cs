using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class ConWords
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str = "Hello I am Disha";
            Console.WriteLine("String is: "+str);
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
            }
            if(count>0)
            {
                Console.WriteLine("Words in string are: "+(count+1));
            }
        }    
    }
}
