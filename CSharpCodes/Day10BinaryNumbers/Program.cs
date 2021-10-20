using System;

namespace Day10BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int count = 0, min = 0;

            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    count++; if (count >= min)
                    {
                        min = count;
                    }
                }
                else
                {
                    count = 0;
                }

                n /= 2;
            }

            Console.WriteLine(min);
        }
    }
}
