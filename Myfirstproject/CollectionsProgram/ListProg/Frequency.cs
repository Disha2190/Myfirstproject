using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.ListProg
{
    class Frequency
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
             {
                 "Pune",
                 "Mumbai",
                 "Banglore",
                 "Pune",
                 "Goa",
                 "Nasik",
                 "Pune",
                 "Nasik",
                 "Banglore",
                 "Banglore"
            };
            for(int i=0;i<li.Count;i++)
            {
                int count = 1;
                for(int j=i+1;j<li.Count;j++)
                {
                    if (li[i] == li[j])
                    {
                        count++;
                        li.RemoveAt(j);
                        j--;
                    }
                }
                Console.WriteLine(li[i]+" "+count);
            }
        }
    }

    class FrequencyList
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
             {
                 "Pune",
                 "Mumbai",
                 "Banglore",
                 "Pune",
                 "Goa",
                 "Nasik",
                 "Pune",
                 "Nasik",
                 "Banglore",
                 "Banglore"
            };
            for (int i = 0; i < li.Count; i++)
            {
                int cnt = 1;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (li[i] == li[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < li.Count; j++)
                    {
                        if (li[i] == li[j])
                        {
                            cnt++;
                        }
                    }
                    Console.WriteLine(li[i] + " " + cnt);
                }
            }
        }
    }
}
