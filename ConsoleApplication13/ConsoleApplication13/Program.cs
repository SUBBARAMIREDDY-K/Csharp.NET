using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.Write("Enter the Elements of array are : ");
            for(int i=0;i<size;i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Elements of array are : ");
            foreach (int ele in arr)
                Console.Write(ele + " ");
            Console.ReadKey();
        }
    }
}
