using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Employee
    {
        string eName;
        int empId;
       public void readEmployee()
        {
            Console.Write("Enter the Employee Name : ");
            eName = Console.ReadLine();
            Console.Write("Enter the Employee ID : ");
            empId = Convert.ToInt32(Console.ReadLine());
        }
       public void displayEmployee()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine("Employee Name : "+eName);
            Console.WriteLine("Employee Id : "+empId);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.readEmployee();
            e.displayEmployee();
            Console.ReadKey();
        }
    }
}
