using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
  /*  sealed class Flower
    {

    }
    class Rose:Flower //can not inherit sealed class
    {

    }
    class SealedDemo
    {
        static void Main(string[] args)
        {

        }
    }*/

   /* class Flower
    {
        public virtual void MakeDecoration()
        {
            Console.WriteLine("Flower is used for Decoration:");
        }
    }
    class Rose : Flower
    {
        public sealed override void MakeDecoration()
        {
            //base.MakeDecoration();
            Console.WriteLine("Rose is used for Decoration");
        }
    }
    class RedRose:Rose
    {
        public override void MakeDecoration()  // Can not inherit Rose class as it is sealed
        {
            Console.WriteLine("Red Rose is used for Decoration");
        }
    }
    class SealedDemo
    {
        static void Main(string[] args)
        {
            Flower f = new Rose();
            f.MakeDecoration();
            Rose r = new RedRose();
            r.MakeDecoration();
        }
    }*/
}
