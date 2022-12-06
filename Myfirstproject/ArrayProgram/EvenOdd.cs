using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class EvenOdd //put even and odd elements in two seperate array
    {
        static void Main(string[] args)
        {
            int i,e,o;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array elements:");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            for (i = 0,e=0,o=0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[e++] = arr[i];
                }
                else
                {
                    arr2[o++] = arr[i];
                }
            }
            Console.WriteLine("Even number array is:");
            for (i = 0; i < e; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("\nOdd numbr array is:");
            for (i = 0; i < o; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
