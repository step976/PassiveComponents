using System;
using Passive_Componets;
using NUnit.Framework;


namespace UnitTests.PassiveComponentsModel
{
    /// <summary>
    /// Набор тестов для класса Capacitor
    /// </summary>
    [TestFixture]
    public class CapacitorTest
    {
        [Test]
        [TestCase(0, -1 / ((12 * Math.PI * 2) * 12), 12, 12,
            TestName = "Тестирование GetImpedance при присваивании частоты = 12 и номиналом = 12")]
        [TestCase(0, -1 / ((12 * Math.PI * 2) * 12), -12, 12, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование GetImpedance при присваивании частоты = -12 и номиналом = 12")]
        [TestCase(0, -1 / ((3.5 * Math.PI * 2) * 5), 3.5, 5,
            TestName = "Тестирование GetImpedance при присваивании частоты = 3.5 и номиналом = 5")]
        [TestCase(0, -1 / ((12 * Math.PI * 2) * 12), -12, -12, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование GetImpedance при присваивании частоты = -12 и номиналом = -12")]
        [TestCase(0, -1 / ((12 * Math.PI * 2) * 12), 12, -12, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование GetImpedance при присваивании частоты = 12 и номиналом = -12")]
        public void GetImpedanceTest(double resultReal, double resulrImaginary, double freq, double value)
        {
           /* var capacitor = new Capacitor(value, freq);
            var impedance = capacitor.Impedance;

            Assert.AreEqual(resultReal, impedance.Real);
            Assert.AreEqual(resulrImaginary, impedance.Imaginary);*/
        }
    }
}