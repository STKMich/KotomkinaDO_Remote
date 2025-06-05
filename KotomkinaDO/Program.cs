using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KotomkinaDO
{
    internal class Program
    {
        static public double Sqr(double X)
        {
            return X * X;
        }
//solve task2

//solve task1        {
            (double input, double expected)[] tests = new[]
            {
            (2.0, 4.0),
            (-3.0, 9.0),
            (0.0, 0.0),
            (1.5, 2.25),
            (0.1, 0.01)
            };

            foreach (var test in tests)
            {
                double result = Sqr(test.input);
                bool passed = Math.Abs(result - test.expected) < 1e-10;
                Console.WriteLine($"Input: {test.input}, Expected: {test.expected}, Got: {result}, {(passed ? "+" : "-")}");
            }
        }

        static void Main()
        {
            Start();
        }
    }
}
//KotomkinaDO Am-1-24

//Changes 

//solve task2

//solve task2

//solve task1