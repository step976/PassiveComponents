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
        /// <param name="freq">Частота.</param>
        /// <returns>Комплексное число.</returns>
        Complex GetImpedance(double freq);

        /// <summary>
        /// Индуктивность, сопротивление, емкость.
        /// </summary>
        double Value { get; set; }

        /// <summary>
        /// Уникальное имя для элемента списка.
        /// </summary>
        string UniqueName { get; set; }
    }
}