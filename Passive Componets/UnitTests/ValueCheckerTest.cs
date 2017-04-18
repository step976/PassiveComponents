using System;
using Passive_Componets;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ValueCheckerTest
    {
        [Test]
        [TestCase(12, ExpectedResult = 12, TestName = "Тестирование Value при присваиванит значения 12")]
        [TestCase(-1.8, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Value при присваиванит значения -1.8")]
        [TestCase(0.5, ExpectedResult = 0.5, TestName = "Тестирование Value при присваиванит значения 0.5")]
        [TestCase(0, ExpectedResult = 0, TestName = "Тестирование Value при присваиванит значения 0")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваиванит значения PositiveInfifnity")]
        [TestCase(double.NaN, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваиванит значения NaN")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваиванит значения NegativeInfinity")]
        public double ValueCheckTest(double value)
        {
            return ValueChecker.CheckValue(value);

        }
    }
}