using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction.Interface
{
    interface IDrawable
    {
        static int x = 90;  //In Interface variable are always declared as Static
        void Draw();
    }
    class Shape:IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Shape Drawing.......");
        }
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IDrawable d = new Shape();
            d.Draw();
        }
    }
}
