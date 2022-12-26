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
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr = new int[arr1.Length+arr2.Length];

          
            Console.WriteLine("Enter array 1 elements:");
            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
          
            Console.WriteLine("Enter array 2 elements:");
            for (i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            
            int k = 0, count = 0;
            for(i=0;i<arr1.Length;i++)
            {
                count = 0;
                for(j=k-1;j>=0;j--)
                {
                    if(arr[i]==arr1[j])
                    {
                        count++;
                        break;
                    }
                }
                if(count==0)
                {
                    arr[k++] = arr1[i];
                }
            }
            for(i=0;i<arr2.Length;i++)
            {
                count = 0;
                for(j=k-1;j>=0;j--)
                {
                    if(arr[i]==arr2[j])
                    {
                        count++;
                        break;
                    }
                }
                if(count==0)
                {
                    arr[k++] = arr2[i];
                }
            }
            Console.WriteLine("Merged array is:");
            for(i=0;i<k;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class Task11 //WAP sort array elements in ascending order.
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    //WAP to reverse the array itself, don’t print array in reverse – I want current array reverse.
    //Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] without
    //using temporary array
    class Task12
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            for(int i=0,j=arr.Length-1;i<arr.Length/2;i++,j--)
            {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    //Write a  program to test the equality of two arrays. Means e.g arr1[] = [12, 22, 32, 42, 52, 62]
    //and arr2[] = [52, 22, 62, 12, 42, 22] Here both arrays are equal.
    class Task13
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 22 };
            int count = 0;
            if(arr1.Length==arr2.Length)
            {
                for(int i=0;i<arr1.Length;i++)
                {
                    for(int j=0;j<arr2.Length;j++)
                    {
                        if(arr1[i]==arr2[j])
                        {
                            count++;
                        }
                    }
                }
                if(count==arr1.Length)
                {
                    Console.WriteLine("Array are equal");
                }
                else
                {
                    Console.WriteLine("Array are unequal");
                }
            }
        }
    }

    //WAP to replace all negative value with its immediate left elements square.
    //Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
    //Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].
    class Task14
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            for(int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    //WAP to arrange the elements of an given array of integers where all negative integers appear before
    //all the positive integers.
    class Task15
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -78, 2, 4, -25, 5, 67, -45 };
            int[] arr1 = new int[arr.Length];
            int k = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    arr1[k++] = arr[i];
                }
            }
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>=0)
                {
                    arr1[k++] = arr[i];
                }
            }
            for(int i=0;i<k;i++)
            {
                Console.Write(arr1[i]+" ");
            }
        }
    }

}
