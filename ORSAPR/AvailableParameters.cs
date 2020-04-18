using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORSAPR
{
    public class AvailableParameters
    {
        private List<List<object>> _values;
        public object[] CurrentValues { get; private set; }
        public AvailableParameters(double diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            _values = new List<List<object>>();

            for (int i = 0; i < 70; i++)
            {
                _values.Add(new List<object>());
            }

            _values[0].Add(13);
            _values[0].Add(new List<double>() { 5, 5.5 });
            _values[0].Add(4);
            _values[0].Add(98.0);
            _values[0].Add(new List<double>() { 58.6, 60.1 });

            _values[1].Add(13);
            _values[1].Add(new List<double>() { 4.5, 5, 5.5 });
            _values[1].Add(4);
            _values[1].Add(100.0);
            _values[1].Add(new List<double>() { 54.1, 56.6, 57.1 });

            _values[2].Add(13);
            _values[2].Add(new List<double>() { 4.5, 5 });
            _values[2].Add(4);
            _values[2].Add(114.3);
            _values[2].Add(new List<double>() { 69.1 });

            _values[3].Add(14);
            _values[3].Add(new List<double>() { 5, 5.5, 6 });
            _values[3].Add(4);
            _values[3].Add(98.0);
            _values[3].Add(new List<double>() { 58.1, 58.6 });

            _values[4].Add(14);
            _values[4].Add(new List<double>() { 4.5, 5, 5.5, 6 });
            _values[4].Add(4);
            _values[4].Add(100.0);
            _values[4].Add(new List<double>() { 54.1, 56.1, 56.6, 57.1, 60.1 });

            _values[5].Add(14);
            _values[5].Add(new List<double>() { 5.5 });
            _values[5].Add(4);
            _values[5].Add(108.0);
            _values[5].Add(new List<double>() { 63.3, 65.1 });

            _values[6].Add(14);
            _values[6].Add(new List<double>() { 5.5 });
            _values[6].Add(4);
            _values[6].Add(114.3);
            _values[6].Add(new List<double>() { 56.6, 66.1 });

            _values[7].Add(14);
            _values[7].Add(new List<double>() { 5, 6 });
            _values[7].Add(5);
            _values[7].Add(100.0);
            _values[7].Add(new List<double>() { 57.1 });

            _values[8].Add(14);
            _values[8].Add(new List<double>() { 5.5 });
            _values[8].Add(5);
            _values[8].Add(120.0);
            _values[8].Add(new List<double>() { 67.1 });

            _values[9].Add(15);
            _values[9].Add(new List<double>() { 4.5 });
            _values[9].Add(3);
            _values[9].Add(112.0);
            _values[9].Add(new List<double>() { 57.1 });

            _values[10].Add(15);
            _values[10].Add(new List<double>() { 5.5, 6 });
            _values[10].Add(4);
            _values[10].Add(98.0);
            _values[10].Add(new List<double>() { 58.1, 58.6 });

            _values[11].Add(15);
            _values[11].Add(new List<double>() { 5, 5.5, 6 });
            _values[11].Add(4);
            _values[11].Add(100.0);
            _values[11].Add(new List<double>() { 54.1, 56.1, 56.6, 60.1 });

            _values[12].Add(15);
            _values[12].Add(new List<double>() { 6, 6.5 });
            _values[12].Add(4);
            _values[12].Add(108.0);
            _values[12].Add(new List<double>() { 63.3, 65.1 });

            _values[13].Add(15);
            _values[13].Add(new List<double>() { 5.5, 6 });
            _values[13].Add(4);
            _values[13].Add(114.3);
            _values[13].Add(new List<double>() { 56.6, 64.1, 66.1 });

            _values[14].Add(15);
            _values[14].Add(new List<double>() { 6 });
            _values[14].Add(5);
            _values[14].Add(98.0);
            _values[14].Add(new List<double>() { 58.1 });

            _values[15].Add(15);
            _values[15].Add(new List<double>() { 5.5, 6 });
            _values[15].Add(5);
            _values[15].Add(100.0);
            _values[15].Add(new List<double>() { 57.1 });

            _values[16].Add(15);
            _values[16].Add(new List<double>() { 6 });
            _values[16].Add(5);
            _values[16].Add(105.0);
            _values[16].Add(new List<double>() { 56.6 });

            _values[17].Add(15);
            _values[17].Add(new List<double>() { 6 });
            _values[17].Add(5);
            _values[17].Add(108.0);
            _values[17].Add(new List<double>() { 60.1, 63.3 });

            _values[18].Add(15);
            _values[18].Add(new List<double>() { 6 });
            _values[18].Add(5);
            _values[18].Add(110.0);
            _values[18].Add(new List<double>() { 65.1 });

            _values[19].Add(15);
            _values[19].Add(new List<double>() { 6 });
            _values[19].Add(5);
            _values[19].Add(112.0);
            _values[19].Add(new List<double>() { 57.1 });

            _values[20].Add(15);
            _values[20].Add(new List<double>() { 6, 6.5, 7, 8, 10 });
            _values[20].Add(5);
            _values[20].Add(114.3);
            _values[20].Add(new List<double>() { 54.1, 60.1, 66.1, 67.1, 71.6, 84.1 });

            _values[21].Add(15);
            _values[21].Add(new List<double>() { 6 });
            _values[21].Add(5);
            _values[21].Add(118.0);
            _values[21].Add(new List<double>() { 71.1 });

            _values[22].Add(15);
            _values[22].Add(new List<double>() { 6 });
            _values[22].Add(5);
            _values[22].Add(130.0);
            _values[22].Add(new List<double>() { 84.1 });

            _values[23].Add(15);
            _values[23].Add(new List<double>() { 5.5, 6, 7, 8, 10 });
            _values[23].Add(5);
            _values[23].Add(139.7);
            _values[23].Add(new List<double>() { 98.6, 110.1, 108.5 });

            _values[24].Add(15);
            _values[24].Add(new List<double>() { 5.5, 6.5 });
            _values[24].Add(5);
            _values[24].Add(160.0);
            _values[24].Add(new List<double>() { 65.1 });

            _values[25].Add(15);
            _values[25].Add(new List<double>() { 8 });
            _values[25].Add(5);
            _values[25].Add(165.1);
            _values[25].Add(new List<double>() { 131 });

            _values[26].Add(15);
            _values[26].Add(new List<double>() { 7, 8, 10 });
            _values[26].Add(6);
            _values[26].Add(139.7);
            _values[26].Add(new List<double>() { 108.5, 110.1, 110.5 });

            _values[27].Add(15);
            _values[27].Add(new List<double>() { 5.5 });
            _values[27].Add(6);
            _values[27].Add(205.0);
            _values[27].Add(new List<double>() { 161.1 });

            _values[28].Add(16);
            _values[28].Add(new List<double>() { 6, 6.5 });
            _values[28].Add(4);
            _values[28].Add(100.0);
            _values[28].Add(new List<double>() { 54.1, 56.6, 60.1 });

            _values[29].Add(16);
            _values[29].Add(new List<double>() { 6, 6.5, 7 });
            _values[29].Add(4);
            _values[29].Add(108.0);
            _values[29].Add(new List<double>() { 63.3, 65.1 });

            _values[30].Add(16);
            _values[30].Add(new List<double>() { 6 });
            _values[30].Add(5);
            _values[30].Add(98.0);
            _values[30].Add(new List<double>() { 58.1 });

            _values[31].Add(16);
            _values[31].Add(new List<double>() { 6, 6.5 });
            _values[31].Add(5);
            _values[31].Add(100.0);
            _values[31].Add(new List<double>() { 56.1, 57.1 });

            _values[32].Add(16);
            _values[32].Add(new List<double>() { 6.5 });
            _values[32].Add(5);
            _values[32].Add(105.0);
            _values[32].Add(new List<double>() { 56.6 });

            _values[33].Add(16);
            _values[33].Add(new List<double>() { 6.5, 7 });
            _values[33].Add(5);
            _values[33].Add(108.0);
            _values[33].Add(new List<double>() { 63.3, 65.1 });

            _values[34].Add(16);
            _values[34].Add(new List<double>() { 6.5 });
            _values[34].Add(5);
            _values[34].Add(110.0);
            _values[34].Add(new List<double>() { 65.1 });

            _values[35].Add(16);
            _values[35].Add(new List<double>() { 6, 6.5, 7 });
            _values[35].Add(5);
            _values[35].Add(112.0);
            _values[35].Add(new List<double>() { 57.1, 66.6, 70.1 });

            _values[36].Add(16);
            _values[36].Add(new List<double>() { 6, 6.5, 7, 8 });
            _values[36].Add(5);
            _values[36].Add(114.3);
            _values[36].Add(new List<double>() { 54.1, 60.1, 64.1, 66.1, 67.1, 71.6, 84.1 });

            _values[37].Add(16);
            _values[37].Add(new List<double>() { 6.5 });
            _values[37].Add(5);
            _values[37].Add(115.0);
            _values[37].Add(new List<double>() { 70.1 });

            _values[38].Add(16);
            _values[38].Add(new List<double>() { 6 });
            _values[38].Add(5);
            _values[38].Add(118.0);
            _values[38].Add(new List<double>() { 71.1 });

            _values[39].Add(16);
            _values[39].Add(new List<double>() { 6.5, 7 });
            _values[39].Add(5);
            _values[39].Add(120.0);
            _values[39].Add(new List<double>() { 65.1, 67.1, 72.6 });

            _values[40].Add(16);
            _values[40].Add(new List<double>() { 8 });
            _values[40].Add(5);
            _values[40].Add(127.0);
            _values[40].Add(new List<double>() { 75.1 });

            _values[41].Add(16);
            _values[41].Add(new List<double>() { 6, 6.5, 8 });
            _values[41].Add(5);
            _values[41].Add(130.0);
            _values[41].Add(new List<double>() { 78.1, 84.1, 89.1 });

            _values[42].Add(16);
            _values[42].Add(new List<double>() { 6.5, 7, 8, 10 });
            _values[42].Add(5);
            _values[42].Add(139.7);
            _values[42].Add(new List<double>() { 95.3, 98.1, 98.6, 108.5, 110.1 });

            _values[43].Add(16);
            _values[43].Add(new List<double>() { 8, 10 });
            _values[43].Add(5);
            _values[43].Add(150.0);
            _values[43].Add(new List<double>() { 110.1, 110.5 });

            _values[44].Add(16);
            _values[44].Add(new List<double>() { 5.5, 6.5 });
            _values[44].Add(5);
            _values[44].Add(160.0);
            _values[44].Add(new List<double>() { 65.1 });

            _values[45].Add(16);
            _values[45].Add(new List<double>() { 7 });
            _values[45].Add(5);
            _values[45].Add(165.0);
            _values[45].Add(new List<double>() { 122.5 });

            _values[46].Add(16);
            _values[46].Add(new List<double>() { 5.5, 6.5 });
            _values[46].Add(6);
            _values[46].Add(130.0);
            _values[46].Add(new List<double>() { 84.1 });

            _values[47].Add(16);
            _values[47].Add(new List<double>() { 6.5, 7, 8, 10 });
            _values[47].Add(6);
            _values[47].Add(139.7);
            _values[47].Add(new List<double>() { 67.1, 92.5, 106.1, 108.5, 110.1  });

            _values[48].Add(16);
            _values[48].Add(new List<double>() { 5.5 });
            _values[48].Add(6);
            _values[48].Add(170.0);
            _values[48].Add(new List<double>() { 130.1 });

            _values[49].Add(16);
            _values[49].Add(new List<double>() { 5, 6 });
            _values[49].Add(6);
            _values[49].Add(180.0);
            _values[49].Add(new List<double>() { 138.8 });

            _values[50].Add(16);
            _values[50].Add(new List<double>() { 5.5, 6 });
            _values[50].Add(6);
            _values[50].Add(205.0);
            _values[50].Add(new List<double>() { 121.5, 161.1 });

            _values[51].Add(17);
            _values[51].Add(new List<double>() { 6.5, 7 });
            _values[51].Add(4);
            _values[51].Add(100.0);
            _values[51].Add(new List<double>() { 60.1 });

            _values[52].Add(17);
            _values[52].Add(new List<double>() { 7.5 });
            _values[52].Add(4);
            _values[52].Add(108.0);
            _values[52].Add(new List<double>() { 65.1 });

            _values[53].Add(17);
            _values[53].Add(new List<double>() { 7 });
            _values[53].Add(5);
            _values[53].Add(100.0);
            _values[53].Add(new List<double>() { 56.1, 57.1 });

            _values[54].Add(17);
            _values[54].Add(new List<double>() { 7 });
            _values[54].Add(5);
            _values[54].Add(105.0);
            _values[54].Add(new List<double>() { 56.6 });

            _values[55].Add(17);
            _values[55].Add(new List<double>() { 7, 7.5, 8.5 });
            _values[55].Add(5);
            _values[55].Add(108.0);
            _values[55].Add(new List<double>() { 63.3, 65.1 });

            _values[56].Add(17);
            _values[56].Add(new List<double>() { 6.5, 7 });
            _values[56].Add(5);
            _values[56].Add(112.0);
            _values[56].Add(new List<double>() { 57.1, 66.6, 70.1 });

            _values[57].Add(17);
            _values[57].Add(new List<double>() { 6.5, 7 });
            _values[57].Add(5);
            _values[57].Add(114.3);
            _values[57].Add(new List<double>() { 60.1, 64.1, 67.1 });

            _values[58].Add(17);
            _values[58].Add(new List<double>() { 7, 7.5 });
            _values[58].Add(5);
            _values[58].Add(120.0);
            _values[58].Add(new List<double>() { 65.1, 72.6 });

            _values[59].Add(17);
            _values[59].Add(new List<double>() { 8 });
            _values[59].Add(5);
            _values[59].Add(127.0);
            _values[59].Add(new List<double>() { 75.1 });

            _values[60].Add(17);
            _values[60].Add(new List<double>() { 8 });
            _values[60].Add(5);
            _values[60].Add(139.7);
            _values[60].Add(new List<double>() { 110.1 });

            _values[61].Add(17);
            _values[61].Add(new List<double>() { 7, 7.5 });
            _values[61].Add(6);
            _values[61].Add(114.3);
            _values[61].Add(new List<double>() { 66.1 });

            _values[62].Add(17);
            _values[62].Add(new List<double>() { 7, 8 });
            _values[62].Add(6);
            _values[62].Add(139.7);
            _values[62].Add(new List<double>() { 100.1, 106.1, 110.1 });

            _values[63].Add(18);
            _values[63].Add(new List<double>() { 8 });
            _values[63].Add(5);
            _values[63].Add(108.0);
            _values[63].Add(new List<double>() { 70.1 });

            _values[64].Add(18);
            _values[64].Add(new List<double>() { 8 });
            _values[64].Add(5);
            _values[64].Add(112.0);
            _values[64].Add(new List<double>() { 70.1 });

            _values[65].Add(18);
            _values[65].Add(new List<double>() { 8 });
            _values[65].Add(5);
            _values[65].Add(114.3);
            _values[65].Add(new List<double>() { 71.6 });

            _values[66].Add(18);
            _values[66].Add(new List<double>() { 7.5 });
            _values[66].Add(6);
            _values[66].Add(114.3);
            _values[66].Add(new List<double>() { 66.1 });

            _values[67].Add(18);
            _values[67].Add(new List<double>() { 8 });
            _values[67].Add(6);
            _values[67].Add(139.7);
            _values[67].Add(new List<double>() { 106.1 });

            _values[68].Add(19);
            _values[68].Add(new List<double>() { 8, 8.5 });
            _values[68].Add(5);
            _values[68].Add(112.0);
            _values[68].Add(new List<double>() { 70.1 });

            _values[69].Add(19);
            _values[69].Add(new List<double>() { 8.5 });
            _values[69].Add(5);
            _values[69].Add(114.3);
            _values[69].Add(new List<double>() { 71.6 });

            CurrentValues = new object[5];
            CurrentValues[0] = new List<int> { 13, 14, 15, 16, 17, 18, 19 };
            ChangeCurrentValues(diskDiameter, boltsCount, boltArrangementDiameter);
        }

        public void ChangeCurrentValues (double diskDiameter)
        {
            var selectedDiameterLines = ChangeCurrentDiskDiameter(diskDiameter);
            var currentLine = selectedDiameterLines.First();
            CurrentValues[1] = currentLine[1];
            CurrentValues[4] = currentLine[4];
        }

        public void ChangeCurrentValues(double diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            var selectedDiameterLines = ChangeCurrentDiskDiameter(diskDiameter);
            var currentLine = selectedDiameterLines.Where(item => item[2].Equals(boltsCount) && item[3].Equals(boltArrangementDiameter)).First();
            CurrentValues[1] = currentLine[1];
            CurrentValues[4] = currentLine[4];
        }

        private List<List<object>> ChangeCurrentDiskDiameter (double diskDiameter)
        {
            var selectedDiameterLines = _values.Where(t => (int)t[0] == diskDiameter).ToList();
            var collectionBoltsCount = new List<int>();
            var collectionBoltArrangementDiameter = new List<double>();

            foreach (var line in selectedDiameterLines)
            {
                var boltsCountItem = (int)line[2];
                if(!collectionBoltsCount.Contains(boltsCountItem))
                {
                    collectionBoltsCount.Add(boltsCountItem);
                }

                var boltArrangementDiameterItem = (double)line[3];
                if (!collectionBoltArrangementDiameter.Contains(boltArrangementDiameterItem))
                {
                    collectionBoltArrangementDiameter.Add(boltArrangementDiameterItem);
                }
            }

            CurrentValues[2] = collectionBoltsCount;
            CurrentValues[3] = collectionBoltArrangementDiameter;
            return selectedDiameterLines;
        }
    }
}
