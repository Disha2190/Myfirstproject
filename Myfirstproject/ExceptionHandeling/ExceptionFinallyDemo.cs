using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class ExceptionFinallyDemo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                Console.WriteLine(10/sum);
            }
            catch
            {
                Console.WriteLine("Handle");
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
        }
    }
}
