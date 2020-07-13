using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 30;
            int result;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulus Operator: " + result);
            Console.ReadLine();
        }
    }
}
