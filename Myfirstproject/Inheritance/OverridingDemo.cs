using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("Child");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            /*Child c = new Child();
            c.Show();*/

            Parent p = new Child();
            p.Show();
        }
    }
  /* class Parent1
    {
        //Static method can not be override
        public static void Show()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child1 : Parent1
    {
        public static void Show()
        {
            Console.WriteLine("Child");
            //base.Show();
        }
    }
    class OverridingDemo1
    {
        static void Main(string[] args)
        {
            Child1 c = new Child1();
            c.Show();

            Parent1 p = new Child1();
            p.Show();
        }
    }*/


}
