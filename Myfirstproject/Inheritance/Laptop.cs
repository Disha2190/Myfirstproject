using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Laptop
    {
        //base for instance variable

        public string ram = "4GB";
    }
    class Dell:Laptop
    {
        public string ram = "16GB";
        public void Show()
        {
            Console.WriteLine(ram+" "+base.ram);
        }
    }

    class BasicDemo
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
            d.Show();
        }
    }
   
    
    class Laptop1
    {
        //base
        public string ram = "4GB";
        public void Show()
        {
            Console.WriteLine("Laptop");
        }
    }
    class Dell1 : Laptop1
    {
        public string ram = "16GB";
        public void Show()
        {
            Console.WriteLine(ram + " " + base.ram);
            base.Show();
        }
    }

    class BasicDemo1
    {
        static void Main(string[] args)
        {
            Dell1 d = new Dell1();
            d.Show();
        }
    }


    // Parametrised Constructor using base 
    class Laptop2
    {
        public Laptop2(int x)
        {
            Console.WriteLine("Laptop"+x);
        }
    }
    class Dell2 : Laptop2
    {
        
        public Dell2():base(100)
        {
            Console.WriteLine("Dell");
        }
    }

    class BasicDemo2
    {
        static void Main(string[] args)
        {
            Dell2 d = new Dell2();
        }
    }
}
