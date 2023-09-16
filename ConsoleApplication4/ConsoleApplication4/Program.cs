using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void read(int[] a, int r)
        {
            for (int i = 0; i < r; i++)
                a[i] = int.Parse(Console.ReadLine());
        }
        static void display(int[] a, int r)
        {
            for (int i = 0; i < r; i++)
                Console.WriteLine(a[i]);
        }
        static void Main(string[] args)
        {
            int r = 5;
            int[] arr = new int[r];
            read(arr, r);
            display(arr, r);
            Console.Read();
        }
    }
}
