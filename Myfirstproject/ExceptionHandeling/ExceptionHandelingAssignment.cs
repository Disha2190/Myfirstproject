using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    //WAP which throws IndexOutOfRangeException.In the console, observe the stack trace and
    //the line number from where the Exception is thrown
    class Task1
    { 
        static void Main(string[] args)
        {
            int[] arr = {4,5,3,5,6 };
            Console.WriteLine("Enter the index to be displayed:");
            int n = int.Parse(Console.ReadLine());
            if (n > arr.Length)
            {
                 try
                 {
                     throw new IndexOutOfRangeException("Invalid number");
                 }
                 catch
                 {
                     Console.WriteLine("Excetion Handled");
                 }
            }
            else
            {
                for(int i=0;i<n;i++)
                {
                    Console.Write(arr[i]+" ");
                }
            }
           
        }
        
    }
    //WAP to use catch / handle the IndexOutOfRangeException exception
    class Task2
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i <= 5; i++)
            {
                try
                {
                    sum += arr[i];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("..................");
            }
        }
    }
    //WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
    //and DivideByZeroException.
    class Task3
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6 };
            Console.WriteLine("Enter the index of number to be divide:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to be divided by:");
            int n = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(arr[n1]/n);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    //WAP to show checked exception and use multiple catch block with universal Exception handler.
    class Task4
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6 };
            Console.WriteLine("Enter the index of number to be divide:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to be divided by:");
            int n = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(arr[n1] / n);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (IndexOutOfRangeException e1)
            {
                Console.WriteLine(e1.ToString());
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.ToString());
            }
        }
    }
    //WAP to check Exception handling with method overriding. Means, If super class method don’t 
    //declare exception then subclass overridden method can declare exception or not.
    class Circle
    {
        public virtual void Display()
        {
            int[] arr = { 2, 4, 6, 4, 5, 6 };

            Console.WriteLine(arr[5]);
        }
    }
    class Area:Circle
    {
        public override void Display()
        {
            int[] arr1 = { 3, 4, 56, 67, 89 };
            Console.WriteLine("Enter index to be displayed");
            int n = int.Parse(Console.ReadLine());
            if(n>arr1.Length)
            {
                try
                {
                    throw new Exception();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine(arr1[n]);
            }
            base.Display();
        }
    }
    class CircleDetails
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            a.Display();
        }
    }

    //WAP to create custom Exception and show use of throw keyword
    class PasswordException:SystemException
    {
        public PasswordException()
        {
            Console.WriteLine("Password is smaller than five characters");
        }
    }
    class Password
    {
        public static void check(string s)
        {
            if(s.Length<5)
            {
                throw new PasswordException();
            }
            else
            {
                Console.WriteLine("Valid Password");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password:");
            string str = Console.ReadLine();
            try
            {
                Password.check(str);
            }
            catch
            {
                Console.WriteLine("Handled");
            }
        }
    }
}
