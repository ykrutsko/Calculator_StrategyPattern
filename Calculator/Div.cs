using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Div : IStrategy
    {
        public double DoAlgorithm(double a, double b = 0) =>
            b == 0 ? throw new DivideByZeroException() : a / b;
    }
}
