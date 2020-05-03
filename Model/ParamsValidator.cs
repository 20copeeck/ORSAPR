using System.Linq;

namespace Model
{
    /// <summary>
    /// Проверка допустимых параметров
    /// </summary>
    public static class ParamsValidator
    {
        /// <summary>
        /// Допустим ли параметр для диаметра диска
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidDiskDiameter(AvailableParameters availableParameters, 
            int diskDiameter)
        {

            return availableParameters.DiskDiameterValues.Any(value => value == diskDiameter);
        }

        /// <summary>
        /// Допустим ли параметр для ширины диска
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="width">Ширина диска</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidWidth(AvailableParameters availableParameters, 
            double width)
        {
            return availableParameters.WidthValues.Any(value => value.EqualTo(width));
        }

        /// <summary>
        /// Допустим ли параметр для количества болтов
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidBoltsCount(AvailableParameters availableParameters, 
            double boltsCount)
        {
            return availableParameters.BoltsCountValues.Any(value => value == boltsCount);
        }

        /// <summary>
        /// Допустим ли параметр для диаметра расположения болтов
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="boltArrangementDiameter">Диаметр расположения болтов</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidBoltArrangementDiameter(AvailableParameters availableParameters,
            double boltArrangementDiameter)
        {
            return availableParameters.BoltArrangementDiameterValues.Any(value => 
            value.EqualTo(boltArrangementDiameter));
        }

        /// <summary>
        /// Допустим ли параметр для диаметра центрального отверстия
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="centralHoleDiameter">Диаметр центрального отверстия</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidCentralHoleDiameter(AvailableParameters availableParameters,
            double centralHoleDiameter)
        {
            return availableParameters.CentralHoleDiameterValues.Any(value => 
            value.EqualTo(centralHoleDiameter));
        }

        /// <summary>
        /// Допустим ли параметр для количества вентиляционных отверстий
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="airVentsCount">Количество вентиляционных отверстий</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidAirVentsCount(AvailableParameters availableParameters,
            double airVentsCount)
        {
            return availableParameters.AirVentsCountValues.Any(value => value == airVentsCount);
        }

        /// <summary>
        /// Допустим ли параметр для диаметра вентиляционных отверстий
        /// </summary>
        /// <param name="availableParameters">Допустимые значения параметров</param>
        /// <param name="airVentsDiameter">Диаметр вентиляционных отверстий</param>
        /// <returns>Результат проверки</returns>
        public static bool IsValidAirVentsDiameter(AvailableParameters availableParameters,
            decimal airVentsDiameter)
        {
            return availableParameters.MaxAirVentsDiameter >= airVentsDiameter && 
                availableParameters.MinAirVentsDiameter <= airVentsDiameter;
        }
    }
}
