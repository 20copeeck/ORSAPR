using System;

namespace Model
{
    /// <summary>
    /// Аргументы события изменения доступных значений параметров
    /// </summary>
    public class ValuesChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Тип изменения
        /// </summary>
        public AvailableValuesChangeType Type { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="type">Тип изменения</param>
        public ValuesChangeEventArgs(AvailableValuesChangeType type)
        {
            Type = type;
        }
    }
}
