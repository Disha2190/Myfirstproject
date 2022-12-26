using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction.Interface
{
    interface IDrawable1
    {
        static int x = 90;  
        void Draw();
    }
    interface IPrintable
    {
        void Print();
    }
    class Shape1 : IDrawable1,IPrintable
    {
        public void Draw()
        {
            Console.WriteLine("Shape Drawing......."+IDrawable1.x);
        }
        public void Print()
        {
            Console.WriteLine("Shape printing done");
        }
    }
    class InterfaceDemo1
    {
        static void Main(string[] args)
        {
            IDrawable1 d = new Shape1();
            d.Draw();
            IPrintable p = new Shape1();
            p.Print();
        }
    }
}
