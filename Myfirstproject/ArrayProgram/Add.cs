using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Add  //Addition of alternete elements
    {
        static void Main(string[] args)
        {
            int i,sum=0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array elements:");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
            for(i=0;i<size;i+=2)
            {
                sum += arr[i];
            }
            Console.WriteLine("\nAddition of alternate elements is: "+sum);
        }    
    }
}
