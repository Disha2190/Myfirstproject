using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Task1 //WAP to search for a given number in an array and accordingly print the index if exists
    {
        static void Main(string[] args)
        {
            int i, count = 0;

            Console.WriteLine($"Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} elements of array:");
            int[] arr = new int[size];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\nEnter the element to be found:");
            int n = int.Parse(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"{n} is present at {i + 1} location in array");
            }
            else
            {
                Console.WriteLine("Element " + n + " is not found in the array");
            }
        }
    }
    class Task2 //Write two methods that return the average of an array with following headers
                //public static int average(int[] array) public static double average(double[] array).
                //Write main and invoke the 2 methods
    {
        static void Main(string[] args)
        {

        }
    }
    class Task3 //WAP to print all negative elements in an array and also count total number of negative elements in an array.
    {
        static void Main(string[] args)
        {
            int i, count = 0;
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter {size} elements of array:");
            int[] arr = new int[size];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nNegative elements in array are:");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    Console.Write(arr[i] + " ");
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"\n{count} Negative elements are in array");
            }
        }
    }
    class Task4 //WAP to put even and odd elements of array in two separate arrays.
    {
        static void Main(string[] args)
        {
            int i,e=0,o=0;
            Console.WriteLine("Enter size of array1:");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {s1} elements of array 1:");
            int[] arr1 = new int[s1];
            for(i=0;i<arr1.Length;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[s1];
            int[] arr3 = new int[s1];
            for(i=0;i<arr1.Length;i++)
            {
                if(arr1[i]%2==0)
                {
                    arr2[e++] = arr1[i];
                }
                else
                {
                    arr3[o++] = arr1[i];
                }
            }
            Console.WriteLine("Even elements array is: ");
            for(i=0;i<e;i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine("\nOdd elements array is: ");
            for (i = 0; i < o; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
    class Task5  //WAP to find the maximum and minimum value in an array.
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter {size} elements of array:");
            int[] arr = new int[size];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int min = arr[0];
            int max = arr[0];
            for(i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"\nMaximun element in array is {max}");
            Console.WriteLine($"Maximun element in array is {min}");

        }
    }
    class Task6 //WAP to find and count total number of duplicate elements in an array.
    {
        static void Main(string[] args)
        {
            int i,  count=0;
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter {size} elements of array:");
            int[] arr = new int[size];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Boolean[] found = new Boolean[size];
            for(i=0;i<size;i++)
            {
                found[i] = false;
            }
            for(i=0;i<size;i++)
            {
                if (found[i] == true)
                    continue;
                count= 1;
                for(int j=i+1;j<size;j++)
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
    class Task7 //WAP to print all unique elements in the array.
    {
        static void Main(string[] args)
        {
            int i, count = 0,j,k;
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter {size} elements of array:");
            int[] arr = new int[size];
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for(i=0;i<size;i++)
            {
                count = 0;
                for(j=0,k=size;j<k+1;j++)
                {
                    if(i!=j)
                    {
                        if(arr[i]==arr[j])
                        {
                            count++;
                        }
                    }
                }
                if(count==0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
    class Task8 //WAP to find the second smallest element in an array.
    {
        static void Main(string[] args)
        {
            int i, t=0, j;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array elements:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Second smallest number is: "+arr[1]);
        }
    }
    class Task9 //WAP to count frequency of each element in an array.
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
            for (i = 0; i < size; i++)
            {
                found[i] = false;
            }
            for (i = 0; i < size; i++)
            {
                if (found[i] == true)
                    continue;
                count = 1;
                for (int j = i + 1; j < size; j++)
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
    class Task10 // WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
    {
        static void Main(string[] args)
        {
                int i, j;
                Console.WriteLine("Enter array 1 size:");
                int size1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter array 1 elements:");
                int[] arr1 = new int[size1];
                for (i = 0; i < size1; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter array 2 size:");
                int size2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter array 2 elements:");
                int[] arr2 = new int[size2];
                for (i = 0; i < size2; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                int[] arr3 = new int[size1 + size2];
                for (i = 0, j = 0; i < size1; i++)
                {
                    arr3[j++] = arr1[i];
                }
                for (i = 0; i < size2; i++)
                {
                    arr3[j++] = arr2[i];
                }
                Console.WriteLine("Elements of array 3 are:");
                for (i = 0; i < size1 + size2; i++)
                {
                    Console.Write(arr3[i] + " ");
                }
            
        }
    }
    class Task11 //WAP sort array elements in ascending order.
    {
        static void Main(string[] args)
        {

        }
    }
}
