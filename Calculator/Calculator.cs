﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExercise
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        public double Add(double a, double b)
        {
            try
            {
                Accumulator = a + b;
                return Accumulator;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Accumulator = Accumulator;
                throw;
            }
        }

        public double Substract(double a, double b)
        {
            try
            {
                Accumulator = a - b;
                return Accumulator;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Accumulator = Accumulator;
                throw;
            }
        }

        public double Multiply(double a, double b)
        {
            try
            {
                Accumulator = a * b;
                return Accumulator;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Accumulator = Accumulator;
                throw;
            }
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
