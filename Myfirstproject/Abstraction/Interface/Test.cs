using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction.Interface
{
    interface IMoveable
    {
        void Move();
    }
    interface IRunnable:IMoveable
    {
        void Run();
    }
    class Car:IRunnable
    {
        public void Move()
        {
            Console.WriteLine("Car is Moving.....");
        }
        public void Run()
        {
            Console.WriteLine("Car is Running.....");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            IRunnable r = new Car();
            r.Move();
            r.Run();
        }
    }
}
