using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program24a
    {
        static void Main()
        {
            Console.Write("Please enter an input: ");
            string input = Console.ReadLine();

            while (!verifyInput(input))
            {
                Console.Write("Please enter a correct input: ");
                input = Console.ReadLine();
            }

            Console.WriteLine(input);
        }

        static bool verifyInput(string test)
        {
            if (test.Length < 8)
                return false;

            if (!(test.Any(char.IsUpper)))
            {
                return false;
            }

            if (!(test.Any(char.IsLower)))
            {
                return false;
            }

            if (!(test.Any(char.IsNumber)))
            {
                return false;
            }

            return true;
        }
    }
}
