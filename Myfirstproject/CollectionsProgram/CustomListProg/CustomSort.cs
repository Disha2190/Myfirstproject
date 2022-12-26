using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Car1
    {
        public int model;
        public string cname;
        public int price;
        public Car1(int model,string cname,int price)
        {
            this.model = model;
            this.cname = cname;
            this.price = price;
        }
    }
    class CustomSort
    {
        static void Main(string[] args)
        {
            List<Car1> li = new List<Car1>();
            li.Add(new Car1(234, "Audi", 8900000));
            li.Add(new Car1(123, "BMW", 7900000));
            li.Add(new Car1(1111, "Santro", 5900000));
            li.Add(new Car1(576, "Porche", 9900000));
            foreach(var c in li)
            {
                Console.WriteLine(c.model+" "+c.cname+" "+c.price);
            }
            Console.WriteLine("....................................");
            li.Sort(new SortbyPrice());
            //li.Sort(new SortbyModel());
            foreach (var c in li)
            {
                Console.WriteLine(c.model + " " + c.cname + " " + c.price);
            }
        }

    }
    class SortbyModel:IComparer<Car1>
    {
        int IComparer<Car1>.Compare(Car1 x, Car1 y)
        {
            return x.model - y.model;
        }
    }
    class SortbyName:IComparer<Car1>
    {
        int IComparer<Car1>.Compare(Car1 x, Car1 y)
        {
            return y.cname.CompareTo(x.cname);
        }
    }
    class SortbyPrice:IComparer<Car1>
    {
        int IComparer<Car1>.Compare(Car1 x, Car1 y)
        {
            if(x.price==y.price)
            {
                return y.model - x.model;
            }
            return x.price - y.price;
        }
    }
}
