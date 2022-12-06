using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class MergAltEle
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
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Elements of array 3 are:");
            for (i = 0; i < size1 + size2; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }

    class MergArray3
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
            int[] arr3 = new int[arr1.Length+arr2.Length];
            int k = 0, cnt;
            for(i=0;i<arr1.Length;i++)
            {
                cnt = 0;
                for(j=k-1;j>=0; j--)
                {
                    if(arr3[j]==arr1[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for(i=0;i<arr2.Length;i++)
            {
                cnt = 0;
                for(j=k-1;j>=0;j--)
                {
                    if (arr3[j] == arr2[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if(cnt==0)
                {
                    arr3[k] = arr2[i];
                    k++;
                }
            }
            Console.WriteLine("Elements of array 3 are:");
            for (i = 0; i < k; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
}
