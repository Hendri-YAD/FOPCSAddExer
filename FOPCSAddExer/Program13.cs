using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program13
    {
        static void Main()
        {            
            Random rnd = new Random();

            int guess = rnd.Next(1, 7);
            int guessNext = rnd.Next(1, 7);
            int guessNext2 = rnd.Next(1, 7);
            Console.WriteLine(guess);
            Console.WriteLine(guessNext);
            Console.WriteLine(guessNext2);

            while (guess != guessNext || guess != guessNext2 || guessNext != guessNext2)
            {
                guess = guessNext;
                guessNext = guessNext2;
                guessNext2 = rnd.Next(1, 7);
                Console.WriteLine(guessNext2);
            }
        }
    }  
}
