using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{
    class ParameterizedConstructor
    {
        int Empid;
        string Ename;
        ParameterizedConstructor(int id,string name)
        {
            Empid = id;
            Ename = name;
        }
        void display()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student ID " + this.Empid);
            Console.Write("Student Name : " + this.Ename);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Student Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Student Name : ");
            string name = Console.ReadLine();
            ParameterizedConstructor p = new ParameterizedConstructor(id, name);
            p.display();
            Console.ReadKey();
        }
    }
}
