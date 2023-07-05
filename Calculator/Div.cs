using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Div : IStrategy
    {
        public double DoAlgorithm(double a, double b) =>
            b == 0 ? throw new DivideByZeroException() : a / b;
    }
}
