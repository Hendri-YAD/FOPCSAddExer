﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSAddExer
{
    class Program22
    {
        static void Main()
        {
            Console.Write("Please enter the new size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] ar = new int[] { 0, 1, 2, 3, 4 };

            int[] resizeAr = ResizeArray(ar, size);

            for (int i = 0; i < resizeAr.Length; i++)
            {
                Console.WriteLine("Array {0} is {1}", i, resizeAr[i]);
            }
        }

        static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] newArr = new int[newSize];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }
    }
}
