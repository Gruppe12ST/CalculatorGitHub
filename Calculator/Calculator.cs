using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorExercise;

namespace CalculatorExercise
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Substract(double a, double b)
        {
           Accumulator = a - b;
           return Accumulator;
        }

        public double Multiply(double a, double b)
        {
           Accumulator = a * b;
           return Accumulator;
        }

        public double Power(double x, double exp)
        {
           Accumulator = Math.Pow(x, exp);
           return Accumulator;
        }


        public double Divide(double dividend, double divisor)     
        {
            double result = Accumulator;

            try
            {
                Accumulator = (double) ((decimal)dividend / (decimal)divisor);              //OBS de to parametre er lavet om til decimal i stedet for double.
                return (double) Accumulator;                                                //Dette skyldes at doubles ikke kaster en exception hvis man dividerer med 0. I stedet returneres infinity.
            }
            catch (Exception e)
            {
                Accumulator = result;
                throw new DivideByZeroException("Division med 0");
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }


        public double Add(double addend)
        {
            Accumulator += addend;

            return Accumulator;
        }


        public double Substract(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }


        public double Multiply(double multiplier)
        {
            Accumulator = Accumulator * multiplier;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            try
            {
                decimal divid = ((decimal)Accumulator / (decimal)divisor);
                Accumulator = Convert.ToDouble(divid);
                return Accumulator;
            }
            catch (Exception e)
            {
                throw new DivideByZeroException("Division med 0");
            }


        }

    }
}
