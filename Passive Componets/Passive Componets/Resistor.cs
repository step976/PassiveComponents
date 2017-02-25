using System;
using System.Numerics;


namespace Passive_Componets
{
    /// <summary>
    /// Форма класса резистора.
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
        public  double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value < 0)
                {
                   throw new ArgumentException("Некорректно введены данные");
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
        /// <returns>Элемент цепи.</returns>
        public new string GetType()
        {
            return "Резистор";
        }
    }
}
