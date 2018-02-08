using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program24c
    {
        static void Main()
        {
            //just check for whether there is one @

            Console.Write("Please enter an email address: ");
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
            int count = 0; //count the number of @
            for (int i=0; i < test.Length; i++)
            {
                if (test.Substring(i, 1) == "@")
                    count++;                
            }

            if (count != 1)
                return false;            

            return true;
        }
    }
}
