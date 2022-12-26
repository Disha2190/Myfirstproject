using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class MultiCatch
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                int[] a = new int[3];
                Console.WriteLine(a[4]/sum);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("////////"+e.ToString());
            }
            catch(IndexOutOfRangeException e1)
            {
                Console.WriteLine("........."+e1.ToString());
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.ToString()+".........");
            }
        }
    }
    /* class MultiCatch1
     {
         static void Main(string[] args)
         {
             int sum = 0;
             try
             {
                 int[] a = new int[3];
                 Console.WriteLine(a[4] / sum);
             }
             catch (Exception e2)
             {
                 Console.WriteLine(e2.ToString() + ".........");
             }
             catch (DivideByZeroException e)       ///Gives error
             {
                 Console.WriteLine("////////" + e.ToString());
             }
             catch (IndexOutOfRangeException e1)       ///Gives error
             {
                 Console.WriteLine("........." + e1.ToString());
             }
         }
     }*/
}
