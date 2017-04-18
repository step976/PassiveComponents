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
        /// Имя для элемента списка.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Расчет комплексого сопротивления.
        /// </summary>
        Complex Impedance { get; }

        /// <summary>
        /// Угловая частота.
        /// </summary>
        double Freq { get; set; }
    }
}