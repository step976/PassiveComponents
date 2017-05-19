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
        /// <param name="angularFrequency">Угловая частота.</param>
        /// <returns>Комплексное сопротивление.</returns>
        Complex GetImpedance(double angularFrequency);

        /// <summary>
        /// Индуктивность, сопротивление, емкость.
        /// </summary>
        double Value { get; set; }

        /// <summary>
        /// Имя для элемента списка.
        /// </summary>
        string Name { get; set; }
    }
}