using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program19
    {
        static void Main()
        {
            Console.Write("Please enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of cols: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] ar = new int[rows, cols];
            Random rnd = new Random();

            for (int i=0; i < rows; i++)
            {
                for(int j=0;j < cols; j++)
                {
                    ar[i, j] = rnd.Next(0, 10);
                    Console.Write("{0} ", ar[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Max:");

            for(int i=0; i<rows;i++)
            {
                int max = ar[i,0];
                for(int j=0; j < cols; j++)
                {                    
                    if (max < ar[i, j])
                        max = ar[i, j];
                }
                Console.WriteLine(max);
            }
           
        }
    }  
}
