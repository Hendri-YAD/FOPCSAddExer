﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=20; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            for (int i = 20; i >= 1; i--)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
