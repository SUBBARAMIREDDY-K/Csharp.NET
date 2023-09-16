using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Stu
    {
        string sname;
        int regdno;
        Stu(string name, int reg)
        {
            this.sname = name;
            this.regdno = reg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Name of the Student : ");
            string name = Console.ReadLine();
            Console.Write("Enter the RegdNO of the Student : ");
            int reg = Convert.ToInt32(Console.ReadLine());
            Stu s = new Stu(name,reg);
            Console.ReadKey();
        }
    }
}
