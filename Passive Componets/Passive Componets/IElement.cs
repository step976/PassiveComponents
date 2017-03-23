using System.Numerics;

namespace Passive_Componets
{
    /// <summary>
    /// Интерфейс элементов.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Получение комплексного сопротивления.
        /// </summary>
        /// <returns>Комплексное число.</returns>
        Complex GetImpedance();

        /// <summary>
        /// Индуктивность, сопротивление, емкость.
        /// </summary>
        double Value { get; set; }

        /// <summary>
        /// Уникальное имя для элемента списка.
        /// </summary>
        string UniqueName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        Complex Impedance { get; }
        /// <summary>
        /// 
        /// </summary>
        double Freq { get; set; }
    }
}