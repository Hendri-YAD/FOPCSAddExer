using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program23
    {
        static void Main()
        {
            Console.Write("Please enter a value for a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a value for b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            BMoreThanA(ref a, ref b);

            Console.WriteLine("B is {0} and A is {1}", b, a);

        }

        static void BMoreThanA(ref int a, ref int b)
        {
            int max = Math.Max(a, b);

            if(max == a)
            {
                a = b;
                b = max;
            }
        }
    }
}
