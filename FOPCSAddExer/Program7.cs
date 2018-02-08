using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program7a
    {
        static void Main()
        {
            Console.Write("Please enter the size of the inverted triangle: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = size; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();                
            }
        }
    }

    class Program7b
    {
        static void Main()
        {
            Console.Write("Please enter the size of the inverted triangle: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string s = "*";

            for (int i = size; i > 0; i--)
            {
                s = "*";
                for (int j = 1; j < i; j++)
                    s += "*";
                Console.WriteLine(s.PadLeft(100));
            }
        }
    }
    class Program7c
    {
        static void Main()
        {
            Console.Write("Please enter the size of the triangle: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string s = "*";

            for (int i = size; i > 0; i--)
            {
                s = "*";
                for (int j = 1; j < i; j++)
                {
                    s = s + " *";
                }
                Console.WriteLine(s.PadLeft(49 + i));  
            }
        }
    }
}
