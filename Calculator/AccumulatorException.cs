using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AccumulatorException : Exception
    {
        public double Accumulator { get; private set; }

        public AccumulatorException(double accumulator)
        {
            Accumulator = accumulator;
        }
    }
}
