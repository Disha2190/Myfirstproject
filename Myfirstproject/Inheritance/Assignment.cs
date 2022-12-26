using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    /*1.	Create class Teacher with following
	Tid,Tname,MobileNo
	Parameterized constructor
	abstract void salary()
•	Create class Hourlybased which is derived class from teacher with fields
	 rate_per_hr,
	int hrs;
	Parameterized constructor
	void salary()
•	Create class SalaryBased which is derived class from teacher
	with fields
	 int salary;
	Parameterized constructor
	void salary()
	Write main to create objects of HourlyBased teacher and SalaryBased teacher and also call respective 
	salary method and also show runtime polymorphism*/

	public abstract class Teacher1
    {
		public int Tid;
		long MobileNo;
		public string Tname;
		public Teacher1(int Tid,long MobileNo,string Tname)
        {
			this.Tid = Tid;
			this.MobileNo = MobileNo;
			this.Tname = Tname;
        }
		public abstract void Salary();
    }

	public class Hourlybased:Teacher1
    {
		double rate_pr_hr;
		int hrs;
		public Hourlybased(double rate_pr_hr,int hrs):base(101, 8746597814,"Harry")
        {
			this.rate_pr_hr = rate_pr_hr;
			this.hrs = hrs;
        }
        public override void Salary()
        {
            Console.WriteLine("Rate per hr: "+rate_pr_hr+"\nHours: "+hrs);
        }
    }
	public class Salarybased:Teacher1
    {
		public int salary;
		public Salarybased(int salary) : base(102, 7985467895, "Peter")
		{ 
			this.salary = salary;
        }
        public sealed override void Salary()
        {
            Console.WriteLine("Salary: "+salary);
        }
	}
	class TeacherDetails
    {
        static void Main(string[] args)
        {
			Teacher1 t = new Hourlybased(875,3);
			t.Salary();
			Teacher1 t1 = new Salarybased(45000);
			t1.Salary();
		}
    }
	/*	A Pen contains variables Refill r, int capLength and  String brand. 
		Refill has variables inkColor, length and Nib (tip).
		Nib has variables materialType and width. 
		Create a Java class structure for above . 
		Write a main method which sets values in all the variables
		using setter methods and prints all the variables using getter methods. 
	*/
	
	class Tip
    {
		string materialtype;
		float width;
        public string MaterialType { get; set; }
        public float Width { get; set; }
		public void DisplayTip()
        {
            Console.WriteLine("Material Type: "+MaterialType+"/nWidth: "+Width);
        }
    }
	class Refill
	{
		string inkcolor;
		int length;
		Tip t;
        public string InkColor { get; set; }
        public int Length { get; set; }
		public void DisplayRefill()
        {
            Console.WriteLine("InkColor: "+InkColor+"\nLength: "+Length);
			t.DisplayTip();
        }
    }
	class Pen
    {
		int capLength;
		string brand;
		Refill r;
        public int CapLength { get; set; }
        public string Brand { get; set; }
		public void DisplayPen()
        {
            Console.WriteLine("Cap Length: "+CapLength+"\nBrand: "+Brand);
			r.DisplayRefill();
        }
    }
	class PenDetails
    {
        static void Main(string[] args)
        {
			Pen p = new Pen();
			p.CapLength = 2;
			p.Brand = "Cello";
			Refill re = new Refill();
			re.InkColor = "Black";
			re.Length = 3;
			Tip ti = new Tip();
			ti.MaterialType = "aaa";
			ti.Width = 2.2f;
			p.DisplayPen();
        }
    }
	/*
	 class Tip
    {
        public string MaterialType { get; set; }
        public float Width { get; set; }
        public Tip(string Mtype,float width)
        {
            this.MaterialType = Mtype;
            this.Width = width;
        }

        public void DisplayTip()
        {
            Console.WriteLine("Material Type: " + MaterialType + "\nWidth: " + Width);
        }
    }
    class Refill
    {
        public string InkColor { get; set; }
        public int Length { get; set; }
        public Tip Tip { get; set; }

        public Refill(string IColor,int length,Tip tip)
        {
            this.InkColor = IColor;
            this.Length = length;
            this.Tip = tip;
        }
        public void DisplayRefill()
        {
            Console.WriteLine("InkColor: " + InkColor + "\nLength: " + Length);
            Tip.DisplayTip();
        }
    }
    class Pen
    {
        public int CapLength { get; set; }
        public string Brand { get; set; }
        public Refill Refill { get; set; }
        public void DisplayPen()
        {
            Console.WriteLine("Cap Length: " + CapLength + "\nBrand: " + Brand);
            Refill.DisplayRefill();
        }
    }
    class PenDetails
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.CapLength = 2;
            p.Brand = "Cello";
            p.Refill = new Refill("Red",15,new Tip("Plastic",0.5f));
            p.DisplayPen();
        }
    }
	 */



	/*Write a program to create 2 person objects .Take input or hardcode  for all  two person from console. 
	  Person class is as follows 
	 Person (int id, String name, Vehicle v )	Vehicle (int vid, String vname) 
*/
	class Vehicle
	{
		public int vid;
		public string vname;
		public Vehicle(int vid,string vname)
        {
			this.vid = vid;
			this.vname = vname;
        }
		public void Display()
        {
            Console.WriteLine("Vehicle Id: "+vid+"\nVehicle Name: "+vname);
        }
	}
	class Person3
    {
		public int id;
		public string name;
		Vehicle v;
		public Person3(int id,string name,Vehicle v)
        {
			this.id = id;
			this.name = name;
			this.v = v;
        }
		public void DisplayPerson()
        {
            Console.WriteLine("Id: "+id+"\nName: "+name);
			v.Display();
        }

    }
	class PerDetails
    {
        static void Main(string[] args)
        {
			Person3 p = new Person3(1,"Harry",new Vehicle(101,"Audi"));
			p.DisplayPerson();
        }
    }
	/*  Create interface Cake with a method declared as bake. Create 2 classes 
		Strawberry, BlackForest both implementing Cake interface.
	*/
	interface ICake
    {
		void Bake();
    }
	class Starwberry:ICake
    {
		public void Bake()
        {
            Console.WriteLine("Strawberry Cake");
        }
    }
	class BlackForest:ICake
    {
		public void Bake()
        {
            Console.WriteLine("Blackforest Cake");
        }
    }
	class Cake
    {
        static void Main(string[] args)
        {
			ICake c = new Starwberry();
			c.Bake();
			ICake c1 = new BlackForest();
			c1.Bake();
        }
    }
	/*	Create interface IceCream with method eat and Juice with method drink, 
		Create class Mastani which implements both interfaces. 
	 */
	interface IIceCream
    {
		void Eat();
    }
	interface IJuice
    {
		void Drink();
    }
	class Mastani:IIceCream,IJuice
    {
		public void Eat()
        {
            Console.WriteLine("Vanilla");
        }
		public void Drink()
        {
            Console.WriteLine("Apple Juice");
        }
    }
	class MastaniDetails
    {
        static void Main(string[] args)
        {
			IIceCream i = new Mastani();
			i.Eat();
			IJuice j = new Mastani();
			j.Drink();
        }
    }
	/*
	 Design a class to overload a function volume() as follows:  [2M]
	(i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the 
	formula:
	v = 4 / 3 × 22 / 7 × r3
	(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the 
	volume of a cylinder using the formula:
	v = 22 / 7 × r2 × h
	(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the 
	arguments, returns the volume of a cuboid using the formula:
	v = l × b × h
	*/
	class Formula
    {
		public static double Volume(double r)
        {
			double v = (4 / 3) * (22 / 7) * r * r * r;
			return v;
        }
		public static double Volume(double h,double r)
        {
			double v = (22 / 7) * r*r * h;
			return v;
		}
		public static double Volume(double l,double b,double h)
        {
			double v = l * b * h;
			return v;
		}
    }
	class Vol
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Formula.Volume(2.2));
			Console.WriteLine(Formula.Volume(2.1,2.3));
			Console.WriteLine(Formula.Volume(2.2,3.2,3.4));
		}
	}
	/*  Design class Order (int ordered,String Orderdate,Customer cust,Item item)
		Customer (int custid,String custname,Address address)
		Address( String addr1,city,int pincode)
		Item (int itemid,String itemname,int price)
		Write constructors,properties in respective classes.
	*/
	class Item
    {
		int itemid;
		string itemname;
		int price;
		public Item(int itemid,string itemname,int price)
        {
			this.itemid = itemid;
			this.itemname = itemname;
			this.price = price;
        }
		public void IDisplay()
        {
            Console.WriteLine(itemid+" "+itemname+" "+price);
        }
    }
	class Address
    {
		string addr1,city;
		int pincode;
		public Address(string addr1,string city,int pincode)
        {
			this.addr1 = addr1;
			this.pincode = pincode;
        }
		public void AddDisplay()
        {
            Console.WriteLine(addr1+" "+city+" "+pincode);
        }
    }
	class Customer
    {
		int custid;
		string custname;
		Address address;
		public Customer(int custid,string custname,Address address)
        {
			this.custid = custid;
			this.custname = custname;
			this.address = address;
        }
		public void CusDisplay()
        {
            Console.WriteLine(custid+" "+custname);
			address.AddDisplay();
        }
    }
	class Order
    {
		int ordered;
		String Orderdate;
		Customer cust;
		Item item;
		public Order(int ordered,string Orderdate,Customer cust,Item item)
        {
			this.ordered = ordered;
			this.Orderdate = Orderdate;
			this.cust = cust;
			this.item = item;
        }
		public void Display()
        {
            Console.WriteLine(+ordered+" "+Orderdate);
			cust.CusDisplay();
			item.IDisplay();
        }
	}
	class OrderDetails
    {
        static void Main(string[] args)
        {
			Order o = new Order(1, "12/02/2022", new Customer(102, "Harry", new Address("AAAA", "Delhi", 1234)), new Item(103, "Laptop", 70000));
			o.Display();
        }
    }
}
