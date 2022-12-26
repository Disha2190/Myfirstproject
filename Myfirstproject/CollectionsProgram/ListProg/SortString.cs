using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.ListProg
{
    class SortString
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Pune",
                 "Mumbai",
                 "Banglore",
                  "Goa",
                 "Nasik"
            };
            foreach(string st in li)
            {
                Console.WriteLine(st);
            }
            /*Console.WriteLine(".................Sorted list.........");
            li.Sort();
            foreach(string st in li)
            {
                Console.WriteLine(st);
            }*/
            for(int i=0;i<li.Count;i++)
            {
                for(int j=i+1;j<li.Count;j++)
                {
                    if(li[i].Length<li[j].Length)
                    {
                        string temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            Console.WriteLine("............Sorted list by length.........");
            foreach (string st in li)
            {
                Console.WriteLine(st);
            }
        }
    }
}
