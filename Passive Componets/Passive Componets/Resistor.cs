using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    /// Класс резистора.
    /// </summary>
    [Serializable]
    public class Resistor : IElement
    {
        /// <summary>
        /// 
        /// </summary>
        private double _freq;
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
        /// <returns>Комплексное сопротивление резистора.</returns>
        public Complex GetImpedance()
        {
            return new Complex(_value, 0);
        }

        /// <summary>
        /// Уникальное имя для элемента списка.
        /// </summary>
        public string UniqueName { get; set; }

        public double Freq
        {
            get
            {
                return _freq;
            }
            set
            {
                _freq = value;
            }
        }

        /// <summary>
        /// 
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
