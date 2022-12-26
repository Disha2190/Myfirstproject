using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Animal
    {
        public int leg = 4;
    }
    class Dog:Animal
    {
        void Show()
        {
            Console.WriteLine("Dog has "+leg+" legs");
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Show();
        }
    }
}
