using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Animal1
    {
        public string food = "Omnivores";
        public void Show()
        {
            Console.WriteLine("Animal");
        }
    }
    class Tiger:Animal1
    {
        public string food = "Carnivores";
        public void Show()
        {
            base.Show();
            Console.WriteLine("Animals are: "+base.food);
            Console.WriteLine("Tigers are: "+food);
        }
    }
    class AnimalsDetails
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger();
            t.Show();
        }
    }
}
