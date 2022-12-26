using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Marks
    {
        public int maths;
        public int eng;
        public int sci;
        public int comp;

        public Marks(int maths, int eng, int sci, int comp)
        {
            this.maths = maths;
            this.eng = eng;
            this.sci = sci;
            this.comp = comp;

        }
    }
    class Students02
    {
        public int id;
        public string name;
        public List<Marks> al;
        public Students02(int id, string name, List<Marks> al)
        {
            this.id = id;
            this.name = name;
            this.al = al;
        }
    }

    class CustomListStud
    {
        static void Main(string[] args)
        {
            List<Students02> li = new List<Students02>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                List<Marks> em = new List<Marks>();
                Console.WriteLine("Enter the details of employee");
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Enter maths marks:");
                    int maths = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter maths eng:");
                    int eng = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maths sci:");
                    int sci = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maths comp:");
                    int comp = int.Parse(Console.ReadLine());


                    em.Add(new Marks(maths, eng, sci, comp));
                }
                li.Add(new Students02(id, name, em));
            }
            Console.WriteLine(".................................................");
            foreach (var d in li)
            {
                Console.WriteLine(d.id + " " + d.name + " ");
                foreach (var e in d.al)
                {
                    Console.Write(" " + e.maths + " " + e.eng + " " + e.sci + " " + e.comp);
                }
            }
            Console.WriteLine();
        }
    }
}
