using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Mobile
    {
        public string RamSize = "4GB";
        public void ShowMobileData()
        {
            Console.WriteLine("Mobile RamSize= "+RamSize);
        }
    }
    class Apple:Mobile
    {
        public void Show()
        {
            Console.WriteLine("Ram Size");
        }
    }
    class IPhone : Apple
    {
        public void ChangeSize()
        {
            RamSize = "16GB";
        }
        public void DisplayData()
        {
            Console.WriteLine("IPhone RamSize= "+RamSize);
        }
    }
    class MultiLevelDemo
    {
        static void Main(string[] args)
        {
            IPhone p = new IPhone();
            p.Show();
            p.ShowMobileData();
            p.ChangeSize();
            p.DisplayData();
        }
    }
}
