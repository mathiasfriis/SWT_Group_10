﻿using NUnit.Framework;
using System;
namespace Calculator_Test_Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        [Test]
        public void Add_Add2And4_Returns6()
        {
            var uut = new NUnit_test_Calculator.Calculator();

            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }


        [Test]
        public void Add_Add3And4_Returns7()
        {
            var uut = new NUnit_test_Calculator.Calculator();

            Assert.That(uut.Add(3, 4), Is.EqualTo(7));
        }

        [Test]
        public void Subtract_Subtract3From4_Returns1()
        {
            var uut = new NUnit_test_Calculator.Calculator();

            Assert.That(uut.Subtract(4, 3), Is.EqualTo(1));
        }

        [Test]
        public void Multiply_Multiply3And4_Returns12()
        {
            var uut = new NUnit_test_Calculator.Calculator();

            Assert.That(uut.Multiply(3, 4), Is.EqualTo(12));
        }

        [Test]
        public void Power_Power3of2_Returns8()
        {
            var uut = new NUnit_test_Calculator.Calculator();

            Assert.That(uut.Power(2,3), Is.EqualTo(8));
        }

        [TestCase(2,3, ExpectedResult =5)]
        [TestCase(3, 5, ExpectedResult = 8)]
        public double AddWithTestCase_Add2Numbers_ReturnsResult(double x, double y)
        {
            var uut = new NUnit_test_Calculator.Calculator();

            return uut.Add(x, y);
        }

    }
}