using System;
using System.Numerics;

using static Passive_Componets.PassiveComponents;

namespace Passive_Componets
{
    /// <summary>
    /// Класс резистора.
    /// </summary>
    public class Resistor : IElement
    {
        /// <summary>
        /// Сопротивление.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор резистора.
        /// </summary>
        /// <param name="value">Сопротивление.</param>
        public Resistor(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Сопротивление.
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if ( _value < 0 )
                {
                    throw new ArgumentException("Некорректно введено сопротивление");
                }
                _value = value;
            }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для резистора.
        /// </summary>
        /// <param name="freq">Частота.</param>
        /// <returns>Комплексное сопротивление резистора.</returns>
        public Complex GetImpedance(double freq)
        {
            return new Complex(_value, 0);
        }

        /// <summary>
        /// Получение элемента цепи.
        /// </summary>
        PassiveComponents IElement.Type => Резистор;
    }
}
