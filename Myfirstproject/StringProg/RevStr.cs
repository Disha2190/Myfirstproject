﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class RevStr
    {
        //Reverse string except first and last word
        static void Main(string[] args)
        {
            string str = "Hello world of progamming";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            string myword = "";
            for (int i = 1; i < str1.Length-1; i++)
            {
                string wordvalue = str1[i];
                string revword = "";
                for (int j = 0; j < wordvalue.Length; j++)
                {
                    revword = wordvalue[j] + revword;
                }
                myword = myword + " " + revword;
            }
            string word = str1[0] + myword + " "+str1[str1.Length-1];
            Console.WriteLine(word);
        }
    }
}
