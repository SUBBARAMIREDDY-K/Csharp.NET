using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
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
            char[] c = new char[cols];
            string s1;
            Console.Write("Enter the Strings : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    s[i, j] = Console.ReadLine();
                }
            }
            int vowelCount=0,maxRindex=-1,maxCindex=-1,max=0,maxCount=0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
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

                }

                if (max < vowelCount)
                {
                    maxRindex = i;
                    maxCindex = j;
                    maxCount=vowelCount;
                }
                    
            }
            if (maxRindex != -1 && maxCindex != -1)
            {
                Console.Write(s[maxRindex,maxCindex]);
                Console.WriteLine("  " + maxCount);
            }
            else
                Console.Write("Vowels are not Exists");
       
            Console.ReadKey();
        }
    }
}
