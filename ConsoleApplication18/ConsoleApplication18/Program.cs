using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            Console.Write("Enter the no of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of columns : ");
            cols = Convert.ToInt32(Console.ReadLine());
            string[,] s = new string[rows, cols];
            string[] d = new string[rows];
            string s1;
            Console.Write("Enter the Strings : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    s[i, j] = Console.ReadLine();
                }
            }
            int vowelCount=0,maxRindex=-1,maxCindex=-1,max=0,z=0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    vowelCount = 0;
                    s1 = s[i, j];
                    for (int k = 0; k < s1.Length; k++)
                    {
                        if (s1[k] == 'a' || s1[k] == 'A')
                            vowelCount++;
                        else if (s1[k] == 'e' || s1[k] == 'E')
                            vowelCount++;
                        else if (s1[k] == 'i' || s1[k] == 'I')
                            vowelCount++;
                        else if (s1[k] == 'o' || s1[k] == 'O')
                            vowelCount++;
                        else if (s1[k] == 'u' || s1[k] == 'U')
                            vowelCount++;
                    }
                    if (max < vowelCount)
                    {
                        maxRindex = i;
                        maxCindex = j;
                        max = vowelCount;
                    }
                    else if (max == vowelCount && max != 0)
                    {
                        d[z] = s[i, j];
                        z++;
                    }
                }
 
            }
            if (maxRindex != -1 && maxCindex != -1)
            {
                Console.WriteLine("Strings with maximum number of Vowels are : ");
                Console.WriteLine(s[maxRindex,maxCindex]);
                if (d.Length != 0)
                {
                    foreach (string ss in d)
                        Console.WriteLine(ss);
                }
            }
            else
                Console.Write("Vowels are not Exists");
       
            Console.ReadKey();
        }
    }
}
