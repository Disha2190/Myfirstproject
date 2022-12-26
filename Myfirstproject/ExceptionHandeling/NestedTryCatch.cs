using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class NestedTryCatch
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                count++;
                try
                {
                    count++;
                    try
                    {
                        count++;
                        throw new Exception();
                    }
                    catch (Exception e1)
                    {
                        count++;
                        throw e1;
                    }
                }
                catch (Exception e)
                {
                    count++;
                    throw e;
                }
            }
          
            catch
            {
                Console.WriteLine(count);
            }
        }
    }
}
