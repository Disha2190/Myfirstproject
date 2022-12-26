using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Revision1
{ 
   class LargestElement
   {
        //Largest number in array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter array elements: ");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largest = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]>largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine("Largest number is: "+largest);
        }
   }
    class SmallestElement
    {
        //Smallest number in array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int smallest = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(smallest>arr[i])
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine("Smallest number in array is: "+smallest);
        }
    }
    class SmallLargNumber
    {
        //Smallest and largest number in array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largest = arr[0];
            int smallest = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<largest)
                {
                    largest = arr[i];
                }
                if(arr[i]>smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine($"Largest: {largest} \nSmallest: {smallest}");
        }
    }
    class SecondSmallest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int smallest = arr[0];
            for(int i=0; i<arr.Length;i++)
            {
                if(smallest>arr[i])
                {
                    smallest = arr[i];
                }
            }
            int secdsmallest = Int32.MaxValue;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<secdsmallest && arr[i]>smallest)
                {
                    secdsmallest = arr[i];
                }
            }
            Console.WriteLine("second Smallest number in aray is: "+secdsmallest);
        }
    }
    class Sum
    {
        //sum of elements in array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum=0;
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements: "+sum);
        }
    }
    class Reverse
    {
        //reverse array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] arr1 = new int[s];
            for(int i=arr.Length-1,j=0;i>=0;i--)
            {
                arr1[j++] = arr[i];
            }
            Console.WriteLine("Array is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr1[i]+" ");
            }
        }
    }
    class SortHalfAscDes
    {
        //Sort first half in ascending order and second half in descending 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < (arr.Length / 2)-1; i++)
            {
                for(int j=i+1;j<(arr.Length/2);j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i=arr.Length/2;i<(arr.Length)-1;i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] < arr[k])
                    {
                        int temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted first half in ascending order and second half in descending array is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class Sort
    {
        //Sort the elements of an array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
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
            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class Frequecy
    {
        //Finding the frequency of elements in an array 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("Occurence is:");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + ": " + count);
                }
            }
        }
    }
    class SortByFrequency
    {
        //Sorting elements of an array by frequency 
        static void Main(string[] args)
        {

        }
    }
    class Palindrom
    {
        //Finding the longest palindrome in an array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            int large = 0;
            for(int i=0;i<arr.Length;i++)
            {
                int rev, sum = 0,temp=arr[i];
                while(arr[i]>0)
                {
                    rev = arr[i] % 10;
                    sum = sum * 10 + rev;
                    arr[i] = arr[i] / 10;
                }
                if(temp==sum)
                {
                    if(temp>large)
                    {
                        large = temp;
                    }
                }
            }
            Console.WriteLine("\nlargest palindrom number is: "+large);
        }
    }
    class CountDistinct
    {
        //Counting Distinct Elements in an Array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter {s} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int count = 0,j;
            for(int i=0;i<arr.Length;i++)
            {
                for(j=0;j<i;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    count++;
                }
            }
            Console.WriteLine("Total Distinct elements are: "+count);
        }
    }
    
}
