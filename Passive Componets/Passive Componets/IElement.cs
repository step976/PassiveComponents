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
        /// Получение элемента цепи.
        /// </summary>
        /// <returns>Элемент цепи.</returns>
        string GetType();
        /// <summary>
        /// Индуктивность, сопротивление, емкость.
        /// </summary>
        double Value { get; set; }

    }
}