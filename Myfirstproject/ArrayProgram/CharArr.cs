using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class CharArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} character elements of array ");
            char[] arr = new char[size];
            for(int i=0;i<size;i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
