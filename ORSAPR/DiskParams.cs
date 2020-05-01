using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    /// <summary>
    /// Параметры диска
    /// </summary>
    public class DiskParams
    {
        /// <summary>
        /// Изначальное значение диаметра диска
        /// </summary>
        public readonly double DefaultDiskDiameter = 406.4;
        /// <summary>
        /// Изначальное значение ширины диска
        /// </summary>
        public readonly double DefaultWidth = 165.1;
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
        /// Словарь константных значений диаметра расположения вентиляционных отверстий
        /// относительно диаметра диска 
        /// </summary>
        public readonly Dictionary<double, double> AirVentsArrangementDiameters = new Dictionary<double, double>
        {
            {330.2, 123.1},
            {355.6, 134.61},
            {381, 146.12},
            {406.4, 157.63},
            {431.8, 169.14},
            {457.2, 180.65},
            {482.6, 192.16}
        };
        /// <summary>
        /// Словарь константных значений диаметра расположения отверстия под ниппель
        /// относительно диаметра диска 
        /// </summary>
        public readonly Dictionary<double, double> NippleHoleArrangementDiameters = new Dictionary<double, double>
        {
            {330.2, 130.43},
            {355.6, 142.36},
            {381, 154.29},
            {406.4, 166.22},
            {431.8, 178.29},
            {457.2, 190.23},
            {482.6, 202.16}
        };

        /// <summary>
        /// Диаметр диска
        /// </summary>
        private double _diskDiameter;
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

        public double DiskDiameter
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
                AvailableParameters.ChangeCurrentValues(value);
            }
        }
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
                AvailableParameters.ChangeCurrentValues(DiskDiameter, value, BoltArrangementDiameter);
            }
        }
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
                AvailableParameters.ChangeCurrentValues(DiskDiameter, BoltsCount, value);
            }
        }
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

        public DiskParams()
        {
             _diskDiameter = DefaultDiskDiameter;
             _width = DefaultWidth;
             _boltsCount = DefaultBoltsCount;
             _boltArrangementDiameter = DefaultBoltArrangementDiameter;
             _centralHoleDiameter = DefaultCentralHoleDiameter;
             _airVentsCount = DefaultAirVentsCount;
             _airVentsDiameter = DefaultAirVentsDiameter;

             AvailableParameters = new AvailableParameters(Converter.ConvertFromSystemOfUnits(_diskDiameter), _boltsCount,
                _boltArrangementDiameter);
        }
    }
}
