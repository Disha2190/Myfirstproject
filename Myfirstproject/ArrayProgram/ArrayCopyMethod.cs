using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class ArrayCopyMethod
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is: "+list.Length);
            int[] temp = list;
            int[] t = new int[list.Length];
            Array.Copy( list, t, list.Length);
            Console.WriteLine("Copied array: ");
            foreach(int i in t)
            {
                Console.Write(i+" ");
            }
        }
    }

     class ArrayCopyMethod1
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is: " + list.Length);
            int[] temp = list;
            int[] t = { 1, 2, 0, 0, 0, 0, 0 };
            Array.Copy(list, 2, t, 2, 5);
            foreach(int i in t)
            {
                Console.Write(i+" ");
            }
        }
    }
    class ArrayCopyMethod2
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is: " + list.Length);
            
            int index = Array.IndexOf(list, 44);
            Console.WriteLine("Index of 44 in array is: " + index);

            int[] temp = list;
            int[] t = { 1, 2, 0, 0, 0, 0, 0 };
           
            Array.Copy(list, 2, t, 2, 5);
            
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine("\nOriginal array:");
            
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            
            Array.Reverse(temp);
            
            Console.WriteLine("\nReversed array:");
            foreach(int i in temp)
            {
                Console.Write(i+" ");
            }
            
            Array.Sort(list);
            
            Console.WriteLine("\nSorted Array is:");
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }

            Array.Clear(list, 2,3);
            Console.WriteLine("\nCleared array is:");
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
        }
    }
    class ArrayCopyMethod3
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is: " + list.Length);
            Array.Clear(list, 2, list.Length - 2);
            Console.WriteLine("\nCleared array is:");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            int[] a1 = { 1, 2, 3, 4, 5, 6 };
            int[] a2 = a1;
            if(Array.Equals(a1,a2))
            {
                Console.WriteLine("\nArrays are equal");
            }
            else
            {
                Console.WriteLine("\nArrays are not equal");
            }
        }
    }

    class ArrayCopyMethod4
    {
        static void Main(string[] args)
        {
            string myName = "myName is Pooja";
            myName = myName.ToUpper();
            Console.WriteLine(myName);

            myName = "myName is MAHESH";
            myName = myName.ToLower();
            Console.WriteLine(myName);

            myName = "     myName is SHRADDHA       ";
            myName = myName.Trim();
            Console.WriteLine(myName);

            myName = "     myName is SHRADDHA       ";
            myName = myName.TrimEnd();
            Console.WriteLine(myName + "  " + " Done");

            myName = "     myName is SHRADDHA       ";
            myName = myName.TrimStart();
            Console.WriteLine(myName + "  " + " Done");

            myName = "myName is GIRISH";
            bool isContains = myName.Contains("GIRISH1");
            Console.WriteLine(isContains);

            myName = "myName is SHREYASH";
            char[] charArray = myName.ToCharArray();
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }
            myName = "myName is SHIRISH";
            myName = myName.Substring(0, 6);
            Console.WriteLine(myName);


            myName = "myName is SHREENATH";
            isContains = myName.StartsWith("my");
            Console.WriteLine(isContains);

            myName = "myName/is/SHIKHA";
            string[] breakMysentence = myName.Split('/');
            foreach (string data in breakMysentence)
                Console.WriteLine(data);
        }
    }
}
