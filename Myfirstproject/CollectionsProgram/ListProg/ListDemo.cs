using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(34);
            li.Add(3);
            li.Add(7);
            var citynames = new List<string>()
            {
                "Pune",
                "mumbai",
                "banglore",
                "nasik"
            };
            for(int i=0;i<citynames.Count;i++)
            {
                Console.WriteLine(citynames[i]);
            }
            Console.WriteLine("..........................");
            foreach(var s in citynames)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("...........................");
            citynames.ForEach(cname => Console.WriteLine(cname));
        }
    }
    class ListDemo1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(34);
            li.Add(3);
            li.Add(7);
            var citynames = new List<string>()
            {
                "Pune",
                "mumbai",
                "banglore",
                "nasik"
            };
            for (int i = 0; i < citynames.Count; i++)
            {
                Console.WriteLine(citynames[i]);
            }
            Console.WriteLine("..........................");
            foreach (var s in citynames)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("...........................");
            citynames.ForEach(cname => Console.WriteLine(cname));
            Console.WriteLine("...........................");
            Console.WriteLine(citynames.Contains("Pune"));
            citynames.Remove("nasik");
            Console.WriteLine("...........................");
            citynames.ForEach(cname => Console.WriteLine(cname));
        }
    }
}
