using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program4
    {
        static void Main()
        {
            int[] fib = new int[12];
            fib[0] = 0;
            fib[1] = 1;

            for(int i = 2; i < 12; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 0; i < 12; i++)
            {
                Console.Write("{0} ", fib[i]);
            }

            Console.WriteLine();
        }
    }
}
