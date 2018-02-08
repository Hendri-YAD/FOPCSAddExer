using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program10
    {
        static void Main()
        {
            Console.Write("Please enter the dice number: "); //assume a number 1 to 6
            int num = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int guess;

            do
            {
                guess = rnd.Next(1, 7);
                Console.WriteLine(guess);
            } while (guess != 6);            
        }
    }  
}
