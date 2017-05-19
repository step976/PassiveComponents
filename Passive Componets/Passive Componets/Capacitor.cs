using System;
using System.Numerics;
using Passive_Componets.Tools;

namespace Passive_Componets
{
    /// <summary>
    ///Класс конденсатора.
    /// </summary>
    [Serializable]
    public class Capacitor : ElementsBase
    {
        private string _name;
        /// <summary>
        /// Конструктор конденсатора с параметром.
        /// </summary>
        /// <param name="value">Емкость конденсатора.</param>
        public Capacitor(double value)
        {
            Value = ValueChecker.CheckValue(value);
        }

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Capacitor()
        {
        }

        /// <summary>
        /// Свойство получения имени.
        /// </summary>
        public override string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Необходимо указать имя для элемента.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для конденсатора.
        /// </summary>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public override Complex GetImpedance(double angularFrequency)
        {
            return new Complex(0, -(1 / ((angularFrequency * 2 * Math.PI) * Value)));
        }
    }
}