using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Containments
{
    class Address
    {
        int pincode;
        string city;
        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void DisplayAddress()
        {
            Console.WriteLine(pincode+" "+city);
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;
        public Person(int id,string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }public void DisplayPerson()
        {
            Console.WriteLine(id+" "+name+" ");

            adr.DisplayAddress();
        }
        static void Main(string[] args)
        {
            Person p = new Person(108, "Amit", new Address(123, "Pune"));
            p.DisplayPerson();
        }
    }
}
