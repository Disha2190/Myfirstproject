using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class MergeArr
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter array 1 size:");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array 1 elements:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 size:");
            int size2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array 2 elements:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[size1 + size2];
            for (i = 0, j = 0; i < size1; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < size2; i++)
            {
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Elements of array 3 are:");
            for (i = 0; i < size1 + size2; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }

    }
    class MergeArr1
    {
        static void Main(string[] args)
        {
            int i, j;
            
            Console.WriteLine("Enter array 1 elements:");
            int[] arr1 = new int[10];
            for (i = 0; i < 5; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 elements:");
            int[] arr2 = new int[5];
            for (i = 0; i < 5; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            i = 5;
            for (j=0; j < 5; i++,j++)
            {
                arr1[i] = arr2[j];
            }
            Console.WriteLine("Concatinated array is:");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }

    }
    class swap
    {
        static void Main(string[] args)
        {
            int i, t,j;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
            for(i=0,j = size - 1;i<size/2;i++,j--)
            {
                t = arr[i];
                arr[i]=arr[j];
                arr[j] = t;
            }
            Console.WriteLine("\nIn place reverse array is:");
            for(i=0;i<size;i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
