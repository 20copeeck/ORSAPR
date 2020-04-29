using System;
using System.Linq;

namespace ORSAPR
{
    public static class ParamsValidator
    {
        public static bool IsValidDiskDiameter(AvailableParameters availableParameters, double diskDiameter)
        {

            return availableParameters.DiskDiameterValues.Any(value => value.EqualTo(diskDiameter));
        }

        public static bool IsValidWidth(AvailableParameters availableParameters, double width)
        {
            return availableParameters.WidthValues.Any(value => value.EqualTo(width));
        }

        public static bool IsValidBoltsCount(AvailableParameters availableParameters, double boltsCount)
        {
            return availableParameters.BoltsCountValues.Any(value => value == boltsCount);
        }

        public static bool IsValidBoltArrangementDiameter(AvailableParameters availableParameters, double boltArrangementDiameter)
        {
            return availableParameters.BoltArrangementDiameterValues.Any(value => value.EqualTo(boltArrangementDiameter));
        }

        public static bool IsValidCentralHoleDiameter(AvailableParameters availableParameters, double centralHoleDiameter)
        {
            return availableParameters.CentralHoleDiameterValues.Any(value => value.EqualTo(centralHoleDiameter));
        }
    }
}
