using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class StaticVariable
    {
        static int no;
        int x;
        public void GetNo()
        {
            Console.WriteLine("Static value is: "+no);
        }
        public void PutData(int n)
        {
            x = n;
            no++;
        }
        public void GetData()
        {
            Console.WriteLine("Instance Variable x: "+x);
        }
        static void Main(string[] args)
        {
            StaticVariable obj1 = new StaticVariable();
            StaticVariable obj2 = new StaticVariable();
            StaticVariable obj3 = new StaticVariable();

            obj1.GetNo();
            obj2.GetNo();
            obj3.GetNo();

            obj1.PutData(100);
            obj2.PutData(200);
            obj3.PutData(300);

            obj1.GetData();
            obj2.GetData();
            obj3.GetData();
        }
    }
    class StaticVariable1
    {
        static int no;
        int x;
        public void GetNo()
        {
            Console.WriteLine("Static value is: "+no);
        }
        public void PutData(int n)
        {
            x = n;
            no++;
        }
        public static void ShowNo()
        {
            Console.WriteLine("No of objects created is "+no);
        }
        public void GetData()
        {
            Console.WriteLine("Instance Variable x: " + x);
        }
        static void Main(string[] args)
        {
            StaticVariable1 obj1 = new StaticVariable1();
            StaticVariable1 obj2 = new StaticVariable1();

            obj1.PutData(100);
            obj2.PutData(200);
            StaticVariable1.ShowNo();

            StaticVariable1 obj3 = new StaticVariable1();
            
            obj3.PutData(300);
            StaticVariable1.ShowNo();

            StaticVariable1 obj4 = new StaticVariable1();
            obj4.PutData(400);
            StaticVariable1.ShowNo();
        }
    }
    class Circle
    {
        static double PI = 3.14;
        double r;
        static int c;
        public Circle()
        {
            c++;
        }
        public Circle(double pI,double r)
        {
            PI = pI;
            this.r = r;
            c++;
        }
        public static int ReturnObjectCount()
        {
            return c;
        }
        public double Area()
        {
            double a = PI * r * r;
            return a;
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine("Object created are: "+Circle.ReturnObjectCount());
            Circle c1 = new Circle(3.14, 3.4);
            Console.WriteLine("Object created are: " + Circle.ReturnObjectCount());
            Console.WriteLine("Area is: "+c1.Area());
            Circle c2 = new Circle(3.14, 5.4);
            Console.WriteLine("Area is: " + c2.Area());
            Console.WriteLine("Object created are: " + Circle.ReturnObjectCount());
            Circle c4 = new Circle();
            Console.WriteLine("Object created are: " + Circle.ReturnObjectCount());

        }
    }
}
