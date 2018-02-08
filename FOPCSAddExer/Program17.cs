using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program17
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

            Console.Write("Please the number to search: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isNotFound = true;            
            int maxBin = 0; int minBin = size - 1;
            int foundPos = -1;

            while(isNotFound && maxBin <= minBin)
            {                
                int mid = (minBin + maxBin) / 2;

                if (num == ar[mid])
                {
                    foundPos = mid;
                    isNotFound = false;
                }
                else if (num > ar[mid])
                {
                    minBin = mid - 1;
                }
                else
                    maxBin = mid + 1;                                    
            }

            if (foundPos != -1)
                Console.WriteLine("The position of the number is {0}", foundPos, minBin, maxBin);
            else
                Console.WriteLine("The number was not found in the array");
        }
    }  
}
