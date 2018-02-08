using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program3a
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=20; i += 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }

    class Program3b
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if(i % 2 != 0)
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
