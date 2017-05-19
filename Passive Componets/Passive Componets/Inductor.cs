using System;
using System.Numerics;
using Passive_Componets.Tools;

namespace Passive_Componets
{
    /// <summary>
    /// Класс катушки индуктивности
    /// </summary>
    [Serializable]
    public class Inductor : ElementsBase
    {
        private string _name;
        /// <summary>
        /// Конструктор катушки индуктивности с параметром.
        /// </summary>
        /// <param name="value">Индуктивность.</param>
        public Inductor(double value)
        {
            Value = ValueChecker.CheckValue(value);
        }

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Inductor()
        {
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для катушки идуктивности.
        /// </summary>
        /// <param name="angularFrequency">Угловая частота.</param>
        /// <returns>Комплексное сопротивление катушки идуктивности.</returns>
        public override Complex GetImpedance(double angularFrequency)
        {
            return new Complex(0, (angularFrequency * 2 * Math.PI) * Value);
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