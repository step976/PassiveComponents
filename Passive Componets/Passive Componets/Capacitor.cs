using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    ///Класс конденсатора.
    /// </summary>
    [Serializable]
    public class Capacitor : IElement
    {
        /// <summary>
        /// Угловая частота.
        /// </summary>
        private double _freq;

        /// <summary>
        /// Емкость кондесатора.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор конденсатора с параметром.
        /// </summary>
        /// <param name="name">Уникальное имя</param>
        /// <param name="value">Емкость конденсатора.</param>
        /// <param name="freq">Угловая частота</param>
        public Capacitor(string name, double value, double freq)
        {
            Value = value;
            Freq = freq;
        }

        /// <summary>
        /// Конструктор конденсатора по умолчанию.
        /// </summary>
        public Capacitor()
        {
        }

        /// <summary>
        /// Емкость кондесатора.
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = ValueChecker.CheckValue(value); }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для конденсатора.
        /// </summary>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public Complex GetImpedance()
        {
            return new Complex(0, -(1/((_freq*2*Math.PI)*_value)));
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
        /// Расчет комплексого сопротивления для конденсатора.
        /// </summary>
        public Complex Impedance
        {
            get
            {
                return GetImpedance();
            }
        }
    }
}