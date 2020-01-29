using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExercise
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double result;
            result = a + b;
            return result;
        }
        public double Add(double addend)
        {
            Accumulator += addend;

            return Accumulator;
        }

        public double Substract(double a, double b)
        {
            double result;
            result = a - b;
            return result;
        }

        public double Substract(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }


        public double Multiply(double a, double b)
        {
            double result;
            result = a * b;
            return result;
        }
        public double Multiply(double multiplier)
        {
            Accumulator = Accumulator * multiplier;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            double result;
            result = Math.Pow(x, exp);
            return result;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }


    }
}
