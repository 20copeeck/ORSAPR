using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Доступные параметры
    /// </summary>
    public class AvailableParameters
    {
        /// <summary>
        /// Зависимости доступных параметров
        /// </summary>
        private List<ValuesRelation> _valuesRelations;
        /// <summary>
        /// Зависимости количеств вентиляционных отверстий
        /// </summary>
        private Dictionary<int, List<int>> _airVentsCountRelations;

        /// <summary>
        /// Доступные значения диаметра диска
        /// </summary>
        private List<int> _diskDiameterValues;
        /// <summary>
        /// Доступные значения ширины диска
        /// </summary>
        private List<double> _widthValues;
        /// <summary>
        /// Доступные значения количества болтов
        /// </summary>
        private List<int> _boltsCountValues;
        /// <summary>
        /// Доступные значения диаметра расположения болтов 
        /// </summary>
        private List<double> _boltArrangementDiameterValues;
        /// <summary>
        /// Доступные значения диаметра центрального отверстия
        /// </summary>
        private List<double> _centralHoleDiameterValues;
        /// <summary>
        /// Доступные значения количества вентиляционных отверстий
        /// </summary>
        private List<int> _airVentsCountValues;

        /// <summary>
        /// Доступные значения диаметра диска
        /// </summary>
        public IReadOnlyList<int> DiskDiameterValues => 
            _diskDiameterValues.AsReadOnly();

        /// <summary>
        /// Доступные значения ширины диска
        /// </summary>
        public IReadOnlyList<double> WidthValues => 
            _widthValues.AsReadOnly();

        /// <summary>
        /// Доступные значения количества болтов
        /// </summary>
        public IReadOnlyList<int> BoltsCountValues => 
            _boltsCountValues.AsReadOnly();

        /// <summary>
        /// Доступные значения диаметра расположения болтов 
        /// </summary>
        public IReadOnlyList<double> BoltArrangementDiameterValues => 
            _boltArrangementDiameterValues.AsReadOnly();

        /// <summary>
        /// Доступные значения диаметра центрального отверстия
        /// </summary>
        public IReadOnlyList<double> CentralHoleDiameterValues => 
            _centralHoleDiameterValues.AsReadOnly();

        /// <summary>
        /// Доступные значения количества вентиляционных отверстий
        /// </summary>
        public IReadOnlyList<int> AirVentsCountValues => 
            _airVentsCountValues.AsReadOnly();

        /// <summary>
        /// Максимальное значение диаметра вентиляцтонных отверстий
        /// </summary>
        public decimal MaxAirVentsDiameter { get; } = 40;
        /// <summary>
        /// Минимальное значение диаметра вентиляцтонных отверстий
        /// </summary>
        public decimal MinAirVentsDiameter { get; } = 15;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <param name="boltArrangementDiameter">
        /// Диаметр расположения болтов</param>
        public AvailableParameters
            (int diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            _valuesRelations = new List<ValuesRelation>();

            _valuesRelations.Add(new ValuesRelation
                (
                    13,
                    new List<double>() { 5, 5.5 },
                    4,
                    98.0,
                    new List<double>() { 58.6, 60.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    13,
                    new List<double>() { 4.5, 5, 5.5 },
                    4,
                    100.0,
                    new List<double>() { 54.1, 56.6, 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    13,
                    new List<double>() { 4.5, 5 },
                    4,
                    114.3,
                    new List<double>() { 69.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    14,
                    new List<double>() { 5, 5.5, 6 },
                    4,
                    98.0,
                    new List<double>() { 58.1, 58.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    14,
                    new List<double>() { 4.5, 5, 5.5, 6 },
                    4,
                    100.0,
                    new List<double>() { 54.1, 56.1, 56.6, 57.1, 60.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    14,
                    new List<double>() { 5.5 },
                    4,
                    108.0,
                    new List<double>() { 63.3, 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    14,
                    new List<double>() { 5.5 },
                    4,
                    114.3,
                    new List<double>() { 56.6, 66.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    14,
                    new List<double>() { 5, 6 },
                    5,
                    100.0,
                    new List<double>() { 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    14,
                    new List<double>() { 5.5 },
                    5,
                    120.0,
                    new List<double>() { 67.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 4.5 },
                    3,
                    112.0,
                    new List<double>() { 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5.5, 6 },
                    4,
                    98.0,
                    new List<double>() { 58.1, 58.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5, 5.5, 6 },
                    4,
                    100.0,
                    new List<double>() { 54.1, 56.1, 56.6, 60.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6, 6.5 },
                    4,
                    108.0,
                    new List<double>() { 63.3, 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5.5, 6 },
                    4,
                    114.3,
                    new List<double>() { 56.6, 64.1, 66.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    98.0,
                    new List<double>() { 58.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5.5, 6 },
                    5,
                    100.0,
                    new List<double>() { 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    105.0,
                    new List<double>() { 56.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    108.0,
                    new List<double>() { 60.1, 63.3 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    110.0,
                    new List<double>() { 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    112.0,
                    new List<double>() { 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6, 6.5, 7, 8, 10 },
                    5,
                    114.3,
                    new List<double>() 
                    { 54.1, 60.1, 66.1, 67.1, 71.6, 84.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    118.0,
                    new List<double>() { 71.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 6 },
                    5,
                    130.0,
                    new List<double>() { 84.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5.5, 6, 7, 8, 10 },
                    5,
                    139.7,
                    new List<double>() { 98.6, 110.1, 108.5 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5.5, 6.5 },
                    5,
                    160.0,
                    new List<double>() { 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 8 },
                    5,
                    165.1,
                    new List<double>() { 131 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 7, 8, 10 },
                    6,
                    139.7,
                    new List<double>() { 108.5, 110.1, 110.5 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    15,
                    new List<double>() { 5.5 },
                    6,
                    205.0,
                    new List<double>() { 161.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6, 6.5 },
                    4,
                    100.0,
                    new List<double>() { 54.1, 56.6, 60.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6, 6.5, 7 },
                    4,
                    108.0,
                    new List<double>() { 63.3, 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6 },
                    5,
                    98.0,
                    new List<double>() { 58.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6, 6.5 },
                    5,
                    100.0,
                    new List<double>() { 56.1, 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5 },
                    5,
                    105.0,
                    new List<double>() { 56.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5, 7 },
                    5,
                    108.0,
                    new List<double>() { 63.3, 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5 },
                    5,
                    110.0,
                    new List<double>() { 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6, 6.5, 7 },
                    5,
                    112.0,
                    new List<double>() { 57.1, 66.6, 70.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6, 6.5, 7, 8 },
                    5,
                    114.3,
                    new List<double>() 
                    { 54.1, 60.1, 64.1, 66.1, 67.1, 71.6, 84.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5 },
                    5,
                    115.0,
                    new List<double>() { 70.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6 },
                    5,
                    118.0,
                    new List<double>() { 71.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5, 7 },
                    5,
                    120.0,
                    new List<double>() { 65.1, 67.1, 72.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 8 },
                    5,
                    127.0,
                    new List<double>() { 75.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6, 6.5, 8 },
                    5,
                    130.0,
                    new List<double>() { 78.1, 84.1, 89.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5, 7, 8, 10 },
                    5,
                    139.7,
                    new List<double>() { 95.3, 98.1, 98.6, 108.5, 110.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 8, 10 },
                    5,
                    150.0,
                    new List<double>() { 110.1, 110.5 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 5.5, 6.5 },
                    5,
                    160.0,
                    new List<double>() { 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 7 },
                    5,
                    165.0,
                    new List<double>() { 122.5 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 5.5, 6.5 },
                    6,
                    130.0,
                    new List<double>() { 84.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 6.5, 7, 8, 10 },
                    6,
                    139.7,
                    new List<double>() { 67.1, 92.5, 106.1, 108.5, 110.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 5.5 },
                    6,
                    170.0,
                    new List<double>() { 130.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 5, 6 },
                    6,
                    180.0,
                    new List<double>() { 138.8 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    16,
                    new List<double>() { 5.5, 6 },
                    6,
                    205.0,
                    new List<double>() { 121.5, 161.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 6.5, 7 },
                    4,
                    100.0,
                    new List<double>() { 60.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7.5 },
                    4,
                    108.0,
                    new List<double>() { 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7 },
                    5,
                    100.0,
                    new List<double>() { 56.1, 57.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7 },
                    5,
                    105.0,
                    new List<double>() { 56.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7, 7.5, 8.5 },
                    5,
                    108.0,
                    new List<double>() { 63.3, 65.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 6.5, 7 },
                    5,
                    112.0,
                    new List<double>() { 57.1, 66.6, 70.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 6.5, 7 },
                    5,
                    114.3,
                    new List<double>() { 60.1, 64.1, 67.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7, 7.5 },
                    5,
                    120.0,
                    new List<double>() { 65.1, 72.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 8 },
                    5,
                    127.0,
                    new List<double>() { 75.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 8 },
                    5,
                    139.7,
                    new List<double>() { 110.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7, 7.5 },
                    6,
                    114.3,
                    new List<double>() { 66.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    17,
                    new List<double>() { 7, 8 },
                    6,
                    139.7,
                    new List<double>() { 100.1, 106.1, 110.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    18,
                    new List<double>() { 8 },
                    5,
                    108.0,
                    new List<double>() { 70.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    18,
                    new List<double>() { 8 },
                    5,
                    112.0,
                    new List<double>() { 70.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    18,
                    new List<double>() { 8 },
                    5,
                    114.3,
                    new List<double>() { 71.6 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    18,
                    new List<double>() { 7.5 },
                    6,
                    114.3,
                    new List<double>() { 66.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    18,
                    new List<double>() { 8 },
                    6,
                    139.7,
                    new List<double>() { 106.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    19,
                    new List<double>() { 8, 8.5 },
                    5,
                    112.0,
                    new List<double>() { 70.1 }
                ));
            _valuesRelations.Add(new ValuesRelation
                (
                    19,
                    new List<double>() { 8.5 },
                    5,
                    114.3,
                    new List<double>() { 71.6 }
                ));

            _airVentsCountRelations = new Dictionary<int, List<int>>()
            {
                {13, new List<int> { 10, 11, 12 }},
                {14, new List<int> { 10, 11, 12, 13, 14 }},
                {15, new List<int> { 10, 11, 12, 13, 14 }},
                {16, new List<int> { 12, 13, 14, 15, 16 }},
                {17, new List<int> { 12, 13, 14, 15, 16 }},
                {18, new List<int> { 14, 15, 16, 17, 18 }},
                {19, new List<int> { 16, 17, 18, 19, 20 }}
            };

            _diskDiameterValues = new List<int> 
            { 13, 14, 15, 16, 17, 18, 19 };

            ChangeDiskDiameterDependentQuantities(diskDiameter);
            ChangeBoltsCountDependentQuantities(diskDiameter, boltsCount);
            ChangeBoltArrangementDiameterDependentQuantities
                (diskDiameter, boltsCount, boltArrangementDiameter);
        }

        /// <summary>
        /// Изменить зависимые значения для диаметра диска
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        public void ChangeDiskDiameterDependentQuantities(int diskDiameter)
        {
            if (!DiskDiameterValues.Any(value => value == diskDiameter))
            {
                throw new ArgumentException
                    ("Неверное значение диаметра диска");
            }
            var selectedDiskDiameterLines = 
                ChangeDependentCounts(diskDiameter);
            var selectedBoltsCountLines = 
                ChangeDependentBoltArrangementDiameter
                (diskDiameter, selectedDiskDiameterLines.First().BoltCount);

            var currentLine = selectedDiskDiameterLines.First();
            _widthValues = currentLine.Widths;
            _centralHoleDiameterValues = currentLine.CentralHoleDiameters;

            ValuesChanged?.Invoke(this, new ValuesChangeEventArgs
                (AvailableValuesChangeType.DiskDiameterChanged));
        }

        /// <summary>
        /// Изменить зависимые значения для количества болтов
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        public void ChangeBoltsCountDependentQuantities
            (int diskDiameter, int boltsCount)
        {
            if (!DiskDiameterValues.Any(value => value == diskDiameter))
            {
                throw new ArgumentException
                    ("Неверное значение диаметра диска");
            }
            if (!BoltsCountValues.Any(value => value == boltsCount))
            {
                throw new ArgumentException
                    ("Неверное значение количества болтов");
            }
            var selectedBoltsCountLines = ChangeDependentBoltArrangementDiameter
                (diskDiameter, boltsCount);

            var currentLine = selectedBoltsCountLines.First();
            _widthValues = currentLine.Widths;
            _centralHoleDiameterValues = currentLine.CentralHoleDiameters;

            ValuesChanged?.Invoke(this, new ValuesChangeEventArgs
                (AvailableValuesChangeType.BoltsCountChanged));
        }

        /// <summary>
        /// Изменить зависимые значения для диаметра расположения болтов
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <param name="boltArrangementDiameter">
        /// Диаметр расположения болтов</param>
        public void ChangeBoltArrangementDiameterDependentQuantities
            (int diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            if (!DiskDiameterValues.Any(value => value == diskDiameter))
            {
                throw new ArgumentException
                    ("Неверное значение диаметра диска");
            }
            if (!BoltsCountValues.Any(value => value == boltsCount))
            {
                throw new ArgumentException
                    ("Неверное значение количества болтов");
            }
            if (!BoltArrangementDiameterValues.Any
                (value => value == boltArrangementDiameter))
            {
                throw new ArgumentException
                    ("Неверное значение диаметра расположения болтов");
            }
            var selectedBoltsCountLines = _valuesRelations.Where
                (item => item.DiskDiameter == diskDiameter && 
                item.BoltCount == boltsCount).ToList();

            var currentLine = selectedBoltsCountLines.Where(item =>
            item.BoltArrangementDiameter.EqualTo(boltArrangementDiameter)).First();
            _widthValues = currentLine.Widths;
            _centralHoleDiameterValues = currentLine.CentralHoleDiameters;

            ValuesChanged?.Invoke(this, new ValuesChangeEventArgs
                (AvailableValuesChangeType.BoltArrangementDiameterChanged));
        }

        /// <summary>
        /// Изменить зависимые параметры количества
        /// болтов и венлиляционных отверстий
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <returns>Допустимые зависимости для текущего диаметра</returns>
        private List<ValuesRelation> ChangeDependentCounts(int diskDiameter)
        {
            _airVentsCountValues = _airVentsCountRelations[diskDiameter];

            var selectedDiskDiameterLines = _valuesRelations.Where
                (item => item.DiskDiameter == diskDiameter).ToList();
            var collectionBoltsCount = new List<int>();

            foreach (var line in selectedDiskDiameterLines)
            {
                var boltsCountItem = line.BoltCount;
                if (!collectionBoltsCount.Contains(boltsCountItem))
                {
                    collectionBoltsCount.Add(boltsCountItem);
                }
            }

            _boltsCountValues = collectionBoltsCount;
            return selectedDiskDiameterLines;
        }

        /// <summary>
        /// Изменить зависимый параметр диаметра расположения болтов
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <returns>
        /// Допустимые зависимости для текущего количества болтов
        /// </returns>
        private List<ValuesRelation> ChangeDependentBoltArrangementDiameter
            (int diskDiameter, int boltsCount)
        {
            var selectedBoltsCountLines = _valuesRelations.Where
                (item => item.DiskDiameter == diskDiameter && 
                item.BoltCount == boltsCount).ToList();

            var collectionBoltArrangementDiameter = new List<double>();

            foreach (var line in selectedBoltsCountLines)
            {
                var boltArrangementDiameterItem = 
                    line.BoltArrangementDiameter;
                if (!collectionBoltArrangementDiameter.Contains
                    (boltArrangementDiameterItem))
                {
                    collectionBoltArrangementDiameter.Add
                        (boltArrangementDiameterItem);
                }
            }

            _boltArrangementDiameterValues = 
                collectionBoltArrangementDiameter;

            return selectedBoltsCountLines;
        }

        /// <summary>
        /// Событие изменения доступных параметров
        /// </summary>
        public event EventHandler<ValuesChangeEventArgs> ValuesChanged;
    }
}
