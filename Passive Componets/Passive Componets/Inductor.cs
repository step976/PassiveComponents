using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    /// Класс катушки индуктивности
    /// </summary>
    [Serializable]
    public class Inductor : IElement
    {
        /// <summary>
        /// Угловая частота.
        /// </summary>
        private double _freq;

        /// <summary>
        /// Индуктивность.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор катушки индуктивности с параметром.
        /// </summary>
        /// <param name="name">Уникальное ия</param>
        /// <param name="value">Индуктивность.</param>
        /// <param name="freq">Угловая частота</param>
        public Inductor(string name, double value,  double freq)
        {
            Value = value;
            Freq = freq;
        }

        /// <summary>
        /// Конструктор катукшки индуктивности по умолчанию.
        /// </summary>
        public Inductor()
        {
        }

        /// <summary>
        /// Индуктивность.
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = ValueChecker.CheckValue(value); }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для катушки идуктивности.
        /// </summary>
        /// <returns>Комплексное сопротивление катушки идуктивности.</returns>
        public Complex GetImpedance()
        {
            return new Complex(0, (_freq*2*Math.PI)*_value);
        }

        /// <summary>
        /// Имя для элемента списка.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Расчет комплексого сопротивления для катушки индуктивности.
        /// </summary>
        public Complex Impedance
        {
            get
            {
                return GetImpedance();
            }
        }

        /// <summary>
        /// Угловая частота.
        /// </summary>
        public double Freq
        {
            get { return _freq; }
            set { _freq = FreqChecker.CheckFreq(value); }
        }
    }
}