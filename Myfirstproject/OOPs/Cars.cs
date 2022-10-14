using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs
{
    class Cars
    {
        public String modelNo;
        public String brand;
        public float price;
        public String colour;

        static void Main(string[] args)
        {
            Cars car1 = new Cars();
            car1.modelNo = "KA1234";
            car1.brand = "BMW";
            car1.price = 7050000;
            car1.colour = "Black";
            Console.WriteLine(car1.modelNo+" "+car1.brand+" "+car1.price+" "+car1.colour);

            Cars car2 = new Cars();
            car2.modelNo = "BA1456";
            car2.brand = "Volkswagen";
            car2.price = 65000000;
            car2.colour = "Red";
            Console.WriteLine(car2.modelNo + " " + car2.brand + " " + car2.price + " " + car2.colour);

            Cars car3 = new Cars();
            car3.modelNo = "BB7365";
            car3.brand = "Ford";
            car3.price = 5500000;
            car3.colour = "White";
            Console.WriteLine(car3.modelNo + " " + car3.brand + " " + car3.price + " " + car3.colour);
        }
    }

    class Box
    {
        public int l;
        public int h;
        public int w;
        static void Main(string[] args)
        {
            Box b = new Box();
            b.l = 4;
            b.h = 3;
            b.w = 7;
            Console.WriteLine("Area= "+(b.l*b.h*b.w));
        }
    }

    class Students
    {
        public int id;
        public String name;
        public int maths;
        public int science;
        public int english;
        public float percentage;
        static void Main(string[] args)
        {
            Students st = new Students();
            st.id = 1234;
            st.name = "Mansi";
            st.maths = 87;
            st.science = 76;
            st.english = 85;
            st.percentage = ((st.maths + st.science + st.english) / 300.0f) * 100;
            Console.WriteLine("Id: "+st.id+"\n Name: "+st.name+"\n Maths: "+st.maths+" \n Scince: "+st.science+" \n English: "+st.english );
            Console.WriteLine("Percentage= "+st.percentage);
        }
    }
}
