using System;
using System.IO;

namespace Day9Recursion3
{
    class Program
    {

        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (n * factorial(n - 1));
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Program.factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
