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
        /// Конструктор катушки индуктивности с параметром.
        /// </summary>
        /// <param name="value">Индуктивность.</param>
        public Inductor(double value)
        {
            Value = value;
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
            get
            {
                return _value;
            }
            set
            {
                if ( value >= 0 )
                {
                    _value = value;
                }
                else
                {
                    throw new ArgumentException("Некорректно введена индуктивность");
                }
            }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для катушки идуктивности.
        /// </summary>
        /// <param name="freq">Частота.</param>
        /// <returns>Комплексное сопротивление катушки идуктивности.</returns>
        public Complex GetImpedance(double freq)
        {
            if ( freq <= 0 )
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