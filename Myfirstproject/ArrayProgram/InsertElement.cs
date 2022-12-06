using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Insert  //Replace element in array
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array " + size + " elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Array is: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nEnter the position element to be inserted:");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter element to be inserted:");
            int n = int.Parse(Console.ReadLine());
        
            if (pos <= size && pos >= 0)
            {
                arr[pos - 1] = n;
                for (i=0;i<size;i++)
                {
                    Console.Write(arr[i]+" ");
                }
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }
    } 

    class Insert1 //replace element by taking element to be replaced
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            int i;
            for(i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nEnter element to found:");
            int n = int.Parse(Console.ReadLine());
            
            for(i=0;i<size;i++)
            {
                if (arr[i]==n)
                {
                    Console.WriteLine("Enter element to be replaced:");
                    int n1 = int.Parse(Console.ReadLine());
                    arr[i] = n1;
                }
            }
            Console.WriteLine("Modified array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
