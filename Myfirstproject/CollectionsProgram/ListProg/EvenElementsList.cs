using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class EvenElementsList
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            for(int i=0;i<l.Count;i++)
            {
                if (l[i] % 2 == 0)
                {
                    Console.WriteLine(l[i]);
                }
            }
        }
    }
}
