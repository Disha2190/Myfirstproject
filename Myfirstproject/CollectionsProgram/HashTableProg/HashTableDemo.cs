using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Myfirstproject.CollectionsProgram.HashTableProg
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            /*Hashtable ht = new Hashtable();
            ht.Add(1, "Yash");
            ht.Add(2, "Pune");
            ht.Add("1234", "Mumbai");*/

            Hashtable ht = new Hashtable()
            {
                { 1, "Yash" },
                { 2, "Pune"},
                { "1234", "Mumbai"}
            };
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            ht.Remove(1);
            Console.WriteLine("............................................");
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            Console.WriteLine("/////////////////////////////////////////////////////");
            Dictionary<int, String> dm = new Dictionary<int, string>();
            dm.Add(5, "Red");
            dm.Add(6, "green");
            dm.Add(1, "pink");
            foreach(KeyValuePair<int,string>kv in dm)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            Hashtable t = new Hashtable(dm);
            Console.WriteLine("...........................................");
            foreach(DictionaryEntry de in t)
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }
        }
    }
}
