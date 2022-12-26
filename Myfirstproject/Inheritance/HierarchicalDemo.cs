using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Vehecial
    {
        public int wheels;
        public void Run()
        {
            Console.WriteLine("Vehecial is running");
        }
    }
    class Car:Vehecial
    {
        public void ShowCar()
        {
            wheels = 4;
            Console.WriteLine("Car is running on "+wheels+" wheels");
        }
    }
    class Truck:Vehecial
    {
        public void ShowTruck()
        {
            wheels = 8;
            Console.WriteLine("Truck has "+wheels+" wheels");
        }
    }
    class HierarchicalDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Run();
            c.ShowCar();
            Truck t = new Truck();
            t.Run();
            t.ShowTruck();
        }
    }
}
