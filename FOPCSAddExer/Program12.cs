using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program12
    {
        static void Main()
        {            
            Random rnd = new Random();

            int guess = rnd.Next(1, 7);
            int guessNext = rnd.Next(1, 7);
            Console.WriteLine(guess);
            Console.WriteLine(guessNext);

            while (guess != guessNext)
            {
                guess = guessNext;
                guessNext = rnd.Next(1, 7);
                Console.WriteLine(guessNext);
            }
        }
    }  
}
