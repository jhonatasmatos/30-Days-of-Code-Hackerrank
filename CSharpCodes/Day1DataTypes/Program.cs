using System;

namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto declare for Hackerrank
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            // Declare second integer, double, and String variables.
            int intValue;
            double doubleValue;
            string stringValue;

            // Read and save an integer, double, and String to your variables.
            intValue = Int32.Parse(Console.ReadLine());
            doubleValue = Double.Parse(Console.ReadLine());
            stringValue = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + intValue);

            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + doubleValue).ToString("0.0"));

            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + stringValue);
        }
    }
}
