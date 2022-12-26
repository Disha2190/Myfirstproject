using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Parent1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child1:Parent1
    {
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Child");
        }
    }
    class OverridingDemo1
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.Show();
        }
    }
}
