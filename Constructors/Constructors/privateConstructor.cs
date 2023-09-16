using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{
    class privateConstructor
    {
        int Empid;
        string Ename;
        private privateConstructor()
        {
            Console.Write("Enter the Student Id : ");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Student Name : ");
            this.Ename = Console.ReadLine();
        }
        void display()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student ID " + this.Empid);
            Console.Write("Student Name : " + this.Ename);
        }
        static void Main(string[] args)
        {
            DefaultConstructor d = new DefaultConstructor();
            d.display();
            Console.ReadKey();
        }
    }
}
