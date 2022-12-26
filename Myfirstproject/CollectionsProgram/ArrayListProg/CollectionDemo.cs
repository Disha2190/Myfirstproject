using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myfirstproject.CollectionsProgram
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add("Pune");
            a1.Add(89.26);
            a1.Add(90);
            a1.Add('t');
            ArrayList a12 = new ArrayList();
            a12.Add(78);
            a12.InsertRange(0, a12);
            foreach (var x in a12)
            {
                Console.WriteLine(x);
            }
        }
    }
    class CollectionDemo1
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1,
                "Mumbai",
                'u',
                5,
                85.23,
                "pune",
                56
            };
            foreach (var x in a1)
            {
                Console.WriteLine(x);
            }
            a1.Remove('u');
            Console.WriteLine("......................");
            foreach (var x in a1)
            {
                Console.WriteLine(x);
            }
            a1.Remove(0);
            Console.WriteLine("......................");
            foreach (var x in a1)
            {
                Console.WriteLine(x);
            }
            a1.RemoveRange(0, 2);
            Console.WriteLine("..........Range Remove.............");
            foreach (var x in a1)
            {
                Console.WriteLine(x);
            } 
        }
    }
    class CollectionDemo2
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1,
                "Mumbai",
                'u',
                5,
                85.23,
                "pune",
                56
            };
            Console.WriteLine(a1.Contains(56));
            ArrayList a12 = new ArrayList();
            a12.AddRange(a1);
            foreach(var x in a12)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("............................................");
            Console.WriteLine(a1.Count);
            a1.Clear();
            Console.WriteLine(a1.Count);
        }
    }
}

