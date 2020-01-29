﻿using System;
using System.Runtime.CompilerServices;
using NUnit;
using NUnit.Framework;
using CalculatorExercise;

namespace UnitTestCalculator
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void setUp()
        {
            //Arrange
            uut = new Calculator();

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




    }
}