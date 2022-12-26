using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myfirstproject.CollectionsProgram
{
    class CollectionTest
    {
        static void Main(string[] args)
        {
            //var mylist = new ArrayList();
            ArrayList a1 = new ArrayList();

            a1.Add("Pune");
            a1.Add(89.26);
            a1.Add(90);
            a1.Add('t');

            // Console.WriteLine(a1);
            Console.WriteLine(a1.Count);
            for(int i=0;i<a1.Count;i++)
            {
                Console.WriteLine(a1[i]);
            }
            Console.WriteLine(".......................");
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(a1[1]);
        }
    }
    class CollectonTest1
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add("Pune");
            a1.Add(89.26);
            a1.Add(90);
            a1.Add('t');
            Console.WriteLine(".........................");
            foreach (var x in a1)
            {
                Console.WriteLine(x);
            }
            a1.Insert(1, "Goa");
            Console.WriteLine(".........................");
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
