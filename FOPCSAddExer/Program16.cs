using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program16
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

            Console.WriteLine("Sorted in descending order:");

            int max = ar[0];
            int temp = 0;
            int pos = 0; //temp position

            for (int i=0; i < size-1; i++)
            {
                pos = i;
                max = ar[i];
                for (int j = i; j < size; j++)
                {                    
                    if (max < ar[j])
                    {
                        max = ar[j];
                        pos = j;
                    }
                }

                temp = ar[i];
                ar[i] = ar[pos];
                ar[pos] = temp;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }  
}
