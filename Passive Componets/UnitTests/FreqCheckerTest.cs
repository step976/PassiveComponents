using System;
using NUnit.Framework;
using Passive_Componets;

namespace UnitTests
{
    [TestFixture]
    public class FreqCheckerTest
    {
        [Test]
        [TestCase(1, ExpectedResult = 1, TestName = "Тестирование Freq при присваиванит значения 12")]
        [TestCase(-1.8, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Freq при присваиванит значения -1.8")]
        [TestCase(0.5, ExpectedResult = 0.5, TestName = "Тестирование Freq при присваиванит значения 0.5")]
        [TestCase(0, ExpectedResult = 0, TestName = "Тестирование Freq при присваиванит значения 0")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Freq при присваиванит значения PositiveInfifnity")]
        [TestCase(double.NaN, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Freq при присваиванит значения NaN")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Freq при присваиванит значения NegativeInfinity")]
        public double FreqCheckTest(double value)
        {
            return FreqChecker.CheckFreq(value);
        }
    }
}