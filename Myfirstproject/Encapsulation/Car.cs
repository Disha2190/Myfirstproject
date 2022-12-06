using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class Car
    {
        String model_no;
        String name;
        float price;
        String colour;

        public String Model_no
        {
            set
            {
                model_no = value;
            }
            get
            {
                return model_no;
            }
        }
        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public float Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public String Colour
        {
            set
            {
                colour = value;
            }
            get
            {
                return colour;
            }
        }
            
    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model_no = "A12B43";
            c.Name = "BMW";
            c.Price = 6600000;
            c.Colour = "Black";

            Console.WriteLine("Model No.: "+c.Model_no);
            Console.WriteLine("Name: "+c.Name);
            Console.WriteLine("Price: "+c.Price);
            Console.WriteLine("Colour: "+c.Colour);
        }
    }
}
