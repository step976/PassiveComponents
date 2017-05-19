using System;
using NUnit.Framework;
using Passive_Componets.Tools;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса ValueCheker
    /// </summary>
    [TestFixture]
    public class ValueCheckerTest
    {
        [Test]
        [TestCase(12, ExpectedResult = 12, TestName = "Тестирование Value при присваивании значения 12")]
        [TestCase(-1.8, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваивании значения -1.8")]
        [TestCase(0.5, ExpectedResult = 0.5, TestName = "Тестирование Value при присваивании значения 0.5")]
        [TestCase(0, ExpectedResult = 0, TestName = "Тестирование Value при присваивании значения 0")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваивании значения PositiveInfifnity")]
        [TestCase(double.NaN, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваивании значения NaN")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Value при присваивании значения NegativeInfinity")]
        public double ValueCheckTest(double value)
        {
            return ValueChecker.CheckValue(value);
        }
    }
}