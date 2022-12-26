using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Train
    {
        public int id;
        public string tname;
        public int seatno;
        public Train(int id,string tname,int seatno)
        {
            this.id = id;
            this.tname = tname;
            this.seatno = seatno;
        }
    }
    class CustomSort1
    {
        static void Main(string[] args)
        {
            List<Train> li = new List<Train>();
            li.Add(new Train(101, "YYYY", 400));
            li.Add(new Train(401, "HHHH", 547));
            li.Add(new Train(203, "SSSS", 400));
            li.Add(new Train(341, "LLLL", 550));

            foreach(var c in li)
            {
                Console.WriteLine(c.id+" "+c.tname+" "+c.seatno);
            }
            Console.WriteLine("......................................");
            li.Sort(new SortSeatNo());
            foreach (var c in li)
            {
                Console.WriteLine(c.id + " " + c.tname + " " + c.seatno);
            }
        }
    }
    class SortSeatNo:IComparer<Train>
    {
        int IComparer<Train>.Compare(Train x, Train y)
        {
            if(x.seatno==y.seatno)
            {
                return y.seatno - x.seatno;
            }
            return x.seatno - y.seatno;
        }
    }
}
