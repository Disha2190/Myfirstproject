using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ParamKeyword
    {
        public static void Average(params int[] no)
        {
            int sum = 0; 
            foreach(int n in no)
            {
                sum += n;
            }
            int avg = sum / no.Length;
            Console.WriteLine("Average is: "+avg);
        }
        static void Main(string[] args)
        {
            Average(4, 5);
            Average(4, 5, 6);
            Average(3, 4, 5, 6, 7);
        }
    }
    class ParamKeyword1
    {
        public static void Add(params int[] no)
        {
            int sum = 0;
            foreach (int n in no)
            {
                sum += n;
            }
            Console.WriteLine("Addition of " + no.Length + " parameter is: " + sum);
        }
        public static void AddName(params string[] names)
        {
            string s = " ";
            foreach (string str in names)
                s = s + str;
            Console.WriteLine("Concatinated string is: " + s);
        }
        static void Main(string[] args)
        {
            Add(4, 5);
            Add(4, 5, 6);
            Add(3, 4, 5, 6, 7);
            AddName("Hello");
            AddName("Hello", "Good", "Afternoon");
        }

    }
}
