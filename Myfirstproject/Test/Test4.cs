using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class MergeArray    //1.	Merging elements of two different arrays alternatively in third array.
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter array 1 size:");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size1} elements of array 1:");
            int[] arr1 = new int[size1];
            for(i=0;i<size1;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 size:");
            int size2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size2} elements of array 1:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[size1 + size2];
            for(i=0,j=0;i<size1;i++)
            {
                arr3[j++] = arr1[i];
            }
            for(i=0;i<size2;i++)
            {
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Merged array is:");
            for(i=0;i<size1+size2;i++)
            {
                Console.Write(arr3[i]+" ");
            }
        }
    }
    class Swap //2.	WAP to create a array of 10 elements and swap first two elements with last two elements
    {
        static void Main(string[] args)
        {
            int i,j,t;
            int[] arr = new int[10];
            Console.WriteLine("enter 10 elements of array:");
            for(i=0;i<10;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           
            for (i = 0, j = 10 - 1; i < 2; i++, j--)
            {
                t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
            Console.WriteLine("Array after swaping:");
            for(i=0;i<10;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class Frequency     //3.	WAP to find frequency/count of each element in 1D array.
    {
        static void Main(string[] args)
        {
            int i, count = 0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nThe array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Boolean[] found = new Boolean[size];
            for (i = 0; i < size; i++)
            {
                found[i] = false;
            }
            for (i = 0; i < size; i++)
            {
                if (found[i] == true)
                    continue;
                count = 1;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        found[j] = true;
                        count++;
                    }
                }
                Console.WriteLine("\n" + arr[i] + " occurs " + count + " times");
            }
        }
    }
    class PosNeg //4.	How to rearrange array in alternating positive and negative number.
    {
        static void Main(string[] args)
        {
            int i=0, p = 0, n = 0, j = 0,k=0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[size];
            int[] arr3 = new int[size];
            for(i=0;i<size;i++)
            {
                if(arr[i]<0)
                {
                    arr2[n++] = arr[i];
                }
                else
                {
                    arr3[p++] = arr[i];
                }
            }
            int[] arr4 = new int[size];
            i = 0;
            while(i<n && j<p)
            {
                arr4[k++] = arr2[j++];
                arr4[k++] = arr3[i++];
            }
            while(j<p)
            {
                arr4[k++] = arr2[j++];
            }
            while(i<n)
            {
                arr4[k++] = arr3[i++];
            }
            Console.WriteLine("Array is:");
            for(i=0;i<n+p;i++)
            {
                Console.Write(arr4[i]+" ");
            }
        }
    }

    class Zero  //5.	Write a program to separate zeros from non-zeros in an integer array?
    {
        static void Main(string[] args)
        {
            int i,j,t;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
