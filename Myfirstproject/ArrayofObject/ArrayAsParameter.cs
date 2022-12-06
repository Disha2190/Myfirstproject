using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayofObject
{
    class ArrayAsParameter
    {
        int[] arr = new int[10];
        public void accept()
        {
            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            foreach(int no in arr)
                Console.Write(no+" ");
        }
        public int retAvgofEven()
        {
            int sum = 0, avg, cnt=0;
            foreach(int no in arr)
                if(no%2==0)
                {
                    sum += no;
                    cnt++;
                }
            avg = sum / cnt;
            return avg;
        }
        public void copy(int[] a)
        {
            for(int i=0;i<a.Length;i++)
                arr[i] = a[i];
        }
        public int[] sort()
        {
            Array.Sort(arr);
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 6, 4, 5 };
            ArrayAsParameter obj = new ArrayAsParameter();
            obj.accept();
            obj.display();
            Console.WriteLine("/nReturn average of even number is: "+obj.retAvgofEven());
            obj.copy(arr);
            obj.display();
            arr = obj.sort();
            Console.WriteLine("/nSorted array is:");
            foreach(int no in arr)
                Console.WriteLine(no+" ");
        }
    }
    class AvgOddArr
    {
        int[] arr = new int[10];
        public void accept()
        {
            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            foreach (int no in arr)
                Console.Write(no + " ");
        }
        public int retAvgofOdd()
        {
            int sum = 0, avg, cnt = 0;
            foreach (int no in arr)
                if (no % 2 != 0)
                {
                    sum += no;
                    cnt++;
                }
            avg = sum / cnt;
            return avg;
        }
        public int[] sort()
        {
            Array.Sort(arr);
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            AvgOddArr obj = new AvgOddArr();
            obj.accept();
            obj.display();
            Console.WriteLine("\nReturn average of even number is: " + obj.retAvgofOdd());
            arr = obj.sort();
            Console.WriteLine("\nSorted array is:");
            foreach (int no in arr)
                Console.Write(no + " ");
        }
    }
}
