using System;

namespace ORSAPR
{
    public static class DoubleExtensions
    {
        private static readonly double Epsilon = Math.Pow(2, -53);

        public static bool EqualTo(this double value1, double value2)
        {
            return Math.Abs(value1 - value2) <= Epsilon;
        }
    }
}
