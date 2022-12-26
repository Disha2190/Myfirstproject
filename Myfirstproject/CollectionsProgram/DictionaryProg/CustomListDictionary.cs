using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.DictionaryProg
{
    class Student
    {
        public int id;
        public string name;
        public int marks;

        public Student(int id,string name,int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
    }
    class CustomListDictionary
    {
        static void Main(string[] args)
        {
            List<Student> li = new List<Student>();
            li.Add(new Student(101, "Amit", 89));
            li.Add(new Student(102, "Nikhil", 78));
            li.Add(new Student(100, "Sonal", 89));
            li.Add(new Student(103, "yash", 60));

            foreach(var s in li)
            {
                Console.WriteLine(s.id+" "+s.name+" "+s.marks);
            }
            Console.WriteLine("................................");
           
            Dictionary<int, List<string>> dm = new Dictionary<int, List<string>>();
         
            for (int i = 0; i < li.Count; i++)
            {
                List<string> snamelist = new List<string>();
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i].marks == li[j].marks)
                    {
                        snamelist.Add(li[j].name);
                    }
                    if(!dm.ContainsKey(li[i].marks))
                    {
                        dm.Add(li[i].marks, snamelist);
                    }
                }
            }
            foreach(KeyValuePair<int,List<string>>kv in dm)
            {
                Console.Write(kv.Key+" ");
               /* foreach(var x in kv.Value)
                {
                    Console.WriteLine(x+" ");
                }*/
                List<string> name = new List<string>(kv.Value);
                foreach(var n in name)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
