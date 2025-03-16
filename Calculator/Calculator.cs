using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        private int _firstNum;
        private int _secondNum;

        public Calculator(IOperatorStrategy operatorStrategy, int firstNum, int secondNum) 
        {
            OperatorStrategy = operatorStrategy;
            _firstNum = firstNum;
            _secondNum = secondNum;
        }

        public IOperatorStrategy OperatorStrategy { private get; set; }
        
        public void Operate()
        {
             OperatorStrategy.Operate(_firstNum, _secondNum);
        }

    }
}
