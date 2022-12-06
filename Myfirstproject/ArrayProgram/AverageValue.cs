using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Average
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array " + size + " elements:");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            int avg = sum / size;
            Console.WriteLine("Average value of array elements is: " + avg);
        }
    }
}
