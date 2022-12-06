using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ObjectAsParameter
    {
        int no,sum;
        public ObjectAsParameter(int no)
        {
            this.no = no;
        }
        public void Add(ObjectAsParameter obj)
        {
            sum = this.no + obj.no;
        }
        public void PutInfo()
        {
            Console.WriteLine("Addition of two objects is: "+sum);
        }
        static void Main(string[] args)
        {
            ObjectAsParameter obj1 = new ObjectAsParameter(30);
            ObjectAsParameter obj2 = new ObjectAsParameter(20);
            obj1.Add(obj2);
            obj1.PutInfo();
            obj2.PutInfo();
        }
    }
    class ObjectAsParameter1
    {
        int no, sum;
        public ObjectAsParameter1(int no)
        {
            this.no = no;
        }
        public void Add(ObjectAsParameter1 obj)
        {
            sum = this.no + obj.no;
        }
        public bool Compare(ObjectAsParameter1 obj)
        {
            if (no > obj.no)
                return true;
            else
                return false;
        }
        public void PutInfo()
        {
            Console.WriteLine("Addition of two objects is: " + sum);
        }
        static void Main(string[] args)
        {
            ObjectAsParameter1 obj1 = new ObjectAsParameter1(30);
            ObjectAsParameter1 obj2 = new ObjectAsParameter1(20);
            if(obj1.Compare(obj2))
                Console.WriteLine("First object is greatest");
            else
                Console.WriteLine("Second object is greatest");
        }
    }
}
