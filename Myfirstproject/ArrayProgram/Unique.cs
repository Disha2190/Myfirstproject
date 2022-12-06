using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Unique
    {
        static void Main(string[] args)
        {
            int i, j,count=0;
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
            Console.WriteLine("\nUnique elements are: ");
            for (i = 0; i < size; i++)
            {
                count = 0;
                for (j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                }
                if (count==0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
   
}
