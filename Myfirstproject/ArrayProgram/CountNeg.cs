using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class CountNeg
    {
        static void Main(string[] args)
        {
            int i, count = 0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} elemnets of array:");
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
            for (i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\n"+count+" Negative numbers are in array");
        }
    }
}
