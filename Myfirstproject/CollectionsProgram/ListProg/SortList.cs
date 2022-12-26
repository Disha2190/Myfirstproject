using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class SortList
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>()
            {
                 8,6,4,7,9,5,3,1,2
            };
            for(int i=0;i<l.Count;i++)
            {
                for(int j=i+1;j<l.Count;j++)
                {
                    if(l[i]>l[j])
                    {
                        int temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted list is: ");
            for(int i=0;i<l.Count;i++)
            {
                Console.WriteLine(l[i]);
            }
        }
    }
}
