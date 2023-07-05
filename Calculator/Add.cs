using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Add : IStrategy
    {
        public double DoAlgorithm(double a, double b) => a + b;
    }
}
