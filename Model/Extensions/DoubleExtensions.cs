using System;

namespace Model
{
    /// <summary>
    /// Расширение типа Double
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Погрешность при сравнении
        /// </summary>
        private static readonly double Epsilon = Math.Pow(2, -53);

        /// <summary>
        /// Сравнение двух Double значений
        /// </summary>
        /// <param name="value1">Первое Double значение</param>
        /// <param name="value2">Второе Double значение</param>
        /// <returns>Результат сравнения</returns>
        public static bool EqualTo(this double value1, double value2)
        {
            return Math.Abs(value1 - value2) <= Epsilon;
        }
    }
}
