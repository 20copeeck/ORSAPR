using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    public class DiskParams
    {
        public readonly double DefaultDiskDiameter = 406.4;
        public readonly double DefaultWidth = 165.1;
        public readonly int DefaultBoltsCount = 5;
        public readonly double DefaultBoltArrangementDiameter = 139.7;
        public readonly double DefaultCentralHoleDiameter = 108.5;
        public readonly int DefaultAirVentsCount = 12;
        public readonly decimal DefaultAirVentsDiameter = 10;

        public readonly int AirVentsAnglePlane = 65;
        public readonly int NippleHoleAnglePlane = -20;
        public readonly double NippleHoleDiameter = 11.3;
        public readonly double BoltHoleDiameter = 15;
        public readonly double LengthOfAttachedPlane = 25.69;
        public readonly int DistanceFromBasePlane = 60;
        public readonly int DepthExtrusionAirVentsSketch = 45;
        public readonly int DepthExtrusionBoltHoleSketch = 65;
        public readonly int DepthExtrusionNippleHoleSketch = 110;

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

        private double _diskDiameter;
        private double _width;
        private int _boltsCount;
        private double _boltArrangementDiameter;
        private double _centralHoleDiameter;
        private int _airVentsCount;
        private decimal _airVentsDiameter;

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
        public int AirVentsCount { get; set; }
        public decimal AirVentsDiameter { get; set; }

        public DiskParams()
        {
             _diskDiameter = DefaultDiskDiameter;
             _width = DefaultWidth;
             _boltsCount = DefaultBoltsCount;
             _boltArrangementDiameter = DefaultBoltArrangementDiameter;
             _centralHoleDiameter = DefaultCentralHoleDiameter;
             _airVentsCount = DefaultAirVentsCount;
             _airVentsDiameter = DefaultAirVentsDiameter;

            AvailableParameters = new AvailableParameters(DefaultDiskDiameter, DefaultBoltsCount, 
                DefaultBoltArrangementDiameter);
        }
    }
}
