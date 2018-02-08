using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program5
    {
        static void Main()
        {
            int j = 20;
            for(int i = 1; i <= 10; i++, j--)
            {
                Console.Write("{0} {1} ", i, j);
            }

            Console.WriteLine();
        }
    }
}
