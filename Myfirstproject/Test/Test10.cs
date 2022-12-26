using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class ListSort
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                56,34,67,74,69,41,85
            };
            foreach (int x in li)
            {
                Console.Write(x + " ");
            }
            for (int i=0;i<li.Count;i++)
            {
                for(int j=i+1;j<li.Count;j++)
                {
                    if(li[i]<li[j])
                    {
                        int t = li[i];
                        li[i] = li[j];
                        li[j] = t;
                    }
                }
            }
            Console.WriteLine("");
            foreach(int x in li)
            {
                Console.Write(x+" ");
            }
        }
    }
    class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Pune",
                "mumbai",
                "banglore",
                "Pune",
                "Pune",
                "nasik",
                "mumbai"
            };
            foreach(string x in li)
            {
                Console.WriteLine(x);
            }
            for(int i=0;i<=li.Count;i++)
            {
                for(int j=i+1;j<li.Count;j++)
                {
                    if(li[i].Contains(li[j]))
                    {
                        li.Remove(li[j]);
                    }
                }
            }
            Console.WriteLine(".....................................");
            foreach(var x in li)
            {
                Console.WriteLine(x);
            }
        }
    }
    class ListTask
    {
        static void main(String[] args)
        {
            List<String> list1 = new List<String>();
            list1.Add("Me");
            list1.Add("You");
            list1.Add("He");
            list1.Add("She");
            list1.Add("It");
            List<String> list2 = new List<String>();
            list2.Add("You");
            foreach (String temp in list1)
            {
                Console.WriteLine(temp + " " );
            }
        }

    }
    /*WAP to create a List<Emp> and search for Emp object whose	
    Empno=10 and delete all the records whose dept is same as
    empno 10. 
    Emp [Empno,ename,Dept d]
    Dept [did,dname]
*/
    class Department
    {
        public int did;
        public string dname;
        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
    }
    class Employee3
    {
        public int empno;
        public string ename;
        public Department dp;
        public Employee3(int empno,string ename, Department dp)
        {
            this.empno = empno;
            this.ename = ename;
            this.dp = dp;
        }
    }
    class Employee3Details
    {
        static void Main(string[] args)
        {
            List<Employee3> li = new List<Employee3>();
            li.Add(new Employee3(10, "Aniket", new Department(110, "HR")));
            li.Add(new Employee3(16, "nikhil", new Department(121, "Sales")));
            li.Add(new Employee3(15, "Rohan", new Department(145, "HR")));
            li.Add(new Employee3(10, "mohit", new Department(106, "Sales")));
            li.Add(new Employee3(12, "akash", new Department(201, "RND")));
            for(int i=0;i<li.Count;i++)
            {
                if(li[i].empno.Equals(10))
                {
                    li.Remove(li[i]);
                }
            }
            foreach(var x in li)
            {
                Console.WriteLine(x.empno+" "+x.ename+" "+x.dp.did+" "+x.dp.dname);
            }
        }
    }
    /* Consider an List of Movie						
    Movie has (int movieid, String moviename, List<String> actor)
    Find “Amitabh bachchan has acted in how many movies
    */
    class Movie
    {
        public int movieid;
        public string moviename;
        public List<string> actor;
        public Movie(int movieid,string moviename,List<string> actor)
        {
            this.movieid = movieid;
            this.moviename = moviename;
            this.actor = actor;
        }
    }
    class MovieActor
    {
        static void Main(string[] args)
        {
            List<Movie> m = new List<Movie>();
            m.Add(new Movie(111, "Goodbye", new List<string>() { "Amitab Bachchan", "Rashmika Mandana" }));
            m.Add(new Movie(112, " Drishyam", new List<string>() { "Ajay Devgan" }));
            m.Add(new Movie(113, "Piku", new List<string>() { "Amitab Bachchan", "Deepika Padukon" }));
            m.Add(new Movie(114, " Runway34", new List<string>() { "Amitab Bachchan", "Ajay Devgan" }));
            int count = 0;
            foreach(Movie x in m)
            {
                if(x.actor.Contains("Amitab Bachchan"))
                {
                    count++;
                }
            }
            Console.WriteLine("Total acted movies: "+count);
        }
    }
    /*Write a program to find all pairs of elements in an integer array whose sum is equal to a given number?									
        Input Array : [4, 6, 5, -10, 8, 5, 20]
        InputNumber:10
        Pairs of elements whose sum is 10 are :
        4 + 6 = 10
        5 + 5 = 10
           -10 + 20 = 10
    */
    class SumNum
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 5, -10, 8, 5, 20 };
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]+arr[j]==n)
                    {
                        Console.WriteLine(arr[i]+"+"+arr[j]+"="+n);
                    }
                }
            }
        }
    }

    /*A Pen contains variables Refill, capLength and brand. Refill has variables
     inkColor, length and Nib (tip). Nib has variables materialType and width. Create
    a Java class structure for above. Write a main method which sets values in all the variables
    using setter methods and prints all the variables using getter methods. (consider getter,setter are present
    in all classes only write main method)	
    */
    class Tip
    {
        public string MaterialType { get; set; }
        public float Width { get; set; }
        public Tip(string Mtype, float width)
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

        public Refill(string IColor, int length, Tip tip)
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
            p.Refill = new Refill("Red", 15, new Tip("Plastic", 0.5f));
            p.DisplayPen();
        }
    }
    /*  //A Pen contains variables Refill, capLength and brand. Refill has variables
    //inkColor, length and Nib(tip). Nib has variables materialType and width.Create
    //a Java class structure for above.Write a main method which sets values in all the variables
    //using setter methods and prints all the variables using getter methods. 
    //(consider getter, setter are present in all classes only write main method)
    class Nib
    {
        string materialType;
        double width;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public void DisplayNib()
        {
            Console.WriteLine("Nib Details : \nMaterial Type = " + MaterialType + "\nWidth = " + Width);
        }
    }
    class Refil
    {
        string inkColor;
        double length;
        Nib nib;
        public string InkColor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public void DisplayRefil()
        {
            Console.WriteLine("Refill Details : \nInk Color = " + InkColor + "\nLength = " + Length);
            Nib.DisplayNib();
        }
    }
    class Pen1
    {
        Refil refil;
        double capLength;
        string brand;

        public Refil Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public double CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public void DisplayPen()
        {
            Console.WriteLine("Pen Details : \nCaplength = " + CapLength + "\nBrand = " + Brand);
            Refil.DisplayRefil();
        }
    }

    class Structure
    {
        static void Main(string[] args)
        {
            Pen1 p = new Pen1();
            p.CapLength = 4.5;
            p.Brand = "Cello";
            p.Refil = new Refil();
            p.Refil.InkColor = "Red";
            p.Refil.Length = 8.5;
            p.Refil.Nib = new Nib();
            p.Refil.Nib.MaterialType = "Plastic";
            p.Refil.Nib.Width = 0.8;

            p.DisplayPen();
        }
    }*/
}
