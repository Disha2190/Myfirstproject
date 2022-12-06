using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class UseOfThisKeyword
    {
        int a, b, sum;
        public UseOfThisKeyword()
        {
            a = 0;
            b = 0;
            sum = a + b;
        }
        public UseOfThisKeyword(int a)
        {
            Console.WriteLine("Single parameterised constructor called");
            this.a = a;
            this.b = a;
            sum = a + b;
        }
        public UseOfThisKeyword(int a,int b):this(a)
        {
            this.a = a;
            this.b = b;
        }
        public void PutInfo()
        {
            Console.WriteLine("Addition is: "+sum);
        }
        static void Main(string[] args)
        {
            UseOfThisKeyword obj = new UseOfThisKeyword();
            obj.PutInfo();
            obj = new UseOfThisKeyword(3);
            obj.PutInfo();
            obj = new UseOfThisKeyword(10,3);
            obj.PutInfo();
        }
    }
    class UseOfThisKeyword1
    {
        int a, b;
        public UseOfThisKeyword1()
        {
            Console.WriteLine("No paramaterised constructor");
        }
        public UseOfThisKeyword1(int a):this()
        {
            this.a = a;
            Console.WriteLine(a);

        }
        public UseOfThisKeyword1(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(a+" "+b);
        }
        static void Main(string[] args)
        {
            UseOfThisKeyword1 obj = new UseOfThisKeyword1(2,5);
        }
    }
}
