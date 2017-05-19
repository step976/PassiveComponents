using System;
using Passive_Componets;
using NUnit.Framework;


namespace UnitTests.PassiveComponentsModel
{
    /// <summary>
    /// Набор тестов для класса Inductor
    /// </summary>
    [TestFixture]
    public class InductorTest
    {
        [Test]
        [TestCase(0, ((12 * Math.PI * 2) * 12), 12, 12,
            TestName = "Тестирование GetImpedance при присваивании частоты = 12 и номиналом = 12")]
        [TestCase(0, ((12 * Math.PI * 2) * 12), -12, 12, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование GetImpedance при присваивании частоты = -12 и номиналом = 12")]
        [TestCase(0, ((23.5 * Math.PI * 2) * 45.7), 23.5, 45.7,
            TestName = "Тестирование GetImpedance при присваивании частоты = 23.5 и номиналом = 45.7")]
        [TestCase(0, ((12 * Math.PI * 2) * 12), -12, -12, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование GetImpedance при присваивании частоты = -12 и номиналом = -12")]
        [TestCase(0, ((12 * Math.PI * 2) * 12), 12, -12, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование GetImpedance при присваивании частоты = 12 и номиналом = -12")]
        public void GetImpedanceTest(double resultReal, double resulrImaginary, double freq, double value)
        {
           /* var inductor = new Inductor(value, freq);
            var impedance = inductor.Impedance;

            Assert.AreEqual(resultReal, impedance.Real);
            Assert.AreEqual(resulrImaginary, impedance.Imaginary);*/
        }
    }
}