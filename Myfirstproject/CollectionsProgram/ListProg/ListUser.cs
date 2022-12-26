using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class ListUser
    {
        static void Main(string[] args)
        {
            List<String> li = new List<string>();
            for(int i=1;i<=4;i++)
            {
                Console.WriteLine("Enter the value:");
                string s = Console.ReadLine();
                li.Add(s);
            }
            li.ForEach(c => Console.WriteLine(c));
        }
    }
}
