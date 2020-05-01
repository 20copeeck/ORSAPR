using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    public static class Converter
    {
        public static double ConvertToSystemOfUnits(int value)
        {
            return value * 25.4;
        }
    }
}
