using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs
{
    class AccessModifierDemo
    {
        private int x = 10;
        internal int y = 30;
        protected int z = 40;
        static void Main(string[] args)
        {
            AccessModifierDemo d = new AccessModifierDemo();
            Console.WriteLine(d.x);
            Console.WriteLine(d.y);
            Console.WriteLine(d.z);
        }
    }

    class AccessDemo:AccessModifierDemo
    {
        static void Main(string[] args)
        {
            AccessModifierDemo access = new AccessModifierDemo();
            //Console.WriteLine(access.x); //private is not accessible
            Console.WriteLine(access.y);
            //Console.WriteLine(access.z);

            AccessDemo a = new AccessDemo();
            Console.WriteLine(a.z);
        }
    }
}
