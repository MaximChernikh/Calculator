﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IOperatorStrategy
    {
        public void Operate(int a, int b);
    }
}
