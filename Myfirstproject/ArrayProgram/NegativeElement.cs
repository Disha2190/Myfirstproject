using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class NegElement  //print negative elements in array and count them
    {
        static void Main(string[] args)
        {
            int i, count = 0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array elements:");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative elements are: ");
            for (i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                    count++;
                }
            }
            Console.WriteLine(count + " numbers are negative in array");
        }
    }
}
