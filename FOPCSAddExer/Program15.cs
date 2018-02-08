using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program15
    {
        static void Main()
        {
            Random rnd = new Random();

            int size = 20;        
            int[] ar = new int[size];

            for(int i=0; i < size; i++)
            {
                ar[i] = rnd.Next(1, size);
                Console.WriteLine(ar[i]);
            }

            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < size; i++)
            {
                if (ar[i] == num)
                {
                    Console.WriteLine(i);
                    return;
                }
                    
            }        
        }
    }  
}
