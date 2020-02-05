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

        [TestCase(3,5,8)]
        [TestCase(-3, -5,-8)]
        [TestCase(2.7, 1.8,4.5)]
        [TestCase(-1.5, 12.4,10.9)]
        public void TestAdd(double a, double b, double answer)
        {
            //Assert
            Assert.That(uut.Add(a,b),Is.EqualTo(answer));
        }

        [TestCase(2, 2,4)]
        [TestCase(-2, 2,4)]
        [TestCase(2,0,1)]
        public void TestPower(double x, double exp, double answer)
        {
            //Assert
            Assert.That(uut.Power(x,exp), Is.EqualTo(answer));
        }

        [TestCase(5, 2,2.5)]
        [TestCase(-6, 2,-3)]
        [TestCase(-26, -4,6.5)]
        public void TestDivide(double dividend, double divisor, double answer)
        {
            Assert.That(uut.Divide(dividend,divisor), Is.EqualTo(answer));
        }

        [Test]
        public void TestDivideByZero()
        {
            var ex = Assert.Catch<Exception>(() => uut.Divide(5, 0));
            StringAssert.Contains("Division med 0", ex.Message);
        }

        [Test]
        public void Add5andAccumulator()
        {
            uut.Add(5);

            Assert.That(uut.Accumulator,Is.EqualTo(5));
        }

        [TestCase(5.3,5,10.3)]
        [TestCase(-2.4,5,2.6)]
        [TestCase(7.34,-3,4.34)]
        public void AddwithAccululator(double a,double accumulator,double result)
        {
            uut.Add(accumulator);
            uut.Add(a);

            Assert.That(uut.Accumulator,Is.EqualTo(result));
        }
        [TestCase(5.3, 5,10.3)]
        [TestCase(-2.4, 5,2.6)]
        [TestCase(7.34, -3,4.34)]
        public void AddwithAccululatorReturnMethod(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            double svar =uut.Add(a);

            Assert.That(svar, Is.EqualTo(result));
        }

        [Test]
        public void Subtrackt5fromAccumulator()
        {
            uut.Substract(5);

            Assert.That(uut.Accumulator, Is.EqualTo(-5));
        }

        [TestCase(5.3, 5,-0.3)]
        [TestCase(-2.4, 5,7.4)]
        [TestCase(7.34, -3,-10.34)]
        public void SubtracktFromAccumulator(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            uut.Substract(a);

            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.001));
        }

        [TestCase(5.3, 5,-0.3)]
        [TestCase(-2.4, 5,7.4)]
        [TestCase(7.34, -3,-10.34)]
        public void SubtracktFromAccumulatorReturnMethod(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            double svar = uut.Substract(a);

            Assert.That(svar, Is.EqualTo(result).Within(0.001));
        }

        [Test]
        public void Multipy5WithAccumulator()
        {
            uut.Multiply(5);

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(5.3, 5,26.5)]
        [TestCase(-2.4, 5,-12)]
        [TestCase(7.34, -3,-22.02)]
        public void MultiplyWithAccumulator(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            uut.Multiply(a);

            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(5.3, 5,26.5)]
        [TestCase(-2.4, 5,-12)]
        [TestCase(7.34, -3,-22.02)]
        public void MultiplyWithAccumulatorReturnMethod(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            double svar = uut.Multiply(a);

            Assert.That(svar, Is.EqualTo(result));
        }

        [Test]
        public void Power5WithAccumulator()
        {
            uut.Power(5);

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(5.3, 5,5064.552)]
        [TestCase(-2.4, 5,0.021)]
        [TestCase(2, -3,9)]
        public void PowerWithAccumulator(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            uut.Power(a);

            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.005));
        }

        [TestCase(5.3, 5,5064.552)]
        [TestCase(-2.4, 5,0.021)]
        [TestCase(2,-3,9)]
        public void PowerWithAccumulatorReturnMethod(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            double svar = uut.Power(a);

            Assert.That(svar, Is.EqualTo(result).Within(0.005));
        }


        [Test]
        public void TestDivideByZeroAccumulator()
        {
            uut.Add(5);
            var ex = Assert.Catch<Exception>(() => uut.Divide(0));
            StringAssert.Contains("Division med 0", ex.Message);
        }

        [TestCase(5.3, 5,0.943)]
        [TestCase(-2.4, 5,-2.083)]
        [TestCase(7.34, -3,-0.409)]
        public void DividWithAccumulator(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            uut.Divide(a);

            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(0.02));
        }

        [TestCase(5.3, 5,0.943)]
        [TestCase(-2.4, 5, -2.083)]
        [TestCase(7.34, -3, -0.409)]
        public void DividWithAccumulatorReturnMethod(double a, double accumulator,double result)
        {
            uut.Add(accumulator);
            double svar = uut.Divide(a);

            
            Assert.That(svar, Is.EqualTo(result).Within(0.02));
        }
    }
}
