using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Параметры диска
    /// </summary>
    public class DiskParams
    {
        /// <summary>
        /// Изначальное значение диаметра диска
        /// </summary>
        public readonly int DefaultDiskDiameter = 16;
        /// <summary>
        /// Изначальное значение ширины диска
        /// </summary>
        public readonly double DefaultWidth = 6.5;
        /// <summary>
        /// Изначальное значение количества отверстий под болты
        /// </summary>
        public readonly int DefaultBoltsCount = 5;
        /// <summary>
        /// Изначальное значение диаметра расположения болтов
        /// </summary>
        public readonly double DefaultBoltArrangementDiameter = 139.7;
        /// <summary>
        /// Изначальное значение диаметра центрального отверстия диска
        /// </summary>
        public readonly double DefaultCentralHoleDiameter = 108.5;
        /// <summary>
        /// Изначальное значение количества вентиляционных отверстий
        /// </summary>
        public readonly int DefaultAirVentsCount = 12;
        /// <summary>
        /// Изначальное значение диаметра вентиляционных отверстий
        /// </summary>
        public readonly decimal DefaultAirVentsDiameter = 30;

        /// <summary>
        /// Константное значение угла наклона плоскости эскиза вентиляционных отверстий 
        /// </summary>
        public readonly int AirVentsAnglePlane = 65;
        /// <summary>
        /// Константное значение угла наклона плоскости эскиза отвертия под ниппель
        /// </summary>
        public readonly int NippleHoleAnglePlane = -20;
        /// <summary>
        /// Константное значение диаметра отверстия под ниппель
        /// </summary>
        public readonly double NippleHoleDiameter = 11.3;
        /// <summary>
        /// Константное значение диаметра отверстий под болты
        /// </summary>
        public readonly double BoltHoleDiameter = 15;
        /// <summary>
        /// Константное значение длины посадочной плоскости
        /// </summary>
        public readonly double LengthOfAttachedPlane = 25.69;
        /// <summary>
        /// Константное значение расстояния сдвига плоскости относительно 
        /// плоскости вентиляционных отверстий
        /// </summary>
        public readonly int DistanceFromAirVentsPlane = 60;
        /// <summary>
        /// Константное значение глубины выдавливания вентиляционного отверстия
        /// </summary>
        public readonly int DepthExtrusionAirVentsSketch = 45;
        /// <summary>
        /// Константное значение глубины выдавливания отверстия под болт
        /// </summary>
        public readonly int DepthExtrusionBoltHoleSketch = 65;
        /// <summary>
        /// Константное значение глубины выдавливания отверстия под ниппель
        /// </summary>
        public readonly int DepthExtrusionNippleHoleSketch = 110;

        /// <summary>
        /// Зависимости диаметров расположения вентиляционных отверстий
        /// от диаметра диска
        /// </summary>
        public readonly Dictionary<double, double> AirVentsArrangementDiameters = 
            new Dictionary<double, double>
        {
            {13, 123.1},
            {14, 134.61},
            {15, 146.12},
            {16, 157.63},
            {17, 169.14},
            {18, 180.65},
            {19, 192.16}
        };
        /// <summary>
        /// Зависимости диаметров расположения отверстия под ниппель
        /// от диаметра диска
        /// </summary>
        public readonly Dictionary<double, double> NippleHoleArrangementDiameters = 
            new Dictionary<double, double>
        {
            {13, -130.43},
            {14, -142.36},
            {15, -154.29},
            {16, -166.22},
            {17, -178.29},
            {18, -190.23},
            {19, -202.16}
        };

        /// <summary>
        /// Диаметр диска
        /// </summary>
        private int _diskDiameter;
        /// <summary>
        /// Ширина диска
        /// </summary>
        private double _width;
        /// <summary>
        /// Количество болтов
        /// </summary>
        private int _boltsCount;
        /// <summary>
        /// Диаметр расположения болтов
        /// </summary>
        private double _boltArrangementDiameter;
        /// <summary>
        /// Диаметр центрального отверстия
        /// </summary>
        private double _centralHoleDiameter;
        /// <summary>
        /// Количество вентиляционных отверстий
        /// </summary>
        private int _airVentsCount;
        /// <summary>
        /// Диаметр вентиляционных отверстий
        /// </summary>
        private decimal _airVentsDiameter;

        /// <summary>
        /// Доступные параметры
        /// </summary>
        public AvailableParameters AvailableParameters { get; }

        /// <summary>
        /// Диаметр диска
        /// </summary>
        public int DiskDiameter
        {
            get
            {
                return _diskDiameter;
            }
            set
            {
                if (!ParamsValidator.IsValidDiskDiameter(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение диаметра диска");
                }
                
                _diskDiameter = value;
                AvailableParameters.ChangeDiskDiameterDependentQuantities(value);
            }
        }

        /// <summary>
        /// Ширина диска
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (!ParamsValidator.IsValidWidth(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение ширины диска");
                }

                _width = value;
            }
        }

        /// <summary>
        /// Количество болтов
        /// </summary>
        public int BoltsCount
        {
            get
            {
                return _boltsCount;
            }
            set
            {
                if (!ParamsValidator.IsValidBoltsCount(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение количества отверстий под болты");
                }

                _boltsCount = value;
                AvailableParameters.ChangeBoltsCountDependentQuantities(DiskDiameter, value);
            }
        }

        /// <summary>
        /// Диаметр расположения болтов
        /// </summary>
        public double BoltArrangementDiameter
        {
            get
            {
                return _boltArrangementDiameter;
            }
            set
            {
                if (!ParamsValidator.IsValidBoltArrangementDiameter(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение PCD");
                }

                _boltArrangementDiameter = value;
                AvailableParameters.ChangeBoltArrangementDiameterDependentQuantities(DiskDiameter, BoltsCount, value);
            }
        }

        /// <summary>
        /// Диаметр центрального отверстия
        /// </summary>
        public double CentralHoleDiameter
        {
            get
            {
                return _centralHoleDiameter;
            }
            set
            {
                if (!ParamsValidator.IsValidCentralHoleDiameter(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение центрального отверстия диска");
                }

                _centralHoleDiameter = value;
            }
        }

        /// <summary>
        /// Количество вентиляционных отверстий
        /// </summary>
        public int AirVentsCount 
        {
            get
            {
                return _airVentsCount;
            }
            set
            {
                if (!ParamsValidator.IsValidAirVentsCount(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение количества вентиляционных отверстий");
                }

                _airVentsCount = value;
            }
        }

        /// <summary>
        /// Диаметр вентиляционный отверстий
        /// </summary>
        public decimal AirVentsDiameter 
        {
            get
            {
                return _airVentsDiameter;
            }
            set
            {
                if (!ParamsValidator.IsValidAirVentsDiameter(AvailableParameters, value))
                {
                    throw new ArgumentException("Неверное значение диаметра вентиляционных отверстий");
                }

                _airVentsDiameter = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public DiskParams()
        {
             _diskDiameter = DefaultDiskDiameter;
             _width = DefaultWidth;
             _boltsCount = DefaultBoltsCount;
             _boltArrangementDiameter = DefaultBoltArrangementDiameter;
             _centralHoleDiameter = DefaultCentralHoleDiameter;
             _airVentsCount = DefaultAirVentsCount;
             _airVentsDiameter = DefaultAirVentsDiameter;

             AvailableParameters = new AvailableParameters(_diskDiameter, _boltsCount,
                _boltArrangementDiameter);
        }
    }
}
