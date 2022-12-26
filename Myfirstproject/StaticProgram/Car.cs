using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StaticProgram
{
    class Car
    {
        //Create a class Car with String model and int totalCarSold as static variable in main() method.
        //Change the value of variable by class name then Print it.
        //Create two object of Car class and change value of static variable by 1st object and print it by accessing 2nd object.

        static string Model;
        static int TotalCarSold;

        public void Display()
        {
            Console.WriteLine("Model: "+Model+"\nTotal Car Sold:"+TotalCarSold);
        }
        public Car()
        {
        }
        public Car(string model,int totalCarSold)
        {
            Model = model;
            TotalCarSold = totalCarSold;
        }
        static void Main(string[] args)
        {
            Car c1 = new Car("Porche", 200);
            Car c2 = new Car();
            c2.Display();
        }
    }
    //See if you can overload static method, by using static keyword for 2nd overloaded method
    //and without using static keyword.
    class Addition
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine("Addition: "+(x+y));
        }
        public void Add(double x,int y)
        {
            Console.WriteLine("Addition: "+(x+y));
        }
        static void Main(string[] args)
        {
            Addition.Add(5, 5);
            Addition a = new Addition();
            a.Add(2.2, 5);
        }
    }
    //Write a method to accept variable no of integers.
    //Method should find sum of all the integers and display the result.
    class Sum
    {
        public static void Add(params int[] no)
        {
            int sum = 0;
            foreach(int n in no)
            {
                sum += n;
            }
            Console.WriteLine("Addition is: "+sum);
        }
        static void Main(string[] args)
        {
            Sum.Add(3, 4, 2, 5, 7);
        }
    }
    //WAP to check whether you can inherit static variable of Parent class in Child class
    //WAP to check whether you can inherit static method of Parent class in Child class
    class Parent
    {
        public static int x = 10;
        public static void show()
        {
            Console.WriteLine(x);
        }
    }
    class Child:Parent
    {
        int y = 4;
        public void Add()
        {
            Console.WriteLine(y+x);
            show();
        }
    }
    class Inherit
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Add();
        }
    }
}
