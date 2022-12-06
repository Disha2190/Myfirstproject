using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class PrimeNo
    {
        static void Main(string[] args)
        {
            int i,count=0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} elements of array:");
            int[] arr = new int[size];
            for(i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for(i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n The prime numbers in array are:");
            for(i=0;i<size;i++)
            {
                count = 0;
                for(int j=2;j<=arr[i]/2;j++)
                {
                    if(arr[i]%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine(arr[i]+" ");
                }
            }
        }
    }

    class PrimeAdd
    {
        static void Main(string[] args)
        {
            int i, count = 0,sum=0;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} elements of array:");
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
                count = 0;
                for (int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("\nSum of prime numbers in array is: "+sum);
        }
    }
    class PrimeAdd1
    {
        static void Main(string[] args)
        {
            int i,sum=0;
            bool prime=false;
            int[] arr = new int[5];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < arr.Length; i++)
            {
                prime = false;
                for (int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        prime = true;
                        break;
                    }
                }
                if (prime==false)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("\nSum of prime numbers in array is: " + sum);
        }
    }
}
