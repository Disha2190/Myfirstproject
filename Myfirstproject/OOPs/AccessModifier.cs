using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs
{
    class AccessModifier
    {
        private int x=10;
        internal int y=20;
        protected int z=30;
        public int u=40;

        private void Access1()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(u);
        }
        internal void Access2()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(u);
        }
        
        protected void Access3()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(u);
        }
        public void Access4()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(u);
        }
        static void Main(string[] args)
        {
            AccessModifier ac = new AccessModifier();
            ac.Access1();
            ac.Access2();
            ac.Access3();
            ac.Access4();
        }
    }

    class AccessModifier1
    {
        static void Main(string[] args)
        {
            AccessModifier a = new AccessModifier();
            //a.Access1(); //Private
            a.Access2();
            //a.Access3(); //Protected
            a.Access4();
        }
    }
}
