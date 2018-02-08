using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program9
    {
        static void Main()
        {
            Console.Write("Please enter the number of rows: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            for(int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write("{0} ", count);
                    count++;
                }
                Console.WriteLine();                
            }
        }
    }

    
}
