using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class CheckChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} character elements of array ");
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nEnter the character to check:");
            char ch = char.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<size;i++)
            {
                if(arr[i]==ch)
                {
                    count++;
                }
            }
            if(count!=0)
            {
                Console.WriteLine(ch+" is present in array");
            }
            else
            {
                Console.WriteLine(ch+" is not present in array");
            }
        }
    }
}
