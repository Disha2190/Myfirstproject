using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class DuplicateNo1
    {
        static void Main(string[] args)
        {
            int i,count=0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            for(i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter any element:");
            int n = int.Parse(Console.ReadLine());
            for(i=0;i<size;i++)
            {
                if(arr[i]==n)
                {
                    count++;
                }
            }
            Console.WriteLine(n+" is present "+count+" times in array");
        }
    }
    class DuplicateNo
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
            for(i=0;i<size;i++)
            {
                found[i] = false;
            }
            for (i = 0; i < size; i++)
            {
                if (found[i] == true)
                    continue;
                count = 1;
                for (int j = i+1; j < size; j++)
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
}
