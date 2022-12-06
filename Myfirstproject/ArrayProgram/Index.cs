using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Array15 //searh given number in array and print index if exist
    {
        static void Main(string[] args)
        {
            int count = 0, i;
            Console.WriteLine("Enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array " + size + " elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to search:");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < size; i++)
            {
                if (arr[i] == n)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine("Element " + n + " is found at index: " + (i + 1));
            }
            else
            {
                Console.WriteLine("Element " + n + " is not found in the array");
            }
        }
    }

}
