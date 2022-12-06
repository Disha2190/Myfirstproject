using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class StudentGrade
    {
        double per;
        int chem,phy,math,comp,sci;
        public void Accept()
        {
            Console.WriteLine("Enter Maths marks:");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics marks:");
            phy= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry marks:");
            chem = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Computer marks:");
            comp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Science marks:");
            sci = int.Parse(Console.ReadLine());

        }
        public double Percentage()
        {
            double total =math + chem + phy + comp + sci;
            per = (double)(total/ 500)*100;
            return per;
        }
        public char Grade()
        {
            if(per>=75)
            {
                return 'A';
            }
            else if(per<75 && per>= 60)
            {
                return 'B';
            }
            else if(per<60 && per>= 35)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }
        public void Display()
        {
            Console.WriteLine("Percentage are: "+Percentage());
            Console.WriteLine("Grade is: "+Grade());
        }
        static void Main(string[] args)
        {
            StudentGrade obj = new StudentGrade();
            obj.Accept();
            obj.Percentage();
            obj.Display();
        }
    }
}
