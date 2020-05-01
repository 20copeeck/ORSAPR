using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    public static class Converter
    {
        public static double ConvertToSystemOfUnits(double value)
        {
            return value * 25.4;
        }

        public static double ConvertFromSystemOfUnits(double value)
        {
            return value / 25.4;
        }
    }
}
