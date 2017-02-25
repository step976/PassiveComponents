using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    /// Форма класса конденсатора.
    /// </summary>
    public class Capacitor : IElement
    {
        /// <summary>
        /// Емкость кондесатора.
        /// </summary>
        private double _value;

        /// <summary>
        /// Конструктор конденсатора.
        /// </summary>
        /// <param name="value">Емкость конденсатора.</param>
        public Capacitor(double value)
        {
            Value = value;
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
                // NOTE: Емкость может быть 0 ?
                if (value < 0)
                {
                    throw new ArgumentException("Некорректно введены данные");
                }
                _value = value;
            }
        }
        /// <summary>
        /// Нахождение комплексого сопротивления для конденсатора.
        /// </summary>
        /// <param name="freq">Частота.</param>
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public Complex GetImpedance(double freq)
        {
            //NOTE: Что будет если я передам частоту 0 ?
            return new Complex(0, -(1 / ((freq * 2 * Math.PI) * _value)));
        }

        /// <summary>
        /// Получение элемента цепи.
        /// </summary>
        /// <returns>Элемент цепи.</returns>
        public new string GetType()
        {
            //NOTE: Лучше сделать перечисление( enum) с типами, и возвращать конкретный тип
            return "Конденсатор";
        }
    }
}