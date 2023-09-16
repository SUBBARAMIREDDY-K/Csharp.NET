using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0, maxfactor = 1;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
                if (i != n)
                    maxfactor = i;
            }
            if (c != 1)
                Console.Write(maxfactor);
            else
                Console.Write("PRime ");
            Console.ReadKey();
   

                    

        }
    }
}
