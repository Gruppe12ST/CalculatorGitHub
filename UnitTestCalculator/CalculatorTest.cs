using System;
using System.Runtime.CompilerServices;
using NUnit;
using NUnit.Framework;
using CalculatorExercise;
using NUnit.Framework.Internal;
using Calculator = CalculatorExercise.Calculator;



namespace UnitTestCalculator
{
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorExercise.Calculator uut;
        
        [SetUp]
        public void setUp()
        {
            //Arrange
            uut = new CalculatorExercise.Calculator();

        }


        [TestCase(3,5)]
        [TestCase(-3, -5)]
        [TestCase(2.7, 1.8)]
        [TestCase(-1.5, 12.4)]
        public void TestAdd(double a, double b)
        {
            //Arrange
            double result = a + b;

            //Assert
            Assert.That(uut.Add(a,b),Is.EqualTo(result));
        }

        [TestCase(2, 2)]
        [TestCase(-2, 2)]
        [TestCase(2,0)]
        public void TestPower(double x, double exp)
        {
            //Arrange 
            double result = Math.Pow(x, exp);
            
            //Assert
            Assert.That(uut.Power(x,exp), Is.EqualTo(result));

        }

        [TestCase(5, 2)]
        [TestCase(-6, 2)]
        [TestCase(-26, -4)]
        public void TestDivide(double dividend, double divisor)
        {
            double result = dividend / divisor;
            Assert.That(uut.Divide(dividend,divisor), Is.EqualTo(result));

        }

        [Test]
        public void TestDivideByZero()
        {
            var ex = Assert.Catch<Exception>(() => uut.Divide(5, 0));
            StringAssert.Contains("Division med 0", ex.Message);
        }


        [Test]
        public void TestThatAddThrowsException()
        {
           
        }


        [Test]
        public void Add5andAccumulator()
        {
            uut.Add(5);

            Assert.That(uut.Accumulator,Is.EqualTo(5));
        }

        [TestCase(5.3,5)]
        [TestCase(-2.4,5)]
        [TestCase(7.34,-3)]
        public void AddwithAccululator(double a,double accumulator)
        {
            uut.Add(accumulator);
            uut.Add(a);

            double result = a + accumulator;
            Assert.That(uut.Accumulator,Is.EqualTo(result));
        }
        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void AddwithAccululatorReturnMethod(double a, double accumulator)
        {
            uut.Add(accumulator);
            double svar =uut.Add(a);

            double result = a + accumulator;
            Assert.That(svar, Is.EqualTo(result));
        }

        [Test]
        public void Subtrackt5fromAccumulator()
        {
            uut.Substract(5);

            Assert.That(uut.Accumulator, Is.EqualTo(-5));
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void SubtracktFromAccumulator(double a, double accumulator)
        {
            uut.Add(accumulator);
            uut.Substract(a);

            double result = accumulator-a;
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }
        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void SubtracktFromAccumulatorReturnMethod(double a, double accumulator)
        {
            uut.Add(accumulator);
            double svar = uut.Substract(a);

            double result = accumulator - a;
            Assert.That(svar, Is.EqualTo(result));
        }

        [Test]
        public void Multipy5WithAccumulator()
        {
            uut.Multiply(5);

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void MultiplyWithAccumulator(double a, double accumulator)
        {
            uut.Add(accumulator);
            uut.Multiply(a);

            double result = accumulator * a;
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void MultiplyWithAccumulatorReturnMethod(double a, double accumulator)
        {
            uut.Add(accumulator);
            double svar = uut.Multiply(a);

            double result = accumulator * a;
            Assert.That(svar, Is.EqualTo(result));
        }

        [Test]
        public void Power5WithAccumulator()
        {
            uut.Power(5);

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void PowerWithAccumulator(double a, double accumulator)
        {
            uut.Add(accumulator);
            uut.Power(a);

            double result = Math.Pow(accumulator,a);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void PowerWithAccumulatorReturnMethod(double a, double accumulator)
        {
            uut.Add(accumulator);
            double svar = uut.Power(a);

            double result = Math.Pow(accumulator, a);
            Assert.That(svar, Is.EqualTo(result));
        }


        [Test]
        public void TestDivideByZeroAccumulator()
        {
            uut.Add(5);
            var ex = Assert.Catch<Exception>(() => uut.Divide(0));
            StringAssert.Contains("Division med 0", ex.Message);
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void DividWithAccumulator(double a, double accumulator)
        {
            uut.Add(accumulator);
            uut.Divide(a);

            double result = accumulator / a;
            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.02));
        }

        [TestCase(5.3, 5)]
        [TestCase(-2.4, 5)]
        [TestCase(7.34, -3)]
        public void DividWithAccumulatorReturnMethod(double a, double accumulator)
        {
            uut.Add(accumulator);
            double svar = uut.Divide(a);

            double result = accumulator / a;
            Assert.That(svar, Is.EqualTo(result).Within(0.02));
        }
    }
}
