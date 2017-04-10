using System;
using Passive_Componets;
using NUnit.Framework;


namespace UnitTests.PassiveComponentsModel
{
    [TestFixture]
    public class CapacitorTest
    {
        [Test]
        [TestCase(12, TestName = "Тестирование Capacitor.Value при присваиванит значения 12")]  
        [TestCase(-9,ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Capacitor.Value при присваиванит значения - '-9'.")]
        [TestCase(1.6, TestName = "Тестирование Capacitor.Value при присваиванит значения 1.6")]
        public void ValueTest(double  value)
        {
            var capacitor = new Capacitor();
            capacitor.Value = value;
        }


        [Test]
        [TestCase(12, TestName = "Тестирование Capacitor.Freq при присваиванит значения 12")]
        [TestCase(-9, ExpectedException = typeof(ArgumentException),
    TestName = "Тестирование Capacitor.Freq при присваиванит значения - '-9'.")]
        [TestCase(1.6, TestName = "Тестирование Capacitor.Freq при присваиванит значения 1.6")]
        public void FreqTest(double freq)
        {
            var capacitor = new Capacitor();
            capacitor.Freq = freq;
        }
    }
}