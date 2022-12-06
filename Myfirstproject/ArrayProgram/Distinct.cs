using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Distinct
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements ");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nDistinct elements in array are:");
            for(i=0;i<arr.Length;i++)
            {
                for(j=0;j<i;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        break;
                    }
                }
                if(i==j)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
}
