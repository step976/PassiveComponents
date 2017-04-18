using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    /// Класс резистора.
    /// </summary>
    [Serializable]
    public class Resistor : IElement
    {
        /// <summary>
        /// Угловая частота.
        /// </summary>
        private double _freq;

        /// <summary>
        /// Сопротивление.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор резистора c параметром.
        /// </summary>
        /// <param name="name">Уникальное имя</param>
        /// <param name="value">Сопротивление.</param>
        /// <param name="freq">Угловая частота</param>
        public Resistor(string name, double value, double freq)
        {
            Value = ValueChecker.CheckValue(value);
            Freq = FreqChecker.CheckFreq(freq);
        }

        /// <summary>
        /// Конструктор резистора по умолчанию.
        /// </summary>
        public Resistor()
        {
        }

        /// <summary>
        /// Сопротивление.
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = ValueChecker.CheckValue(value); }
        }

        /// <summary>
        /// Расчет комплексого сопротивления для резистора.
        /// </summary>
        /// <returns>Комплексное сопротивление резистора.</returns>
        public Complex GetImpedance()
        {
            return new Complex(_value, 0);
        }

        /// <summary>
        /// Имя для элемента списка.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Угловая частота.
        /// </summary>
        public double Freq
        {
            get { return _freq; }
            set { _freq = FreqChecker.CheckFreq(value); }
        }

        /// <summary>
        /// Расчет комплексого сопротивления для резистора.
        /// </summary>
        public Complex Impedance
        {
            get { return GetImpedance(); }
        }
    }
}
