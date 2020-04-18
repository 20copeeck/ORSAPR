using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    public class DiskParams
    {
        public const double DefaultDiskDiameter = 16;
        public const double DefaultWidth = 6;
        public const int DefaultBoltsCount = 5;
        public const double DefaultBoltArrangementDiameter = 139.7;
        public const double DefaultCentralHoleDiameter = 108.5;
        public const int DefaultAirVentsCount = 12;
        public const decimal DefaultAirVentsDiameter = 10;

        private ParamsValidator _paramsValidator;

        private double _diskDiameter = DefaultDiskDiameter;
        private double _width = DefaultWidth;
        private int _boltsCount = DefaultBoltsCount;
        private double _boltArrangementDiameter = DefaultBoltArrangementDiameter;
        private double _centralHoleDiameter = DefaultCentralHoleDiameter;
        private int _airVentsCount = DefaultAirVentsCount;
        private decimal _airVentsDiameter = DefaultAirVentsDiameter;

        public double DiskDiameter
        {
            get
            {
                return _diskDiameter;
            }
            set
            {
                if (!_paramsValidator.IsValidDiskDiameter(value))
                {
                    throw new ArgumentException("Неверное значение диаметра диска");
                }
                
                _diskDiameter = value;
                _paramsValidator.AvailableParameters.ChangeCurrentValues(value);
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
                if (!_paramsValidator.IsValidWidth(value))
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
                if (!_paramsValidator.IsValidBoltsCount(value))
                {
                    throw new ArgumentException("Неверное значение количества отверстий под болты");
                }

                _boltsCount = value;
                _paramsValidator.AvailableParameters.ChangeCurrentValues(DiskDiameter, value, BoltArrangementDiameter);
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
                if (!_paramsValidator.IsValidBoltArrangementDiameter(value))
                {
                    throw new ArgumentException("Неверное значение PCD");
                }

                _boltArrangementDiameter = value;
                _paramsValidator.AvailableParameters.ChangeCurrentValues(DiskDiameter, BoltsCount, value);
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
                if (!_paramsValidator.IsValidCentralHoleDiameter(value))
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
            _paramsValidator = new ParamsValidator(DefaultDiskDiameter, DefaultBoltsCount, DefaultBoltArrangementDiameter);
        }
    }
}
