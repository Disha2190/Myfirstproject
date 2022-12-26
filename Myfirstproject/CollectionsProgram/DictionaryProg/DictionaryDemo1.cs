using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Myfirstproject.CollectionsProgram.DictionaryProg
{
    class DictionaryDemo1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mybook = new Dictionary<int, string>();
            mybook.Add(5, "Pune");
            mybook.Add(7, "Mumbai");
            mybook.Add(4, "Goa");
            mybook.Add(1, "Pune");
            mybook.Add(6, "Nasik");
            mybook.Add(2, "Banglore");

            foreach(var data in mybook)
            {
                Console.WriteLine(data.Key+" "+data.Value);
            }
            Console.WriteLine("........................................");
            foreach(KeyValuePair<int,string>m in mybook)
            {
                Console.WriteLine(m.Key+"......"+m.Value);
            }
            Console.WriteLine("..........only key value.............");
            foreach(KeyValuePair<int,string>m in mybook)
            {
                Console.WriteLine(m.Value);
            }
            Console.WriteLine("..............."+mybook.Count+"........................");
            for(int i=0;i<mybook.Count;i++)
            {
                Console.WriteLine(mybook.ElementAt(i).Key+"    "+mybook.ElementAt(i).Value);
            }
            Console.WriteLine(".............................................");
            Console.WriteLine(mybook.ContainsKey(5));
            List<int> l = new List<int>(mybook.Keys);
            foreach(var x in l)
            {
                Console.WriteLine(x);
            }
        }
    }
}
