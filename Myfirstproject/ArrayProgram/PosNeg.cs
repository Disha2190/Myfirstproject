using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class PosNeg
    {
        static void Main(string[] args)
        {
            int i,p=0,n=0;
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array elements:");
            int[] arr = new int[size];
            for(i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            for(i=0;i<size;i++)
            {
                if(arr[i]>=0)
                {
                    arr1[p++] = arr[i];
                }
                else
                {
                    arr2[n++] = arr[i];
                }
            }
            Console.WriteLine("\nPositive number array is:");
            for(i=0;i<p;i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine("\nNegative number array is:");
            for(i=0;i<n;i++)
            {
                Console.Write(arr2[i]+" ");
            }
        }
    }
}
