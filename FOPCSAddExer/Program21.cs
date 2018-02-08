using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program21
    {
        static void Main()
        {
            /*
            1 = left-aligned
            2 = center
            3 = right-aligned
            4 = inverted left-aligned
            5 = inverted center
            6 = inverted right-aligned            
            */


            Console.Write("Please give a triangle type(in a whole number): ");
            int triType = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please give the triangle height: ");
            int triHeight = Convert.ToInt32(Console.ReadLine());

            PrintTriangle(triType, triHeight);            
        }

        static void PrintTriangle(int type, int size)
        {
            string s = "*";
            switch (type)
            {
                case 1:
                    for (int i = 1; i <= size; i++)
                    {
                        for (int j = 0; j < i; j++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;
                case 2:                    
                    for (int i = 1; i <= size; i++)
                    {
                        s = "*";
                        for (int j = 1; j < i; j++)
                        {
                            s += "*";
                        }
                        Console.WriteLine(s.PadLeft(100));
                    }
                    break;
                case 3:
                    for (int i = 1; i <= size; i++)
                    {
                        s = "*";
                        for (int j = 1; j < i; j++)
                        {
                            s = s + " *";
                        }
                        Console.WriteLine(s.PadLeft(49 + i));
                    }
                    break;
                case 4:
                    for (int i = size; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    for (int i = size; i > 0; i--)
                    {
                        s = "*";
                        for (int j = 1; j < i; j++)
                            s += "*";
                        Console.WriteLine(s.PadLeft(100));
                    }
                    break;
                case 6:
                    for (int i = size; i > 0; i--)
                    {
                        s = "*";
                        for (int j = 1; j < i; j++)
                        {
                            s = s + " *";
                        }
                        Console.WriteLine(s.PadLeft(49 + i));
                    }
                    break;
            }            
        }
    }
}
