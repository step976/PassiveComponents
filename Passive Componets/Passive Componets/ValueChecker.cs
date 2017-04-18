using System;

namespace Passive_Componets
{
    public static class ValueChecker
    {
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