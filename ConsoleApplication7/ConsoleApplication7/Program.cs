using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        void display(params Object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}",arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Program o = new Program();
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            
            o.display(name,age,dept,fee);
            
            Console.ReadKey();
        }
    }
}
