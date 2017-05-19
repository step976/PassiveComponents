using System;
using Passive_Componets;
using NUnit.Framework;


namespace UnitTests.PassiveComponentsModel
{
    /// <summary>
    /// Набор тестов для класса Resistor
    /// </summary>
    [TestFixture]
    public class ResistorTest
    {
        [Test]
        [TestCase(12, 0, 12, 12, TestName = "Тестирование GetImpedance при присваивании частоты = 12 и номиналом = 12")]
        [TestCase(12, 0, -12, 12, ExpectedException = typeof(ArgumentException),TestName = "Тестирование GetImpedance при присваивании частоты = -12 и номиналом = 12")]
        [TestCase(-12, 0, -12, -12, ExpectedException = typeof(ArgumentException), TestName = "Тестирование GetImpedance при присваивании частоты = -12 и номиналом = -12")]
        [TestCase(12, 0, 12, -12, ExpectedException = typeof(ArgumentException), TestName = "Тестирование GetImpedance при присваивании частоты = 12 и номиналом = -12")]
        [TestCase(79.9, 0, 25.3, 79.9, TestName = "Тестирование GetImpedance при присваивании частоты = 25.3 и номиналом = 79.9")]
        public void GetImpedanceTest(double resultReal, double resulrImaginary, double freq, double value)
        {
            /*var resistor = new Resistor(value, freq);
            var impedance = resistor.Impedance;

            Assert.AreEqual(resultReal, impedance.Real);
            Assert.AreEqual(resulrImaginary, impedance.Imaginary);*/
        }
    }
}