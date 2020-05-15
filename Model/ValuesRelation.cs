using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Зависимость доступных значений
    /// </summary>
    public class ValuesRelation
    {
        /// <summary>
        /// Диаметр диска
        /// </summary>
        public int DiskDiameter { get; }
        /// <summary>
        /// Ширины диска
        /// </summary>
        public List<double> Widths { get; }
        /// <summary>
        /// Количество болтов
        /// </summary>
        public int BoltCount { get; }
        /// <summary>
        /// Диаметр расположения болтов
        /// </summary>
        public double BoltArrangementDiameter { get; }
        /// <summary>
        /// Диаметры центрального отверстия
        /// </summary>
        public List<double> CentralHoleDiameters { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="widths">Ширины диска</param>
        /// <param name="boltCount">Количество болтов</param>
        /// <param name="boltArrangementDiameter">
        /// Диаметр расположения болтов</param>
        /// <param name="centralHoleDiameters">
        /// Диаметры центрального отверстия</param>
        public ValuesRelation(int diskDiameter, List<double> widths,
            int boltCount, double boltArrangementDiameter,
            List<double> centralHoleDiameters)
        {
            DiskDiameter = diskDiameter;
            Widths = widths;
            BoltCount = boltCount;
            BoltArrangementDiameter = boltArrangementDiameter;
            CentralHoleDiameters = centralHoleDiameters;
        }
    }
}
