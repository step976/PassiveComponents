using System;
using System.Numerics;
using Passive_Componets.Tools;

namespace Passive_Componets
{
    /// <summary>
    /// Класс резистора.
    /// </summary>
    [Serializable]
    public class Resistor : ElementsBase
    {
        private string _name;
        /// <summary>
        /// Конструктор резистора c параметром.
        /// </summary>
        /// <param name="value">Сопротивление.</param>
        public Resistor(double value)
        {
            Value = ValueChecker.CheckValue(value);
        }

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Resistor()
        {
        }

        /// <summary>
        /// Расчет комплексого сопротивления для резистора.
        /// </summary>
        /// <returns>Комплексное сопротивление резистора.</returns>
        public override Complex GetImpedance(double angularFrequency)
        {
            return new Complex(Value, 0);
        }

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
    }
}
