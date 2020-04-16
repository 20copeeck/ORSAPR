using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    class AvailableParameters
    {
        public object[,] Values { get; private set; }

        public AvailableParameters()
        {
            Values = new object[70,5];

            Values[0, 0] = 13;
            Values[0, 1] = new List<double>() { 5, 5.5 };
            Values[0, 2] = 4;
            Values[0, 3] = 98;
            Values[0, 4] = new List<double>() { 58.6, 60.1 };

            Values[1, 0] = 13;
            Values[1, 1] = new List<double>() { 4.5, 5, 5.5 };
            Values[1, 2] = 4;
            Values[1, 3] = 100;
            Values[1, 4] = new List<double>() { 54.1, 56.6, 57.1 };

            Values[2, 0] = 13;
            Values[2, 1] = new List<double>() { 4.5, 5 };
            Values[2, 2] = 4;
            Values[2, 3] = 114.3;
            Values[2, 4] = new List<double>() { 69.1 };

            Values[3, 0] = 14;
            Values[3, 1] = new List<double>() { 5, 5.5, 6 };
            Values[3, 2] = 4;
            Values[3, 3] = 98;
            Values[3, 4] = new List<double>() { 58.1, 58.6 };

            Values[4, 0] = 14;
            Values[4, 1] = new List<double>() { 4.5, 5, 5.5, 6 };
            Values[4, 2] = 4;
            Values[4, 3] = 100;
            Values[4, 4] = new List<double>() { 54.1, 56.1, 56.6, 57.1, 60.1 };

            Values[5, 0] = 14;
            Values[5, 1] = new List<double>() { 5.5 };
            Values[5, 2] = 4;
            Values[5, 3] = 108;
            Values[5, 4] = new List<double>() { 63.3, 65.1 };

            Values[6, 0] = 14;
            Values[6, 1] = new List<double>() { 5.5 };
            Values[6, 2] = 4;
            Values[6, 3] = 114.3;
            Values[6, 4] = new List<double>() { 56.6, 66.1 };

            Values[7, 0] = 14;
            Values[7, 1] = new List<double>() { 5, 6 };
            Values[7, 2] = 5;
            Values[7, 3] = 100;
            Values[7, 4] = new List<double>() { 57.1 };

            Values[8, 0] = 14;
            Values[8, 1] = new List<double>() { 5.5 };
            Values[8, 2] = 5;
            Values[8, 3] = 120;
            Values[8, 4] = new List<double>() { 67.1 };

            Values[9, 0] = 15;
            Values[9, 1] = new List<double>() { 4.5 };
            Values[9, 2] = 3;
            Values[9, 3] = 112;
            Values[9, 4] = new List<double>() { 57.1 };

            Values[10, 0] = 15;
            Values[10, 1] = new List<double>() { 5.5, 6 };
            Values[10, 2] = 4;
            Values[10, 3] = 98;
            Values[10, 4] = new List<double>() { 58.1, 58.6 };

            Values[11, 0] = 15;
            Values[11, 1] = new List<double>() { 5, 5.5, 6 };
            Values[11, 2] = 4;
            Values[11, 3] = 100;
            Values[11, 4] = new List<double>() { 54.1, 56.1, 56.6, 60.1 };

            Values[12, 0] = 15;
            Values[12, 1] = new List<double>() { 6, 6.5 };
            Values[12, 2] = 4;
            Values[12, 3] = 108;
            Values[12, 4] = new List<double>() { 63.3, 65.1 };

            Values[13, 0] = 15;
            Values[13, 1] = new List<double>() { 5.5, 6 };
            Values[13, 2] = 4;
            Values[13, 3] = 114.3;
            Values[13, 4] = new List<double>() { 56.6, 64.1, 66.1 };

            Values[14, 0] = 15;
            Values[14, 1] = new List<double>() { 6 };
            Values[14, 2] = 5;
            Values[14, 3] = 98;
            Values[14, 4] = new List<double>() { 58.1 };

            Values[15, 0] = 15;
            Values[15, 1] = new List<double>() { 5.5, 6 };
            Values[15, 2] = 5;
            Values[15, 3] = 100;
            Values[15, 4] = new List<double>() { 57.1 };

            Values[16, 0] = 15;
            Values[16, 1] = new List<double>() { 6 };
            Values[16, 2] = 5;
            Values[16, 3] = 105;
            Values[16, 4] = new List<double>() { 56.6 };

            Values[17, 0] = 15;
            Values[17, 1] = new List<double>() { 6 };
            Values[17, 2] = 5;
            Values[17, 3] = 108;
            Values[17, 4] = new List<double>() { 60.1, 63.3 };

            Values[18, 0] = 15;
            Values[18, 1] = new List<double>() { 6 };
            Values[18, 2] = 5;
            Values[18, 3] = 110;
            Values[18, 4] = new List<double>() { 65.1 };

            Values[19, 0] = 15;
            Values[19, 1] = new List<double>() { 6 };
            Values[19, 2] = 5;
            Values[19, 3] = 112;
            Values[19, 4] = new List<double>() { 57.1 };

            Values[20, 0] = 15;
            Values[20, 1] = new List<double>() { 6, 6.5, 7, 8, 10 };
            Values[20, 2] = 5;
            Values[20, 3] = 114.3;
            Values[20, 4] = new List<double>() { 54.1, 60.1, 66.1, 67.1, 71.6, 84.1 };

            Values[21, 0] = 15;
            Values[21, 1] = new List<double>() { 6 };
            Values[21, 2] = 5;
            Values[21, 3] = 118;
            Values[21, 4] = new List<double>() { 71.1 };

            Values[22, 0] = 15;
            Values[22, 1] = new List<double>() { 6 };
            Values[22, 2] = 5;
            Values[22, 3] = 130;
            Values[22, 4] = new List<double>() { 84.1 };

            Values[23, 0] = 15;
            Values[23, 1] = new List<double>() { 5.5, 6, 7, 8, 10 };
            Values[23, 2] = 5;
            Values[23, 3] = 139.7;
            Values[23, 4] = new List<double>() { 98.6, 110.1, 108.5 };

            Values[24, 0] = 15;
            Values[24, 1] = new List<double>() { 5.5, 6.5 };
            Values[24, 2] = 5;
            Values[24, 3] = 160;
            Values[24, 4] = new List<double>() { 65.1 };

            Values[25, 0] = 15;
            Values[25, 1] = new List<double>() { 8 };
            Values[25, 2] = 5;
            Values[25, 3] = 165.1;
            Values[25, 4] = new List<double>() { 131 };

            Values[26, 0] = 15;
            Values[26, 1] = new List<double>() { 7, 8, 10 };
            Values[26, 2] = 6;
            Values[26, 3] = 139.7;
            Values[26, 4] = new List<double>() { 108.5, 110.1, 110.5 };

            Values[27, 0] = 15;
            Values[27, 1] = new List<double>() { 5.5 };
            Values[27, 2] = 6;
            Values[27, 3] = 205;
            Values[27, 4] = new List<double>() { 161.1 };

            Values[28, 0] = 16;
            Values[28, 1] = new List<double>() { 6, 6.5 };
            Values[28, 2] = 4;
            Values[28, 3] = 100;
            Values[28, 4] = new List<double>() { 54.1, 56.6, 60.1 };

            Values[29, 0] = 16;
            Values[29, 1] = new List<double>() { 6, 6.5, 7 };
            Values[29, 2] = 4;
            Values[29, 3] = 108;
            Values[29, 4] = new List<double>() { 63.3, 65.1 };

            Values[30, 0] = 16;
            Values[30, 1] = new List<double>() { 6 };
            Values[30, 2] = 5;
            Values[30, 3] = 98;
            Values[30, 4] = new List<double>() { 58.1 };

            Values[31, 0] = 16;
            Values[31, 1] = new List<double>() { 6, 6.5 };
            Values[31, 2] = 5;
            Values[31, 3] = 100;
            Values[31, 4] = new List<double>() { 56.1, 57.1 };

            Values[32, 0] = 16;
            Values[32, 1] = new List<double>() { 6.5 };
            Values[32, 2] = 5;
            Values[32, 3] = 105;
            Values[32, 4] = new List<double>() { 56.6 };

            Values[33, 0] = 16;
            Values[33, 1] = new List<double>() { 6.5, 7 };
            Values[33, 2] = 5;
            Values[33, 3] = 108;
            Values[33, 4] = new List<double>() { 63.3, 65.1 };

            Values[34, 0] = 16;
            Values[34, 1] = new List<double>() { 6.5 };
            Values[34, 2] = 5;
            Values[34, 3] = 110;
            Values[34, 4] = new List<double>() { 65.1 };

            Values[35, 0] = 16;
            Values[35, 1] = new List<double>() { 6, 6.5, 7 };
            Values[35, 2] = 5;
            Values[35, 3] = 112;
            Values[35, 4] = new List<double>() { 57.1, 66.6, 70.1 };

            Values[36, 0] = 16;
            Values[36, 1] = new List<double>() { 6, 6.5, 7, 8 };
            Values[36, 2] = 5;
            Values[36, 3] = 114.3;
            Values[36, 4] = new List<double>() { 54.1, 60.1, 64.1, 66.1, 67.1, 71.6, 84.1 };

            Values[37, 0] = 16;
            Values[37, 1] = new List<double>() { 6.5 };
            Values[37, 2] = 5;
            Values[37, 3] = 115;
            Values[37, 4] = new List<double>() { 70.1 };

            Values[38, 0] = 16;
            Values[38, 1] = new List<double>() { 6 };
            Values[38, 2] = 5;
            Values[38, 3] = 118;
            Values[38, 4] = new List<double>() { 71.1 };

            Values[39, 0] = 16;
            Values[39, 1] = new List<double>() { 6.5, 7 };
            Values[39, 2] = 5;
            Values[39, 3] = 120;
            Values[39, 4] = new List<double>() { 65.1, 67.1, 72.6 };

            Values[40, 0] = 16;
            Values[40, 1] = new List<double>() { 8 };
            Values[40, 2] = 5;
            Values[40, 3] = 127;
            Values[40, 4] = new List<double>() { 75.1 };

            Values[41, 0] = 16;
            Values[41, 1] = new List<double>() { 6, 6.5, 8 };
            Values[41, 2] = 5;
            Values[41, 3] = 130;
            Values[41, 4] = new List<double>() { 78.1, 84.1, 89.1 };

            Values[42, 0] = 16;
            Values[42, 1] = new List<double>() { 6.5, 7, 8, 10 };
            Values[42, 2] = 5;
            Values[42, 3] = 139.7;
            Values[42, 4] = new List<double>() { 95.3, 98.1, 98.6, 108.5, 110.1 };

            Values[43, 0] = 16;
            Values[43, 1] = new List<double>() { 8, 10 };
            Values[43, 2] = 5;
            Values[43, 3] = 150;
            Values[43, 4] = new List<double>() { 110.1, 110.5 };

            Values[44, 0] = 16;
            Values[44, 1] = new List<double>() { 5.5, 6.5 };
            Values[44, 2] = 5;
            Values[44, 3] = 160;
            Values[44, 4] = new List<double>() { 65.1 };

            Values[45, 0] = 16;
            Values[45, 1] = new List<double>() { 7 };
            Values[45, 2] = 5;
            Values[45, 3] = 165;
            Values[45, 4] = new List<double>() { 122.5 };

            Values[46, 0] = 16;
            Values[46, 1] = new List<double>() { 5.5, 6.5 };
            Values[46, 2] = 6;
            Values[46, 3] = 130;
            Values[46, 4] = new List<double>() { 84.1 };

            Values[47, 0] = 16;
            Values[47, 1] = new List<double>() { 6.5, 7, 8, 10 };
            Values[47, 2] = 6;
            Values[47, 3] = 139.7;
            Values[47, 4] = new List<double>() { 67.1, 92.5, 106.1, 108.5, 110.1  };

            Values[48, 0] = 16;
            Values[48, 1] = new List<double>() { 5.5 };
            Values[48, 2] = 6;
            Values[48, 3] = 170;
            Values[48, 4] = new List<double>() { 130.1 };

            Values[49, 0] = 16;
            Values[49, 1] = new List<double>() { 5, 6 };
            Values[49, 2] = 6;
            Values[49, 3] = 180;
            Values[49, 4] = new List<double>() { 138.8 };

            Values[50, 0] = 16;
            Values[50, 1] = new List<double>() { 5.5, 6 };
            Values[50, 2] = 6;
            Values[50, 3] = 205;
            Values[50, 4] = new List<double>() { 121.5, 161.1 };

            Values[51, 0] = 17;
            Values[51, 1] = new List<double>() { 6.5, 7 };
            Values[51, 2] = 4;
            Values[51, 3] = 100;
            Values[51, 4] = new List<double>() { 60.1 };

            Values[52, 0] = 17;
            Values[52, 1] = new List<double>() { 7.5 };
            Values[52, 2] = 4;
            Values[52, 3] = 108;
            Values[52, 4] = new List<double>() { 65.1 };

            Values[53, 0] = 17;
            Values[53, 1] = new List<double>() { 7 };
            Values[53, 2] = 5;
            Values[53, 3] = 100;
            Values[53, 4] = new List<double>() { 56.1, 57.1 };

            Values[54, 0] = 17;
            Values[54, 1] = new List<double>() { 7 };
            Values[54, 2] = 5;
            Values[54, 3] = 105;
            Values[54, 4] = new List<double>() { 56.6 };

            Values[55, 0] = 17;
            Values[55, 1] = new List<double>() { 7, 7.5, 8.5 };
            Values[55, 2] = 5;
            Values[55, 3] = 108;
            Values[55, 4] = new List<double>() { 63.3, 65.1 };

            Values[56, 0] = 17;
            Values[56, 1] = new List<double>() { 6.5, 7 };
            Values[56, 2] = 5;
            Values[56, 3] = 112;
            Values[56, 4] = new List<double>() { 57.1, 66.6, 70.1 };

            Values[57, 0] = 17;
            Values[57, 1] = new List<double>() { 6.5, 7 };
            Values[57, 2] = 5;
            Values[57, 3] = 114.3;
            Values[57, 4] = new List<double>() { 60.1, 64.1, 67.1 };

            Values[58, 0] = 17;
            Values[58, 1] = new List<double>() { 7, 7.5 };
            Values[58, 2] = 5;
            Values[58, 3] = 120;
            Values[58, 4] = new List<double>() { 65.1, 72.6 };

            Values[59, 0] = 17;
            Values[59, 1] = new List<double>() { 8 };
            Values[59, 2] = 5;
            Values[59, 3] = 127;
            Values[59, 4] = new List<double>() { 75.1 };

            Values[60, 0] = 17;
            Values[60, 1] = new List<double>() { 8 };
            Values[60, 2] = 5;
            Values[60, 3] = 139.7;
            Values[60, 4] = new List<double>() { 110.1 };

            Values[61, 0] = 17;
            Values[61, 1] = new List<double>() { 7, 7.5 };
            Values[61, 2] = 6;
            Values[61, 3] = 114.3;
            Values[61, 4] = new List<double>() { 66.1 };

            Values[62, 0] = 17;
            Values[62, 1] = new List<double>() { 7, 8 };
            Values[62, 2] = 6;
            Values[62, 3] = 139.7;
            Values[62, 4] = new List<double>() { 100.1, 106.1, 110.1 };

            Values[63, 0] = 18;
            Values[63, 1] = new List<double>() { 8 };
            Values[63, 2] = 5;
            Values[63, 3] = 108;
            Values[63, 4] = new List<double>() { 70.1 };

            Values[64, 0] = 18;
            Values[64, 1] = new List<double>() { 8 };
            Values[64, 2] = 5;
            Values[64, 3] = 112;
            Values[64, 4] = new List<double>() { 70.1 };

            Values[65, 0] = 18;
            Values[65, 1] = new List<double>() { 8 };
            Values[65, 2] = 5;
            Values[65, 3] = 114.3;
            Values[65, 4] = new List<double>() { 71.6 };

            Values[66, 0] = 18;
            Values[66, 1] = new List<double>() { 7.5 };
            Values[66, 2] = 6;
            Values[66, 3] = 114.3;
            Values[66, 4] = new List<double>() { 66.1 };

            Values[67, 0] = 18;
            Values[67, 1] = new List<double>() { 8 };
            Values[67, 2] = 6;
            Values[67, 3] = 139.7;
            Values[67, 4] = new List<double>() { 106.1 };

            Values[68, 0] = 19;
            Values[68, 1] = new List<double>() { 8, 8.5 };
            Values[68, 2] = 5;
            Values[68, 3] = 112;
            Values[68, 4] = new List<double>() { 70.1 };

            Values[69, 0] = 19;
            Values[69, 1] = new List<double>() { 8.5 };
            Values[69, 2] = 5;
            Values[69, 3] = 114.3;
            Values[69, 4] = new List<double>() { 71.6 };

        }
    }
}
