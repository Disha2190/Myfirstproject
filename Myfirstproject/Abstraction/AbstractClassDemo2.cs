using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{
    abstract class Animal
    {
        public abstract void Run();
    }
    abstract class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.....");
        }
    }
    class BabyDog : Dog
    {
        public override void Run()
        {
            Console.WriteLine("Baby Dog is running.....");
        }
    }
    class AbstractClassDemo2
    {
        static void Main(string[] args)
        {
            Dog d = new BabyDog();
            d.Bark();
            d.Run();
        }
    }
}
