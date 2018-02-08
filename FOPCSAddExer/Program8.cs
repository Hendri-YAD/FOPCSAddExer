using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program8
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();                
            }
        }
    }

    
}
