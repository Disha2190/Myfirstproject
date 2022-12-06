using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class SameArray // Array1 is eqal to array2 or not
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array1 elements:");
            int[] arr1 = new int[size];
            for (i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {size} array2 elements:");
            int[] arr2 = new int[size];
            for (i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array1 is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine("\nThe array2 is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            int Count = 0;
            for(i=0;i<size;i++)
            {
                if(arr1[i]==arr2[i])
                {
                    Count++;
                }
                else
                {
                    break;
                }
            }
            if(Count==size)
            {
                Console.WriteLine("\nArray1 is equal to Array 2");
            }
            else
            {
                Console.WriteLine("\nArray1 is not equal to Array 2");
            }
        }
    }
}
