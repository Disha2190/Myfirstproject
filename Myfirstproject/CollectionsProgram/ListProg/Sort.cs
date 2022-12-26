using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Sort
    {
        static void Main(string[] args)
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(1, "Harry");
            st.Add(2, "John");
            st.Add(3, "Peter");
            st.Add(4, "Rose");
            st.Add(5, "Lilly");
            foreach(var s in st)
            {
                Console.WriteLine(s.Key+" "+s.Value);
            }
            Console.WriteLine("..............................");
            Console.WriteLine("Sorted List is:");
            foreach(var s in st)
            {
                if(s.Key%2==0)
                {
                    Console.WriteLine(s.Key+" "+s.Value);
                }
            }
        }
    }
}
