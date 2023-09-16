using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        string name = "RAM";
        string regno = "5F0";
        void display()
        {
            Console.WriteLine("NAME : {0}", name);
            Console.WriteLine("Regno : {0}", regno);
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.display();
            Console.ReadKey();
        }

    }
}
