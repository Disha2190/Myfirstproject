using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Time
    {
        int hr, min;
        public Time()
        {
            hr = 0;
            min = 0;
        }
        public Time(int hr,int min)
        {
            this.hr = hr;
            this.min = min;
        }
        public void ShowTime()
        {
            Console.WriteLine("Time is "+hr+" : "+min);
        }
        public Time AddTime(Time t)
        {
            Time temp = new Time();
            temp.hr = this.hr + t.hr;
            temp.min = this.min + t.min;
            if(temp.min>=60)
            {
                temp.min = temp.min % 60;
                temp.hr++;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            Time t1 = new Time(3, 40);
            Time t2 = new Time(4, 55);
            t1.ShowTime();
            t2.ShowTime();
            Time t3 = new Time();
            t3 = t1.AddTime(t2);
            t3.ShowTime();
        }
    }
}
