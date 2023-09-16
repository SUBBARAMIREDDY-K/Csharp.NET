using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    struct Student
    {
        string sname;
        int regdno;
        string sclgname;
        public void SetData()
        {
            Console.Write("Enter the Student Name : ");
            this.sname = Console.ReadLine();
            Console.Write("Enter the Student regdNo : ");
            this.regdno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Student college Name : ");
            this.sclgname = Console.ReadLine();
        }
        public void GetData()
        {
            Console.WriteLine("Student Name :" + this.sname);
            Console.WriteLine("Student regdNo :" + this.regdno);
            Console.WriteLine("Student college Name :" + this.sclgname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetData();
            s.GetData();
            Console.ReadKey();


        }
    }
}
