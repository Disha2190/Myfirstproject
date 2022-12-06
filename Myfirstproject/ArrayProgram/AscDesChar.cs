using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Ascchar
    {
        static void Main(string[] args)
        {
            int i, j;
            char t;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array1 elements:");
            char[] arr = new char[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Ascending array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    
    class AscDesChar   //Sort first half in ascending and second half in descending
    {
        static void Main(string[] args)
        {
            int i, t, j;  
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int n = arr.Length;
            //Sort array
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < n / 2; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (j = n - 1; j >= n / 2; j--)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }

    class NegSqa  //WAP to replace all negative values with its immediate left element square.
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Array is:");
            for(i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
