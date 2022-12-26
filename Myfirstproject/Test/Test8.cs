using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class Duplicate
    {
        //Duplicate number and their occurence
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            String str = Console.ReadLine();
            str = str.ToLower();
            string[] s = str.Split();
            int count = 1;
            for(int i=0;i<s.Length;i++)
            {
                count = 1;
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i].Equals(s[j]))
                    {
                        count++;
                        s[j] ="0";
                    }
                }
                if(count>1 && s[i]!="0")
                {
                    Console.WriteLine(s[i]+": "+count);
                }
            }
        }
    }
    class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            string[] st = str.Split();
            int count = 0;
            for(int i=0;i<st.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1:");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter string 2:");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            if(ch1.Length==ch2.Length)
            {
                Array.Sort(ch1);
                Array.Sort(ch2);
                Console.WriteLine(string.Join(" ", ch1));
                Console.WriteLine(string.Join(" ", ch2));
                string st1 = new string(ch1);
                string st2 = new string(ch2);
                Console.WriteLine(st1+" "+st2);
                if(st1.Equals(st2))
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
    class SortDesc
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"Enter {arr.Length} elememts of array");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]<arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class AlpDigSpe
    {
        //count alphabet digit special char in string

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            //char[] ch = str.ToCharArray();
            int count = 0, flag = 0, cnt = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsDigit(str[i]))
                {
                    count++;
                }
                else if(char.IsLetter(str[i]))
                {
                    flag++;
                }
                else
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Alphabets:{flag} \nDigits:{count} \nSpecial character:{cnt}");
        }
    }
    class LowerCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            string st = str.ToLower();
            Console.WriteLine(st);
        }
    }
    class RevArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {arr.Length} elements of array:");
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0,j=arr.Length-1;i<arr.Length/2;i++,j--)
            {
               int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
            Console.WriteLine("\nReverse array is:");
            for (int i = 0; i <arr.Length ; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
   class Mergearray
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr = new int[arr1.Length + arr2.Length];

            Console.WriteLine($"Enter {arr1.Length} elements of array1:");
            for(i=0;i<arr1.Length;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Enter {arr2.Length} elements of array1:");
            for(i=0;i<arr2.Length;i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int k = 0,count=0;
            for(i=0;i<arr1.Length;i++)
            {
                count = 0;
                for(j=k-1;j>=0;j--)
                {
                    if(arr[j]==arr1[i])
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
            for (i = 0; i < arr2.Length; i++)
            {
                count = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (arr[j] == arr2[i])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    arr[k++] = arr2[i];
                }
            }
            Console.WriteLine("Merged array is:");
            for (i=0;i<k;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class SortAsc
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine($"Enter {arr.Length} elements of array:");
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
            Console.WriteLine("Sorted ascending array is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class ZeroToOne
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"Enter {arr.Length} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine("Array is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
    class NegToSqr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"Enter {arr.Length} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i-1;j<arr.Length;j++)
                {
                    if(arr[i]<0)
                    {
                        arr[i] = arr[j] * arr[j];
                    }
                }
            }
            Console.WriteLine("Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class MinChar
    {
        static void Main(string[] args)
        {
            char[] arr = new char[6];
            Console.WriteLine($"Enter {arr.Length} elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            char min = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
    }
    class Unique
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] arr = new int[10];
            Console.WriteLine($"Enter {arr.Length} elements of array:");
            for(i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nUnique Elements in array are:");
            for(i=0;i<arr.Length;i++)
            {
                for(j=0;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        break;
                    }
                }
                if(i==j)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: "+(num1+num2));
        }
    }
    class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int subtr = num1 - num2;
            int div = num1 / num2;
            int multi = num1 * num2;
            Console.WriteLine($"Addition:{sum} \nSubtraction: {subtr} \nDivision:{div} \nMultiplication: {multi}");
        }
    }
    class RectArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length:");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth:");
            int b = int.Parse(Console.ReadLine());
            int area = l * b;
            Console.WriteLine("Area: "+area);
        }
    }
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            int h = int.Parse(Console.ReadLine());
            int area = (b * h) / 2;
            Console.WriteLine("Area: "+area);
        }
    }
    class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            int num = int.Parse(Console.ReadLine());
            int sq = num * num;
            Console.WriteLine("Square: "+sq);
        }
    }
    class Cube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num*num;
            Console.WriteLine("Square: " + cube);
        }
    }
    class Conversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length in centimeter : ");
            float length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Length in meter: " + length / 100 + "m");
            Console.WriteLine("Length in Kilometer: " + length / 100000 + "km");
        }
    }
    class Average2
    {
        static void Main(string[] args)
        {
            float Per;
            Console.WriteLine("Enter the Marks of five subjects:");
            int Maths = Convert.ToInt32(Console.ReadLine());
            int English = Convert.ToInt32(Console.ReadLine());
            int Science = Convert.ToInt32(Console.ReadLine());
            int Physics = Convert.ToInt32(Console.ReadLine());
            int Chemistry = Convert.ToInt32(Console.ReadLine());

            int total = Maths + English + Science + Physics + Chemistry;

            float average = total / 5;

            Per = (total / 500.0f) * 100;

            Console.WriteLine("Total marks are: " + total);
            Console.WriteLine("Average of marks: " + average);
            Console.WriteLine("The Percentage are: " + Per + "%");
        }
    }
    class SimpleIntrest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal, rate, time period: ");
            int principal = Convert.ToInt32(Console.ReadLine());
            float rate = Convert.ToSingle(Console.ReadLine());
            int TimePeriod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Simple Intrest= " + (principal * rate * TimePeriod) / 100);
        }
    }
    class RectPerimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perimeter of rectangle= " + (length + breadth) * 2);
        }
    }
}
