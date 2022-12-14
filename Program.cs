using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            calc.Add(15, 5);
            calc.Add(25, 20, 33);
            calc.Add(25, 20, 35, 20);
            calc.Add(490.5, 509.4);
        }
        public int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }

        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
        }

        public int Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine(result);
            return result;
        }

        public double Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine(result);
            return result;
        }


    }
}
