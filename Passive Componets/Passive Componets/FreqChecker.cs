using System;

namespace Passive_Componets
{
    public static class FreqChecker
    {
        public static double CheckFreq(double freq)
        {
            if ((freq >= 0) && (freq != double.NaN) && (freq != double.PositiveInfinity))
            {
                return freq;
            }
            throw new ArgumentException("Угловая частота должна быть положительной, но не Nan и не PositiveInfinity");
        }
    }
}