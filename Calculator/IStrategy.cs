﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IStrategy
    {
        double DoAlgorithm(double a, double b);
    }
}
