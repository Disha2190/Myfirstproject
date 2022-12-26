
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myfirstproject.CollectionsProgram
{
    //WAP to add elements to and print content of it where Integer is used.
    //In the second arraylist String is used.
    class Display
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1, 48,67,44,75
            };
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
            ArrayList a2 = new ArrayList()
            {
                "Mumbai","Delhi","Pune","Nasik"
            };
            foreach(var x in a2)
            {
                Console.WriteLine(x);
            }
        }
    }

    //WAP to add elements to arraylist  0th location
    //keep Integer, 1st location String now print each element and display contents.
    class AddElement
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1,"Pune","Mumbai",3,4
            };
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
            a1.Insert(0, 45);
            a1.Insert(1, "Goa");
            Console.WriteLine("...................");
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
        }
    }

    //WAP to create a new ArrayList, add some colors (string) and print the collection.
    class Colors
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1,2,3,4
            };
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
            a1.Add("Blue");
            a1.Add("Black");
            a1.Add("White");
            Console.WriteLine("............................");
            foreach (var x in a1)
            {
                Console.WriteLine(x);
            }
        }
    }

    //WAP of swap two elements in an ArrayList
    class Swap
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                1,3,"Delhi",45,67
            };
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("........................");
            var temp = a1[2];
            a1[2] = a1[1];
            a1[1] = temp;
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
        }
    }

    //WAP to replace the second element of an ArrayList with the specified element
    class Replace
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList()
            {
                47,74,96,48,25
            };
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("..............................");
            a1.RemoveAt(2);
            a1.Insert(2, 100);
            foreach(var x in a1)
            {
                Console.WriteLine(x);
            }
        }
    }

    //WAP to create a List of Students and iterate over it.
    class Students1
    {
        public int id;
        public string name;
        public Students1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class StudentDetails
    {
        static void Main(string[] args)
        {
            List<Students1> s = new List<Students1>();
            s.Add(new Students1(1, "Harry"));
            s.Add(new Students1(2, "Peter"));
            s.Add(new Students1(3, "John"));
            s.Add(new Students1(4, "Jack"));
            foreach(Students1 x in s)
            {
                Console.WriteLine(x.id+" "+x.name);
            }
        }
    }
    //WAP to convert an array to ArrayList
    class ConvArryToArryList
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            ArrayList al = new ArrayList();
            for(int i=0;i<arr.Length;i++)
            {
                al.Add(arr[i]);
            }
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
        }
    }
    //WAP to print list in reverse order 
    class Reverse
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            for(int i=li.Count;i>0;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    //WAP to sort the elements of List that contain String objects. Print ArrayList.
    class SortString
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Pune","Mumbai","Nasik","Goa","Delhi"
            };
            foreach(string x in li)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(".......................");
            li.Sort();
            foreach (string x in li)
            {
                Console.WriteLine(x);
            }
        }
    }
    //WAP to create a class Employee with (name, designation and age).Now create and
    //add Employee objects elements to Arraylist. Sort the ArrayList by age in descending order
    //and print ArrayList.
    class Employee2:IComparable
    {
        public string name;
        public string designation;
        public int age;
        public Employee2(string name,string designation,int age)
        {
            this.name = name;
            this.designation = designation;
            this.age = age;
        }
        public int CompareTo(Object obj)
        {
            Employee2 E = (Employee2)obj;
            return E.age - this.age;
        }
    }
    class Employee2Details
    {
        static void Main(string[] args)
        {
            List<Employee2> e = new List<Employee2>();
            e.Add(new Employee2("Harry", "Architect", 23));
            e.Add(new Employee2("John", "Builder", 27));
            e.Add(new Employee2("Peter", "Engineer", 21));
            e.Add(new Employee2("Jack", "Designer", 26));
            foreach(Employee2 ep in e)
            {
                Console.WriteLine(ep.name+" "+ep.designation+" "+ep.age);
            }
            Console.WriteLine("..........................................");
            e.Sort();
            foreach (Employee2 ep in e)
            {
                Console.WriteLine(ep.name + " " + ep.designation + " " + ep.age);
            }
        }
    }

    //11.	WAP to add elements to a Hashtable and print content of it. Use int as Key and String as Value.
    //In the second Hashtable add elements of String type as Key and Int as Value.
    class HashTab
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1,"Pune" },
                {2,"Mumbai" },
                {3,"Nasik" },
                {4,"Delhi" }
            };
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            Console.WriteLine("...................................");
            Hashtable ht1 = new Hashtable()
            {
                {"Pune",1 },
                { "Mumbai",2 },
                {"Nasik",3 },
                {"Delhi",4 }
            };
            foreach (DictionaryEntry kv in ht1)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }

    //WAP to get only the Keys from a Hashtable
    class Hastabl1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1,"Pune" },
                {2,"Mumbai" },
                {3,"Nasik" },
                {4,"Delhi" }
            };
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key);
            }
        }
    }

    //WAP to get only the Values from a Hashtable
    class Hastabl2
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1,"Pune" },
                {2,"Mumbai" },
                {3,"Nasik" },
                {4,"Delhi" }
            };
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Value);
            }
        }
    }

    //WAP to create a  Hashtable  using Custom class as key and any other object as value
    class Hastabl3
    {
        static void Main(string[] args)
        {

        }
    }
    //15.	WAP to create a Queue to add 5 objects and also remove the first two and iterate over it. 
//16.	WAP to create a Stack to store some objects and iterate over it.Also show use of push,pop,peek

}
