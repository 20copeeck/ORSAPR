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
                try
                {
                    if (value > 1)
                    {

                    }
                }
                catch
                {

                }
                _diskDiameter = value;
            }
        }
        public double Width { get; set; }
        public int BoltsCount { get; set; }
        public double BoltArrangementDiameter { get; set; }
        public double CentralHoleDiameter { get; set; }
        public int AirVentsCount { get; set; }
        public decimal AirVentsDiameter 
        {
            get
            {
                return _airVentsDiameter;
            }
            set
            {
                try
                {
                    if (value > 1)
                    {

                    }
                }
                catch
                {

                }
                _airVentsDiameter = value;
            }
        }

    }
}
