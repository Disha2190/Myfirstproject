using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.DictionaryProg
{
 
    class Car
    {
        public int modelno;
        public string cname;
        public Car(int modelNo, string cName)
        {
            this.modelno = modelNo;
            this.cname = cName;
        }
    }
    class EqualChec : IEqualityComparer<Car>
    {
        bool IEqualityComparer<Car>.Equals(Car x, Car y)
        {
            return x.modelno == y.modelno;
        }
        int IEqualityComparer<Car>.GetHashCode(Car obj)
        {
            return obj.modelno;
        }
    }

    class CustomDictCar
    {
        static void Main(string[] args)
        {
            Dictionary<Car, int> dm = new Dictionary<Car, int>(new EqualChec());

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Enter car no.");
                int mn = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter car Name");
                string cname = Console.ReadLine();

                Console.WriteLine("Enter Price");
                int price = int.Parse(Console.ReadLine());
                Car c = new Car(mn, cname);
                if (dm.ContainsKey(c))
                {
                    Console.WriteLine("Already Present");
                }
                else
                {
                    dm.Add(c, price);
                }
            }

            foreach (KeyValuePair<Car, int> kv in dm)
            {
                Car c = kv.Key;
                Console.WriteLine(c.modelno + "  " + c.cname + "  " + kv.Value);
            }
        }
    }
}
