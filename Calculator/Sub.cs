using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Sub : IStrategy
    {
        public double DoAlgorithm(double a, double b) => a - b;
    }
}
