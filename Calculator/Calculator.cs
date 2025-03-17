using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator<TOutput>
    {
        public IOperatorStrategy<TOutput> SetOperator { private get; set; }

        public Calculator(IOperatorStrategy<TOutput> operatorStrategy)
        {
            SetOperator = operatorStrategy;
        }


        public TOutput Operate(double a, double b)
        {
            return SetOperator.Operate(a, b);
        }

    }
}
