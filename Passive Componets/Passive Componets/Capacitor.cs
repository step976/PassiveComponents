﻿using System;
using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    ///Класс конденсатора.
    /// </summary>
    [Serializable]
    public class Capacitor : IElement
    {
        /// <summary>
        /// 
        /// </summary>
        private double _freq;
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
        /// <returns>Комплексное сопротивление конденсатора.</returns>
        public Complex GetImpedance()
        {

            return new Complex(0, -(1/((_freq*2*Math.PI)*_value)));
        }

        /// <summary>
        /// Уникальное имя для элемента списка.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  double Freq
        {
            get
            {
                return _freq;
            }
            set
            {
                if (_freq <= 0)
                {
                    throw new ArgumentException("Некорректно введена частота");
                }
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