using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class DemoConstructor
    {
        int id, age;
        string name;
        public DemoConstructor()
        {
            this.id = 0;
            this.name = "";
            this.age = 0;
        }
        public DemoConstructor(int id,string name,int age)
        {
            this.id=id;
            this.name=name;
            this.age=age;
        }
        public DemoConstructor(DemoConstructor s)
        {
            this.id = s.id;
            this.name =s. name;
            this.age = s.age;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {id} Name: {name} Age:{age}");
        }
        static void Main(string[] args)
        {
            DemoConstructor obj = new DemoConstructor(); //Default Constructor
            obj.Display();
            DemoConstructor obj1 = new DemoConstructor(1,"AAA",89); //Paramaterised Constructor
            obj1.Display();
            DemoConstructor obj2 = obj1; //Copy Constructor
            obj2.Display();
        }
    }
}
