using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myfirstproject.CollectionsProgram
{
    class EvenPostion
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1,
                "Mumbai",
                "Pune",
                45.23,
                'r',
                32
            };
            Console.WriteLine("Even Postion elements are:");
            for(int i=1;i<a1.Count;i+=2)
            {
                Console.WriteLine(a1[i]);
            }
        }
    }
}
