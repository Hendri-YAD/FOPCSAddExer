using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program20
    {
        static void Main()
        {
            Console.Write("Please enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of cols: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of widths: ");
            int widths = Convert.ToInt32(Console.ReadLine());

            int[,,] ar = new int[rows, cols, widths];
            Random rnd = new Random();

            for (int i=0; i < rows; i++)
            {
                for(int j=0;j < cols; j++)
                {
                    Console.Write("( ");
                    for(int z=0;z <widths; z++)
                    {
                        ar[i, j, z] = rnd.Next(0, 10);
                        Console.Write("{0} ", ar[i, j, z]);
                    }
                    Console.Write(") ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Average:");
            
            for(int i=0; i < rows; i++)
            {
                for(int j=0; j < cols; j++)
                {
                    double sum = 0;
                    for(int z=0; z < widths;z++)
                    {
                        sum = sum + ar[i, j, z];
                    }
                    Console.Write("{0:0.##} ", sum / widths);
                }
                Console.WriteLine();
            }
           
        }
    }  
}
