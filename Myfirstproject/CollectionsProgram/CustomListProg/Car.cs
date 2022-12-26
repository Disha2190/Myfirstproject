using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Car:IComparable
    {
        public int modelNo;
        public string modelname;
        public string carname;
        public int carprice;
        public string carcolor;
        public Car(int modelNo, string modelname, string carname, int carprice, string carcolor)
        {
            this.modelNo = modelNo;
            this.modelname = modelname;
            this.carname = carname;
            this.carprice = carprice;
            this.carcolor = carcolor;
        }
        public int CompareTo(Object obj)
        {
            Car c = (Car) obj;
            if(this.carprice==c.carprice)
            {
                if(this.carname==c.carname)
                {
                    if(this.modelNo==c.modelNo)
                    {
                        return this.modelNo - c.modelNo;
                    }
                    else
                    {
                        return c.modelNo - this.modelNo;
                    }
                }
                else
                {
                    return c.carname.CompareTo(this.carname);
                }
            }
            else
            {
                return c.carprice - this.carprice;
            }
        }
    }
    class CarDetails
    {
        static void Main(string[] args)
        {
            List<Car> li = new List<Car>();
            li.Add(new Car(101, "Thar", "Mahindra", 1300000, "Black"));
            li.Add(new Car(102, "Innova Crystal", "Toyota", 1800000, "White"));
            li.Add(new Car(103, "Xuv700", "Mahindra", 1300000, "Blue"));
            li.Add(new Car(104, "Fortune", "Toyota", 3200000, "Black"));
            li.Add(new Car(105, "Nexon", "Tata", 700000, "Red"));
            foreach(Car c1 in li)
            {
                Console.WriteLine(c1.modelNo+" "+c1.modelname+" "+c1.carname+" "+c1.carprice+" "+c1.carcolor);
            }
            Console.WriteLine("...............................................................................");
            li.Sort();
            foreach(Car c1 in li)
            {
                Console.WriteLine(c1.modelNo + " " + c1.modelname + " " + c1.carname + " " + c1.carprice + " " + c1.carcolor);
            }
        }
    }
}
