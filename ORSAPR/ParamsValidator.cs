using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    public class ParamsValidator
    {
        public AvailableParameters AvailableParameters { get; }

        public ParamsValidator(double diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            AvailableParameters = new AvailableParameters(diskDiameter, boltsCount, boltArrangementDiameter);
        }

        public bool IsValidDiskDiameter(double diskDiameter)
        {
            return IsValidParam(0, diskDiameter);
        }

        public bool IsValidWidth(double width)
        {
            return IsValidParam(1, width);
        }

        public bool IsValidBoltsCount(double boltsCount)
        {
            return IsValidParam(2, boltsCount);
        }

        public bool IsValidBoltArrangementDiameter(double boltArrangementDiameter)
        {
            return IsValidParam(3, boltArrangementDiameter);
        }

        public bool IsValidCentralHoleDiameter(double centralHoleDiameter)
        {
            return IsValidParam(4, centralHoleDiameter);
        }

        private bool IsValidParam(int index, object param)
        {
            return (AvailableParameters.CurrentValues[index] as List<double>).Any(d => d.Equals(param));
        }
    }
}
