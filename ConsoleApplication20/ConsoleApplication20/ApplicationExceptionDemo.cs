using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    public class DivideByOddNoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Attempted to Divide by Odd Number";
            }
        }
    }
    class ApplicationExceptionDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Value : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd Value : ");
            int y = int.Parse(Console.ReadLine());
            try
            {

                if (y % 2 > 0)
                {
                    throw new DivideByOddNoException();
                }
                int result = x / y;
                Console.WriteLine(result);
            }
            catch (DivideByOddNoException one)
            {
                Console.WriteLine(one.Message);
            }
            Console.WriteLine("End of the Program");
            Console.ReadKey();
        }
    }
}
