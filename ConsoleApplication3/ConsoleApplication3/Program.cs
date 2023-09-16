using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object b = a;
            int c = (int)b;
            Console.WriteLine(b);
            Console.WriteLine(c);
            string s;
            s = ((a % 2 == 0) ? "even" : "odd");
            Console.WriteLine(s);
            a++;
            Console.WriteLine("Increment : "+(a++));
            int d = 1;
            Console.WriteLine("ADddition : "+a+(a+d));
            a = 5;
            d = 11;
            Console.WriteLine("a & b : "+(a&d));
            Console.WriteLine("a & b : " + (a | d));
            Console.WriteLine("a & b : " + (a ^ d));
            Console.WriteLine("a & b : " + (~a));
            Console.WriteLine("a & b : " + (a << 2));
            Console.WriteLine("a & b : " + (a >> d));
            Console.Read();
        }
    }
}
