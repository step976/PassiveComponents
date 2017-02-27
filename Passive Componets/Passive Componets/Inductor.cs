using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    /// Класс катушки индуктивности
    /// </summary>
    public class Inductor : IElement
    {
        /// <summary>
        /// Индуктивность.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор индуктора.
        /// </summary>
        /// <param name="value">Индуктивность.</param>
        public Inductor(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Индуктивность.
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentException("Некорректно введена индуктивность");
                }
                _value = value;
            }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для индуктора.
        /// </summary>
        /// <param name="freq">Частота.</param>
        /// <returns>Комплексное сопротивление индуктора.</returns>
        public Complex GetImpedance(double freq)
        {
            if (freq <= 0)
            {
                throw new ArgumentException("Некорректно введена частота");
            }
            return new Complex(0, (freq*2*Math.PI)*_value);
        }

        /// <summary>
        /// Получение элемента цепи.
        /// </summary>
        PassiveComponents IElement.Type => PassiveComponents.Индуктор;
    }
}