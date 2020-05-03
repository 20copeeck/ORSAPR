namespace Model
{
    /// <summary>
    /// Типы изменения допустимых значений параметров
    /// </summary>
    public enum AvailableValuesChangeType
    {
        /// <summary>
        /// Изменение диаметра диска
        /// </summary>
        DiskDiameterChanged,

        /// <summary>
        /// Изменение количества болтов
        /// </summary>
        BoltsCountChanged,

        /// <summary>
        /// Изменение диаметра расположения болтов
        /// </summary>
        BoltArrangementDiameterChanged
    }
}
