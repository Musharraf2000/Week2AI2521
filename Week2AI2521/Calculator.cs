using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }

        public void Add(int a, int b, int c) {
            Console.WriteLine($"The sum of {a}, {b} and {c} is: {a + b + c}");
        }
    }
}
