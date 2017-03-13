using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    ///Класс конденсатора.
    /// </summary>
    public class Capacitor : IElement
    {
        /// <summary>
        /// Емкость кондесатора.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор конденсатора с параметром.
        /// </summary>
        /// <param name="value">Емкость конденсатора.</param>
        public Capacitor(double value)
        {
            Value = value;
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
                    throw new ArgumentException("Некорректно введена емкость конденсатора");
                }
            }
        }

        /// <summary>
        /// Нахождение комплексого сопротивления для конденсатора.
        /// </summary>
        /// <param name="freq">Частота.</param>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public Complex GetImpedance(double freq)
        {
            if (freq <= 0)
            {
                throw new ArgumentException("Некорректно введена частота");
            }
            return new Complex(0, -(1 / ((freq * 2 * Math.PI) * _value)));
        }
        /// <summary>
        /// Получение элемента цепи.
        /// </summary>
        PassiveComponents IElement.Type => PassiveComponents.Конденсатор;
    }
}