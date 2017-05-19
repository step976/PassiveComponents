using System;
using System.Numerics;
using Passive_Componets.Tools;

namespace Passive_Componets
{
    /// <summary>
    /// Базовый абстракный класс для элементов.
    /// </summary>
    [Serializable]
    public abstract class ElementsBase : IElement
    {
        /// <summary>
        /// Номинал элемента.
        /// </summary>
        private double _value;

        /// <summary>
        /// Метод расчета комплексного сопротивления.
        /// </summary>
        /// <param name="angularFrequency">Угловая частота.</param>
        /// <returns></returns>
        public abstract Complex GetImpedance(double angularFrequency);

        /// <summary>
        /// Свойство для номинала.
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = ValueChecker.CheckValue(value); }
        }
        public abstract string Name { get;set; }
    }
}
