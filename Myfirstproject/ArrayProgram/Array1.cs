using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }
    }

    class Array2
    {
        int[] arr = new int[5];
        public void Declear()
        {
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
           
        }
        public void Display()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Array2 a = new Array2();
            a.Declear();
            a.Display();
        }
    }
    
    class Array3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter five elements of array:");
            for(int i=0;i<5;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is: ");
            for(int i=0;i<5;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class Array4
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5};

            for(int i=0;i<5;i++)
            {
                Console.Write(arr[i]+" ");
            }

        }
    }
    class Array5
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Data is: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n Array in reverse:");
            for (int i = 4; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class Array6 //Take array size from usre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter "+size+" element to array:");
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array data is:");
            for(int i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class Array7 //add array elements
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter " + size + " element to array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array data is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("sum of array elements:");
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
    class Array8 //add array even elements
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter " + size + " element to array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array data is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nsum of array even elements:");
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }

   class Array9 //Copy 1 array into another array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array1 size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter " + size + " element to array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the array2 size: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size1];
            if (size == size1)
            {
                for (int i = 0; i < size1; i++)
                {
                    arr1[i] = arr[i];
                }
                Console.WriteLine("Copied array is:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("array size is not equal");
            }
        }
    }

    class Array10  //copy reverse array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            Console.WriteLine("Enter the array: ");

            for (int i=0;i<5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0,j=4; i < 5; i++,j--)
            {
                arr1[i] = arr[j];
            }
            Console.WriteLine("Copied array is:");

            for (int i=0;i<5; i++)
            {
                Console.Write(arr1[i] + " ");

            }
        }
    }
    class Array11   // find element
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter array elements:");
            for(int i=0;i<5;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to find in array:");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<5;i++)
            {
                if(arr[i]==a)
                {
                    count++;
                }
            }
            if(count!=0)
            {
                Console.WriteLine(a+" is present in array "+count+ " times");
            }
            else
            {
                Console.WriteLine(a+" is not present in array");
            }
        }
    }
    class Array12   //replace element
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter array elements:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to find in array:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element to replace in array:");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] == a)
                {
                    arr[i] = b;
                }
            }
            for(int i=0;i<5;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class Array13 //replace element as zero
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter array elements:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to find in array:");
            int a = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] == a)
                {
                    arr[i] = 0;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class Array14   //delete element
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
           
            Console.WriteLine("enter array elements:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Enter the position of element:");
            int a = int.Parse(Console.ReadLine());

            if (a >= 5 + 1)
            {
                Console.WriteLine("Deletion not possible");
            }
            else
            {
                for (int i = a - 1; i < 4; i++)
                {
                    arr[i] = arr[i + 1];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
