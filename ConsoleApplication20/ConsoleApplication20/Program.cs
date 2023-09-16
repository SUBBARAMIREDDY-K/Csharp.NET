using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the 1st Value : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the 2nd Value : ");
                int y = Convert.ToInt32(Console.ReadLine());
                int result = x / y;
                Console.WriteLine("Result is : " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception Handelled Successfully");
            }
            Console.Write("End of Program ");
            Console.ReadKey();
        }

    }
}
