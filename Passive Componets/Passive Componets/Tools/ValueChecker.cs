using System;

namespace Passive_Componets.Tools
{
    public static class ValueChecker
    {
        /// <summary>
        /// Проверка ввода данных для номинала и частоты
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double CheckValue(double value)
        {
            if ((value >= 0) && (value != double.NaN) && (value != double.PositiveInfinity))
            {
                return value;
            }
            throw new ArgumentException("Значение параметра должно быть положительным, но не Nan и не PositiveInfinity");
        }
    }
}