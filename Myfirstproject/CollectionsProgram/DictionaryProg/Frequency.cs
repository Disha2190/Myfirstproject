using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.DictionaryProg
{
    class Frequency
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
             {
                 "Pune",
                 "Mumbai",
                 "Banglore",
                 "Pune",
                 "Goa",
                 "Nasik",
                 "Pune",
                 "Nasik",
                 "Banglore",
                 "Banglore"
            };
            Dictionary<string, int> dm = new Dictionary<string, int>();
             for(int i=0;i<li.Count;i++)
             {
                int count = 1;
                for(int j=i+1;j<li.Count;j++)
                {
                    if (li[i] == li[j])
                    {
                        count++;
                        li.RemoveAt(j);
                        j--;
                    }
                }
                dm.Add(li[i], count);
             }
            Console.WriteLine(".....................................");
            foreach(KeyValuePair<string,int>kv in dm)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
        }
    }
}
