using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
    class Program
    {
        static void Main(string[] args)
        {
            WeekDays d = 0;
            Console.WriteLine(d);
            d = (WeekDays)1;
            Console.WriteLine(d);
            d = WeekDays.Thursday;
            Console.WriteLine((int)d);
            Console.WriteLine("Enumerations Constants and Values are : ");
            foreach (int c in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine((WeekDays)c + "  :  "+c);
            Console.ReadKey();
        }
    }
}
