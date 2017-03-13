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
        /// Конструктор резистора c параметром.
        /// </summary>
        /// <param name="value">Сопротивление.</param>
        public Resistor(double value)
        {
            Value = value;
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
            get
            {
                return _value;
            }
            set
            {
                if ( _value >= 0 )
                {
                    _value = value;  
                }
                else
                {
                    throw new ArgumentException("Некорректно введено сопротивление");
                }
               
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
