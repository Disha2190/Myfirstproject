using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class NotBinaryNumber:SystemException
    {
        public NotBinaryNumber()
        {
            Console.WriteLine("Number is not binary number");
        }
    }
    class BinaryException
    {
        public static void check(int num)
        {
            int count = 0,flag=0;
            while (num > 0)
            {
                int j = num % 10;
                if (j == 0 || j==1)
                {
                    count++;
                }
                num = num / 10;
                flag++;
            }
            if(count!=flag)
            {
                throw new NotBinaryNumber();
            }
            Console.WriteLine("Binary number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            try
            {
                check(num);
            }
            catch
            {
                Console.WriteLine("Handle.......");
            }
        }
    }
}
