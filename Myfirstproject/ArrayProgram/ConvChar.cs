using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram
{
    class ConvChar
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
            Console.WriteLine("\nArray in upper case is:");

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    arr[i] = (char)(arr[i] + 'A' - 'a');
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class ConvChar1
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
            Console.WriteLine("\nArray in Lower case is:");

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    arr[i] = (char)(arr[i] + 'a' - 'A');
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class ConvChar3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} character elements of array ");
            char[] str = new char[size];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(str[i] + " ");
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    str[i] = (char)(str[i] + 32);
                }
                else
                {
                    str[i] = (char)(str[i] - 32);
                }
            }
            Console.WriteLine("\nConverted Data is:");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
    }
    class charOccur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} character elements of array ");
            char[] str = new char[size];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(str[i] + " ");
            }
            int count = 0;
            Console.WriteLine("\nEnter any charactr:");
            char ch = char.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                }
            }
            Console.WriteLine(ch + " is present " + count + " times in array");
        }
    }

    class CharOcc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            bool check = true;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    check = false;
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine($"{ch} is present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is not present in array");
            }
        }
    }
}
