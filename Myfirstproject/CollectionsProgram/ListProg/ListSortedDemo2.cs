using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class ListSortedDemo2
    {
        static void Main(string[] args)
        {
            SortedList<string, string> li = new SortedList<string, string>();
            li.Add("Harry", "Mumbai");
            li.Add("John", "Pune");
            li.Add("Peter", "Nasik");
            li.Add("Daniel", "Pune");
            foreach(var mylist in li)
            {
                Console.WriteLine(mylist.Key+" "+mylist.Value);
            }
        }
    }
}
