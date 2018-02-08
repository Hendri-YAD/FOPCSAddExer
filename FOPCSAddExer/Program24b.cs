using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program24b
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
            if (test.Length < 7)
                return false;

            if (!(test.Substring(0,1).Any(char.IsLetter)))           
                return false;            

            if (!(test.Substring(1, 1).Any(char.IsLetter)))            
                return false;            

            if (!(test.Substring(2,1).Any(char.IsNumber)))            
                return false;            

            if (!(test.Substring(3, 1).Any(char.IsNumber)))            
                return false;

            if (!(test.Substring(4, 1).Any(char.IsNumber)))
                return false;

            if (!(test.Substring(5, 1).Any(char.IsNumber)))
                return false;

            if (!(test.Substring(6, 1).Any(char.IsNumber)))
                return false;

            return true;
        }
    }
}
