using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program11
    {
        static void Main()
        {            
            Random rnd = new Random();
            int guess1, guess2;

            do
            {
                guess1 = rnd.Next(1, 7);
                guess2 = rnd.Next(1, 7);
                Console.WriteLine("{0} {1}", guess1, guess2);
            } while (guess1 != guess2);            
        }
    }  
}
