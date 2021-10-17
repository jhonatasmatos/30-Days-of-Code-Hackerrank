using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (var i = n - 1; i > -1; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
