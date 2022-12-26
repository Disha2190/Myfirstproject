using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class PrimeNoList
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>()
            {
                4,5,34,65,55,7,9
            };
            int count = 0;
            for(int i=0;i<l.Count;i++)
            {
                count = 0;
                for(int j=2;j<=l[i]/2;j++)
                {
                    if(l[i]%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine(l[i]);
                }

            }
        }
    }
}
