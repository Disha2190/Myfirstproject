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

    class Student1
    {
        int id;
        String name;
        int maths;
        int science;
        int english;
        float perc;

        public void Accept_Details(int sid,String sname,int smaths,int sscience,int senglish)
        {
            id = sid;
            name = sname;
            maths = smaths;
            science = sscience;
            english = senglish;
        }

        public void Percentage()
        {
            perc = (maths + english + science) / 300.00f * 100;
        }
        public void Display()
        {
            Console.WriteLine("ID: "+id+"\n Name:"+name+" \nMaths:"+maths+" \nScience:"+science+" \nEnglish: "+english);
            
            Console.WriteLine("Percentge= "+perc);
        }
        static void Main(string[] args)
        {
            Student1 sd = new Student1();
            sd.Accept_Details(23, "Riya", 79, 88, 83);
            sd.Percentage();
            sd.Display();

        }
    }


    class Method
    {
        //Access Modifier return_type method_name(parameterlist)
        //{
                //logical statment
        //}

        //no return type no parameter
        public void Show() //Method defination
        {
            Console.WriteLine("Show Method");//Method Body
        }

        //no return type with parameter
        
        public void Addition(float x, float y)
        {
            float ans = x + y;
            Console.WriteLine(ans);
        }

        // with return type no parameter
        
        public double Area_Circle()
        {
            double area = 3.14 * 2 * 2;
            return area;
        }
        //with return type with parameter
        public float Avg_Calculator(int x,int y,int z)
        {
            float avg = (x + y + z) / 3;
            return avg;
        }

        static void Main(string[] args)
        {
            Method m = new Method();
            m.Show();//Method calling

            m.Addition(3.5f, 7);

            double ans = m.Area_Circle();
            Console.WriteLine("Area of Circle= " +ans);

            float avg_value = m.Avg_Calculator(5, 6, 3);
            Console.WriteLine(avg_value);

            Console.WriteLine(m.Avg_Calculator(6,7,2));
        }

    }

    class Shopping
    {
        String name;
        float quantity;
        float price;
        float total;
        public void Details(String pname, float pquantity, float pprice)
        {
            name = pname;
            quantity = pquantity;
            price = pprice;
        }

        public void Creat_Bill()
        {
            if(quantity>0)
            {
               for(int i=1;i<=quantity;i++)
                {
                    total = price*quantity;
                }
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        public void Display_Details()
        {
            Console.WriteLine("Name:"+name+"\nQuantity:"+quantity+ "\nPrice: "+price+ "\nTotal= "+total);
        }
        static void Main(string[] args)
        {
            Shopping sh = new Shopping();
            sh.Details("Maggi",2,14);
            sh.Creat_Bill();
            sh.Display_Details();
        }
    }

    class Factorial
    {
        int x;
        int sum;

        public void Sum(int y)
        {
            x = y;
            for(int i=1;i<=x;i++)
            {
                if(x%i==0)
                {
                    sum = sum+i;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Factorial= "+sum);
        }
        static void Main(string[] args)
        {
            Factorial fa = new Factorial();
            fa.Sum(8);
            fa.Display();
        }
    }


}
