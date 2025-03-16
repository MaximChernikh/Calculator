using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Minus : IOperatorStrategy
    {
        public void Operate(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
