using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class SortArr
    {
        static void Main(string[] args)
        {
            int i,t,j;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array1 elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<size-1;i++)
            {
                for(j=i+1;j<size;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
