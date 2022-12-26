using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction.Interface
{
    abstract class Input
    {
        public int x = 10;
        public abstract void Show();
    }
    interface IProgram
    {
        static int y = 20;
        void Add();
    }
    class Calculate:Input,IProgram
    {
        int sum;
        public void Add()
        {
            sum = x + IProgram.y;
        }
        public override void Show()
        {
            Console.WriteLine("Addition: "+sum);
        }
    }
    class Addition
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.Add();
            c.Show();
        }
    }
}
