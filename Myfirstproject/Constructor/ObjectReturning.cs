using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ObjectReturning
    {
        int no;
        public ObjectReturning()
        {
            this.no = 0;
        }
        public ObjectReturning(int no)
        {
            this.no = 0;
        }
        public void Display()
        {
            Console.WriteLine("The number is:"+no);
        }
        public ObjectReturning Add(ObjectReturning obj)
        {
            ObjectReturning temp = new ObjectReturning();
            temp.no = this.no + obj.no;
            return temp;
        }
        static void Main(string[] args)
        {
            ObjectReturning obj1 = new ObjectReturning(3);
            ObjectReturning obj2 = new ObjectReturning(5);
            ObjectReturning obj3 = obj1.Add(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();
        }
    }
    class ObjectReturning1
    {
        int no;
        public ObjectReturning1()
        {
            this.no = 0;
        }
        public ObjectReturning1(int no)
        {
            this.no = no;
        }
        public void Display()
        {
            Console.WriteLine("The number is:" + no);
        }
        public ObjectReturning1 Add(ObjectReturning1 obj)
        {
            ObjectReturning1 temp = new ObjectReturning1();
            temp.no = this.no + obj.no;
            return temp;
        }
        public ObjectReturning1 Compare(ObjectReturning1 obj)
        {
            ObjectReturning1 temp = new ObjectReturning1();
            if (this.no > obj.no)
                temp = this;
            else
                temp = obj;

            return temp;
        }
        static void Main(string[] args)
        {
            ObjectReturning1 obj1 = new ObjectReturning1(3);
            ObjectReturning1 obj2 = new ObjectReturning1(5);
            ObjectReturning1 obj3 = obj1.Add(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();
            Console.WriteLine("After Comparision:");
            obj3 = obj1.Compare(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();
        }
    }
}
