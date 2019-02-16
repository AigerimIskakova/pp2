using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;
        public string GPA;
        public int yos;
        public Student(string name, string GPA, string yos)
        {

            this.name = name;
            this.GPA = GPA;
            this.yos = int.Parse(yos);
        }
        public void increament()
        {
            this.yos = this.yos + 1;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name + " " + GPA + " " + yos);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sh = s.Split();
            //Console.WriteLine(sh.Length);
            Student st = new Student(sh[0], sh[1], sh[2]);
            st.increament();
            st.PrintInfo();
            Console.ReadKey();
        }
    }
}
