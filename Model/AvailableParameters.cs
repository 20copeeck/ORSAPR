using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Доступные параметры
    /// </summary>
    public class AvailableParameters
    {
        /// <summary>
        /// Зависимости доступных параметров
        /// </summary>
        private List<List<object>> _valuesRelations;
        /// <summary>
        /// Зависимости количеств вентиляционных отверстий
        /// </summary>
        private Dictionary<int, List<int>> _airVentsCountRelations;

        /// <summary>
        /// Доступные значения диаметра диска
        /// </summary>
        private List<int> _diskDiameterValues;
        /// <summary>
        /// Доступные значения ширины диска
        /// </summary>
        private List<double> _widthValues;
        /// <summary>
        /// Доступные значения количества болтов
        /// </summary>
        private List<int> _boltsCountValues;
        /// <summary>
        /// Доступные значения диаметра расположения болтов 
        /// </summary>
        private List<double> _boltArrangementDiameterValues;
        /// <summary>
        /// Доступные значения диаметра центрального отверстия
        /// </summary>
        private List<double> _centralHoleDiameterValues;
        /// <summary>
        /// Доступные значения количества вентиляционных отверстий
        /// </summary>
        private List<int> _airVentsCountValues;

        /// <summary>
        /// Доступные значения диаметра диска
        /// </summary>
        public IReadOnlyList<int> DiskDiameterValues => _diskDiameterValues.AsReadOnly();

        /// <summary>
        /// Доступные значения ширины диска
        /// </summary>
        public IReadOnlyList<double> WidthValues => _widthValues.AsReadOnly();

        /// <summary>
        /// Доступные значения количества болтов
        /// </summary>
        public IReadOnlyList<int> BoltsCountValues => _boltsCountValues.AsReadOnly();

        /// <summary>
        /// Доступные значения диаметра расположения болтов 
        /// </summary>
        public IReadOnlyList<double> BoltArrangementDiameterValues => 
            _boltArrangementDiameterValues.AsReadOnly();

        /// <summary>
        /// Доступные значения диаметра центрального отверстия
        /// </summary>
        public IReadOnlyList<double> CentralHoleDiameterValues => 
            _centralHoleDiameterValues.AsReadOnly();

        /// <summary>
        /// Доступные значения количества вентиляционных отверстий
        /// </summary>
        public IReadOnlyList<int> AirVentsCountValues => _airVentsCountValues.AsReadOnly();

        /// <summary>
        /// Максимальное значение диаметра вентиляцтонных отверстий
        /// </summary>
        public decimal MaxAirVentsDiameter { get; } = 40;
        /// <summary>
        /// Минимальное значение диаметра вентиляцтонных отверстий
        /// </summary>
        public decimal MinAirVentsDiameter { get; } = 15;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <param name="boltArrangementDiameter">Диаметр расположения болтов</param>
        public AvailableParameters
            (int diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            _valuesRelations = new List<List<object>>();

            for (int i = 0; i < 70; i++)
            {
                _valuesRelations.Add(new List<object>());
            }

            _valuesRelations[0].Add(13);
            _valuesRelations[0].Add(new List<double>() { 5, 5.5 });
            _valuesRelations[0].Add(4);
            _valuesRelations[0].Add(98.0);
            _valuesRelations[0].Add(new List<double>() { 58.6, 60.1 });

            _valuesRelations[1].Add(13);
            _valuesRelations[1].Add(new List<double>() { 4.5, 5, 5.5 });
            _valuesRelations[1].Add(4);
            _valuesRelations[1].Add(100.0);
            _valuesRelations[1].Add(new List<double>() { 54.1, 56.6, 57.1 });

            _valuesRelations[2].Add(13);
            _valuesRelations[2].Add(new List<double>() { 4.5, 5 });
            _valuesRelations[2].Add(4);
            _valuesRelations[2].Add(114.3);
            _valuesRelations[2].Add(new List<double>() { 69.1 });

            _valuesRelations[3].Add(14);
            _valuesRelations[3].Add(new List<double>() { 5, 5.5, 6 });
            _valuesRelations[3].Add(4);
            _valuesRelations[3].Add(98.0);
            _valuesRelations[3].Add(new List<double>() { 58.1, 58.6 });

            _valuesRelations[4].Add(14);
            _valuesRelations[4].Add(new List<double>() { 4.5, 5, 5.5, 6 });
            _valuesRelations[4].Add(4);
            _valuesRelations[4].Add(100.0);
            _valuesRelations[4].Add(new List<double>() { 54.1, 56.1, 56.6, 57.1, 60.1 });

            _valuesRelations[5].Add(14);
            _valuesRelations[5].Add(new List<double>() { 5.5 });
            _valuesRelations[5].Add(4);
            _valuesRelations[5].Add(108.0);
            _valuesRelations[5].Add(new List<double>() { 63.3, 65.1 });

            _valuesRelations[6].Add(14);
            _valuesRelations[6].Add(new List<double>() { 5.5 });
            _valuesRelations[6].Add(4);
            _valuesRelations[6].Add(114.3);
            _valuesRelations[6].Add(new List<double>() { 56.6, 66.1 });

            _valuesRelations[7].Add(14);
            _valuesRelations[7].Add(new List<double>() { 5, 6 });
            _valuesRelations[7].Add(5);
            _valuesRelations[7].Add(100.0);
            _valuesRelations[7].Add(new List<double>() { 57.1 });

            _valuesRelations[8].Add(14);
            _valuesRelations[8].Add(new List<double>() { 5.5 });
            _valuesRelations[8].Add(5);
            _valuesRelations[8].Add(120.0);
            _valuesRelations[8].Add(new List<double>() { 67.1 });

            _valuesRelations[9].Add(15);
            _valuesRelations[9].Add(new List<double>() { 4.5 });
            _valuesRelations[9].Add(3);
            _valuesRelations[9].Add(112.0);
            _valuesRelations[9].Add(new List<double>() { 57.1 });

            _valuesRelations[10].Add(15);
            _valuesRelations[10].Add(new List<double>() { 5.5, 6 });
            _valuesRelations[10].Add(4);
            _valuesRelations[10].Add(98.0);
            _valuesRelations[10].Add(new List<double>() { 58.1, 58.6 });

            _valuesRelations[11].Add(15);
            _valuesRelations[11].Add(new List<double>() { 5, 5.5, 6 });
            _valuesRelations[11].Add(4);
            _valuesRelations[11].Add(100.0);
            _valuesRelations[11].Add(new List<double>() { 54.1, 56.1, 56.6, 60.1 });

            _valuesRelations[12].Add(15);
            _valuesRelations[12].Add(new List<double>() { 6, 6.5 });
            _valuesRelations[12].Add(4);
            _valuesRelations[12].Add(108.0);
            _valuesRelations[12].Add(new List<double>() { 63.3, 65.1 });

            _valuesRelations[13].Add(15);
            _valuesRelations[13].Add(new List<double>() { 5.5, 6 });
            _valuesRelations[13].Add(4);
            _valuesRelations[13].Add(114.3);
            _valuesRelations[13].Add(new List<double>() { 56.6, 64.1, 66.1 });

            _valuesRelations[14].Add(15);
            _valuesRelations[14].Add(new List<double>() { 6 });
            _valuesRelations[14].Add(5);
            _valuesRelations[14].Add(98.0);
            _valuesRelations[14].Add(new List<double>() { 58.1 });

            _valuesRelations[15].Add(15);
            _valuesRelations[15].Add(new List<double>() { 5.5, 6 });
            _valuesRelations[15].Add(5);
            _valuesRelations[15].Add(100.0);
            _valuesRelations[15].Add(new List<double>() { 57.1 });

            _valuesRelations[16].Add(15);
            _valuesRelations[16].Add(new List<double>() { 6 });
            _valuesRelations[16].Add(5);
            _valuesRelations[16].Add(105.0);
            _valuesRelations[16].Add(new List<double>() { 56.6 });

            _valuesRelations[17].Add(15);
            _valuesRelations[17].Add(new List<double>() { 6 });
            _valuesRelations[17].Add(5);
            _valuesRelations[17].Add(108.0);
            _valuesRelations[17].Add(new List<double>() { 60.1, 63.3 });

            _valuesRelations[18].Add(15);
            _valuesRelations[18].Add(new List<double>() { 6 });
            _valuesRelations[18].Add(5);
            _valuesRelations[18].Add(110.0);
            _valuesRelations[18].Add(new List<double>() { 65.1 });

            _valuesRelations[19].Add(15);
            _valuesRelations[19].Add(new List<double>() { 6 });
            _valuesRelations[19].Add(5);
            _valuesRelations[19].Add(112.0);
            _valuesRelations[19].Add(new List<double>() { 57.1 });

            _valuesRelations[20].Add(15);
            _valuesRelations[20].Add(new List<double>() { 6, 6.5, 7, 8, 10 });
            _valuesRelations[20].Add(5);
            _valuesRelations[20].Add(114.3);
            _valuesRelations[20].Add(new List<double>() { 54.1, 60.1, 66.1, 67.1, 71.6, 84.1 });

            _valuesRelations[21].Add(15);
            _valuesRelations[21].Add(new List<double>() { 6 });
            _valuesRelations[21].Add(5);
            _valuesRelations[21].Add(118.0);
            _valuesRelations[21].Add(new List<double>() { 71.1 });

            _valuesRelations[22].Add(15);
            _valuesRelations[22].Add(new List<double>() { 6 });
            _valuesRelations[22].Add(5);
            _valuesRelations[22].Add(130.0);
            _valuesRelations[22].Add(new List<double>() { 84.1 });

            _valuesRelations[23].Add(15);
            _valuesRelations[23].Add(new List<double>() { 5.5, 6, 7, 8, 10 });
            _valuesRelations[23].Add(5);
            _valuesRelations[23].Add(139.7);
            _valuesRelations[23].Add(new List<double>() { 98.6, 110.1, 108.5 });

            _valuesRelations[24].Add(15);
            _valuesRelations[24].Add(new List<double>() { 5.5, 6.5 });
            _valuesRelations[24].Add(5);
            _valuesRelations[24].Add(160.0);
            _valuesRelations[24].Add(new List<double>() { 65.1 });

            _valuesRelations[25].Add(15);
            _valuesRelations[25].Add(new List<double>() { 8 });
            _valuesRelations[25].Add(5);
            _valuesRelations[25].Add(165.1);
            _valuesRelations[25].Add(new List<double>() { 131 });

            _valuesRelations[26].Add(15);
            _valuesRelations[26].Add(new List<double>() { 7, 8, 10 });
            _valuesRelations[26].Add(6);
            _valuesRelations[26].Add(139.7);
            _valuesRelations[26].Add(new List<double>() { 108.5, 110.1, 110.5 });

            _valuesRelations[27].Add(15);
            _valuesRelations[27].Add(new List<double>() { 5.5 });
            _valuesRelations[27].Add(6);
            _valuesRelations[27].Add(205.0);
            _valuesRelations[27].Add(new List<double>() { 161.1 });

            _valuesRelations[28].Add(16);
            _valuesRelations[28].Add(new List<double>() { 6, 6.5 });
            _valuesRelations[28].Add(4);
            _valuesRelations[28].Add(100.0);
            _valuesRelations[28].Add(new List<double>() { 54.1, 56.6, 60.1 });

            _valuesRelations[29].Add(16);
            _valuesRelations[29].Add(new List<double>() { 6, 6.5, 7 });
            _valuesRelations[29].Add(4);
            _valuesRelations[29].Add(108.0);
            _valuesRelations[29].Add(new List<double>() { 63.3, 65.1 });

            _valuesRelations[30].Add(16);
            _valuesRelations[30].Add(new List<double>() { 6 });
            _valuesRelations[30].Add(5);
            _valuesRelations[30].Add(98.0);
            _valuesRelations[30].Add(new List<double>() { 58.1 });

            _valuesRelations[31].Add(16);
            _valuesRelations[31].Add(new List<double>() { 6, 6.5 });
            _valuesRelations[31].Add(5);
            _valuesRelations[31].Add(100.0);
            _valuesRelations[31].Add(new List<double>() { 56.1, 57.1 });

            _valuesRelations[32].Add(16);
            _valuesRelations[32].Add(new List<double>() { 6.5 });
            _valuesRelations[32].Add(5);
            _valuesRelations[32].Add(105.0);
            _valuesRelations[32].Add(new List<double>() { 56.6 });

            _valuesRelations[33].Add(16);
            _valuesRelations[33].Add(new List<double>() { 6.5, 7 });
            _valuesRelations[33].Add(5);
            _valuesRelations[33].Add(108.0);
            _valuesRelations[33].Add(new List<double>() { 63.3, 65.1 });

            _valuesRelations[34].Add(16);
            _valuesRelations[34].Add(new List<double>() { 6.5 });
            _valuesRelations[34].Add(5);
            _valuesRelations[34].Add(110.0);
            _valuesRelations[34].Add(new List<double>() { 65.1 });

            _valuesRelations[35].Add(16);
            _valuesRelations[35].Add(new List<double>() { 6, 6.5, 7 });
            _valuesRelations[35].Add(5);
            _valuesRelations[35].Add(112.0);
            _valuesRelations[35].Add(new List<double>() { 57.1, 66.6, 70.1 });

            _valuesRelations[36].Add(16);
            _valuesRelations[36].Add(new List<double>() { 6, 6.5, 7, 8 });
            _valuesRelations[36].Add(5);
            _valuesRelations[36].Add(114.3);
            _valuesRelations[36].Add(new List<double>() { 54.1, 60.1, 64.1, 66.1, 67.1, 71.6, 
                84.1 });

            _valuesRelations[37].Add(16);
            _valuesRelations[37].Add(new List<double>() { 6.5 });
            _valuesRelations[37].Add(5);
            _valuesRelations[37].Add(115.0);
            _valuesRelations[37].Add(new List<double>() { 70.1 });

            _valuesRelations[38].Add(16);
            _valuesRelations[38].Add(new List<double>() { 6 });
            _valuesRelations[38].Add(5);
            _valuesRelations[38].Add(118.0);
            _valuesRelations[38].Add(new List<double>() { 71.1 });

            _valuesRelations[39].Add(16);
            _valuesRelations[39].Add(new List<double>() { 6.5, 7 });
            _valuesRelations[39].Add(5);
            _valuesRelations[39].Add(120.0);
            _valuesRelations[39].Add(new List<double>() { 65.1, 67.1, 72.6 });

            _valuesRelations[40].Add(16);
            _valuesRelations[40].Add(new List<double>() { 8 });
            _valuesRelations[40].Add(5);
            _valuesRelations[40].Add(127.0);
            _valuesRelations[40].Add(new List<double>() { 75.1 });

            _valuesRelations[41].Add(16);
            _valuesRelations[41].Add(new List<double>() { 6, 6.5, 8 });
            _valuesRelations[41].Add(5);
            _valuesRelations[41].Add(130.0);
            _valuesRelations[41].Add(new List<double>() { 78.1, 84.1, 89.1 });

            _valuesRelations[42].Add(16);
            _valuesRelations[42].Add(new List<double>() { 6.5, 7, 8, 10 });
            _valuesRelations[42].Add(5);
            _valuesRelations[42].Add(139.7);
            _valuesRelations[42].Add(new List<double>() { 95.3, 98.1, 98.6, 108.5, 110.1 });

            _valuesRelations[43].Add(16);
            _valuesRelations[43].Add(new List<double>() { 8, 10 });
            _valuesRelations[43].Add(5);
            _valuesRelations[43].Add(150.0);
            _valuesRelations[43].Add(new List<double>() { 110.1, 110.5 });

            _valuesRelations[44].Add(16);
            _valuesRelations[44].Add(new List<double>() { 5.5, 6.5 });
            _valuesRelations[44].Add(5);
            _valuesRelations[44].Add(160.0);
            _valuesRelations[44].Add(new List<double>() { 65.1 });

            _valuesRelations[45].Add(16);
            _valuesRelations[45].Add(new List<double>() { 7 });
            _valuesRelations[45].Add(5);
            _valuesRelations[45].Add(165.0);
            _valuesRelations[45].Add(new List<double>() { 122.5 });

            _valuesRelations[46].Add(16);
            _valuesRelations[46].Add(new List<double>() { 5.5, 6.5 });
            _valuesRelations[46].Add(6);
            _valuesRelations[46].Add(130.0);
            _valuesRelations[46].Add(new List<double>() { 84.1 });

            _valuesRelations[47].Add(16);
            _valuesRelations[47].Add(new List<double>() { 6.5, 7, 8, 10 });
            _valuesRelations[47].Add(6);
            _valuesRelations[47].Add(139.7);
            _valuesRelations[47].Add(new List<double>() { 67.1, 92.5, 106.1, 108.5, 110.1 });

            _valuesRelations[48].Add(16);
            _valuesRelations[48].Add(new List<double>() { 5.5 });
            _valuesRelations[48].Add(6);
            _valuesRelations[48].Add(170.0);
            _valuesRelations[48].Add(new List<double>() { 130.1 });

            _valuesRelations[49].Add(16);
            _valuesRelations[49].Add(new List<double>() { 5, 6 });
            _valuesRelations[49].Add(6);
            _valuesRelations[49].Add(180.0);
            _valuesRelations[49].Add(new List<double>() { 138.8 });

            _valuesRelations[50].Add(16);
            _valuesRelations[50].Add(new List<double>() { 5.5, 6 });
            _valuesRelations[50].Add(6);
            _valuesRelations[50].Add(205.0);
            _valuesRelations[50].Add(new List<double>() { 121.5, 161.1 });

            _valuesRelations[51].Add(17);
            _valuesRelations[51].Add(new List<double>() { 6.5, 7 });
            _valuesRelations[51].Add(4);
            _valuesRelations[51].Add(100.0);
            _valuesRelations[51].Add(new List<double>() { 60.1 });

            _valuesRelations[52].Add(17);
            _valuesRelations[52].Add(new List<double>() { 7.5 });
            _valuesRelations[52].Add(4);
            _valuesRelations[52].Add(108.0);
            _valuesRelations[52].Add(new List<double>() { 65.1 });

            _valuesRelations[53].Add(17);
            _valuesRelations[53].Add(new List<double>() { 7 });
            _valuesRelations[53].Add(5);
            _valuesRelations[53].Add(100.0);
            _valuesRelations[53].Add(new List<double>() { 56.1, 57.1 });

            _valuesRelations[54].Add(17);
            _valuesRelations[54].Add(new List<double>() { 7 });
            _valuesRelations[54].Add(5);
            _valuesRelations[54].Add(105.0);
            _valuesRelations[54].Add(new List<double>() { 56.6 });

            _valuesRelations[55].Add(17);
            _valuesRelations[55].Add(new List<double>() { 7, 7.5, 8.5 });
            _valuesRelations[55].Add(5);
            _valuesRelations[55].Add(108.0);
            _valuesRelations[55].Add(new List<double>() { 63.3, 65.1 });

            _valuesRelations[56].Add(17);
            _valuesRelations[56].Add(new List<double>() { 6.5, 7 });
            _valuesRelations[56].Add(5);
            _valuesRelations[56].Add(112.0);
            _valuesRelations[56].Add(new List<double>() { 57.1, 66.6, 70.1 });

            _valuesRelations[57].Add(17);
            _valuesRelations[57].Add(new List<double>() { 6.5, 7 });
            _valuesRelations[57].Add(5);
            _valuesRelations[57].Add(114.3);
            _valuesRelations[57].Add(new List<double>() { 60.1, 64.1, 67.1 });

            _valuesRelations[58].Add(17);
            _valuesRelations[58].Add(new List<double>() { 7, 7.5 });
            _valuesRelations[58].Add(5);
            _valuesRelations[58].Add(120.0);
            _valuesRelations[58].Add(new List<double>() { 65.1, 72.6 });

            _valuesRelations[59].Add(17);
            _valuesRelations[59].Add(new List<double>() { 8 });
            _valuesRelations[59].Add(5);
            _valuesRelations[59].Add(127.0);
            _valuesRelations[59].Add(new List<double>() { 75.1 });

            _valuesRelations[60].Add(17);
            _valuesRelations[60].Add(new List<double>() { 8 });
            _valuesRelations[60].Add(5);
            _valuesRelations[60].Add(139.7);
            _valuesRelations[60].Add(new List<double>() { 110.1 });

            _valuesRelations[61].Add(17);
            _valuesRelations[61].Add(new List<double>() { 7, 7.5 });
            _valuesRelations[61].Add(6);
            _valuesRelations[61].Add(114.3);
            _valuesRelations[61].Add(new List<double>() { 66.1 });

            _valuesRelations[62].Add(17);
            _valuesRelations[62].Add(new List<double>() { 7, 8 });
            _valuesRelations[62].Add(6);
            _valuesRelations[62].Add(139.7);
            _valuesRelations[62].Add(new List<double>() { 100.1, 106.1, 110.1 });

            _valuesRelations[63].Add(18);
            _valuesRelations[63].Add(new List<double>() { 8 });
            _valuesRelations[63].Add(5);
            _valuesRelations[63].Add(108.0);
            _valuesRelations[63].Add(new List<double>() { 70.1 });

            _valuesRelations[64].Add(18);
            _valuesRelations[64].Add(new List<double>() { 8 });
            _valuesRelations[64].Add(5);
            _valuesRelations[64].Add(112.0);
            _valuesRelations[64].Add(new List<double>() { 70.1 });

            _valuesRelations[65].Add(18);
            _valuesRelations[65].Add(new List<double>() { 8 });
            _valuesRelations[65].Add(5);
            _valuesRelations[65].Add(114.3);
            _valuesRelations[65].Add(new List<double>() { 71.6 });

            _valuesRelations[66].Add(18);
            _valuesRelations[66].Add(new List<double>() { 7.5 });
            _valuesRelations[66].Add(6);
            _valuesRelations[66].Add(114.3);
            _valuesRelations[66].Add(new List<double>() { 66.1 });

            _valuesRelations[67].Add(18);
            _valuesRelations[67].Add(new List<double>() { 8 });
            _valuesRelations[67].Add(6);
            _valuesRelations[67].Add(139.7);
            _valuesRelations[67].Add(new List<double>() { 106.1 });

            _valuesRelations[68].Add(19);
            _valuesRelations[68].Add(new List<double>() { 8, 8.5 });
            _valuesRelations[68].Add(5);
            _valuesRelations[68].Add(112.0);
            _valuesRelations[68].Add(new List<double>() { 70.1 });

            _valuesRelations[69].Add(19);
            _valuesRelations[69].Add(new List<double>() { 8.5 });
            _valuesRelations[69].Add(5);
            _valuesRelations[69].Add(114.3);
            _valuesRelations[69].Add(new List<double>() { 71.6 });

            _airVentsCountRelations = new Dictionary<int, List<int>>()
            {
                {13, new List<int> { 10, 11, 12 }},
                {14, new List<int> { 10, 11, 12, 13, 14 }},
                {15, new List<int> { 10, 11, 12, 13, 14 }},
                {16, new List<int> { 12, 13, 14, 15, 16 }},
                {17, new List<int> { 12, 13, 14, 15, 16 }},
                {18, new List<int> { 14, 15, 16, 17, 18 }},
                {19, new List<int> { 16, 17, 18, 19, 20 }}
            };

            _diskDiameterValues = new List<int> { 13, 14, 15, 16, 17, 18, 19 };

            ChangeDiskDiameterDependentQuantities(diskDiameter);
            ChangeBoltsCountDependentQuantities(diskDiameter, boltsCount);
            ChangeBoltArrangementDiameterDependentQuantities
                (diskDiameter, boltsCount, boltArrangementDiameter);
        }

        /// <summary>
        /// Изменить зависимые значения для диаметра диска
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        public void ChangeDiskDiameterDependentQuantities(int diskDiameter)
        {
            if (!DiskDiameterValues.Any(value => value == diskDiameter))
            {
                throw new ArgumentException("Неверное значение диаметра диска");
            }
            var selectedDiskDiameterLines = ChangeDependentCounts(diskDiameter);
            var selectedBoltsCountLines = ChangeDependentBoltArrangementDiameter
                (diskDiameter, (int)selectedDiskDiameterLines.First()[2]);

            var currentLine = selectedDiskDiameterLines.First();
            _widthValues = (List<double>)currentLine[1];
            _centralHoleDiameterValues = (List<double>)currentLine[4];

            ValuesChanged?.Invoke(this, new ValuesChangeEventArgs
                (AvailableValuesChangeType.DiskDiameterChanged));
        }

        /// <summary>
        /// Изменить зависимые значения для количества болтов
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        public void ChangeBoltsCountDependentQuantities(int diskDiameter, int boltsCount)
        {
            if (!DiskDiameterValues.Any(value => value == diskDiameter))
            {
                throw new ArgumentException("Неверное значение диаметра диска");
            }
            if (!BoltsCountValues.Any(value => value == boltsCount))
            {
                throw new ArgumentException("Неверное значение количества болтов");
            }
            var selectedBoltsCountLines = ChangeDependentBoltArrangementDiameter
                (diskDiameter, boltsCount);

            var currentLine = selectedBoltsCountLines.First();
            _widthValues = (List<double>)currentLine[1];
            _centralHoleDiameterValues = (List<double>)currentLine[4];

            ValuesChanged?.Invoke(this, new ValuesChangeEventArgs
                (AvailableValuesChangeType.BoltsCountChanged));
        }

        /// <summary>
        /// Изменить зависимые значения для диаметра расположения болтов
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <param name="boltArrangementDiameter">Диаметр расположения болтов</param>
        public void ChangeBoltArrangementDiameterDependentQuantities
            (int diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            if (!DiskDiameterValues.Any(value => value == diskDiameter))
            {
                throw new ArgumentException("Неверное значение диаметра диска");
            }
            if (!BoltsCountValues.Any(value => value == boltsCount))
            {
                throw new ArgumentException("Неверное значение количества болтов");
            }
            if (!BoltArrangementDiameterValues.Any(value => value == boltArrangementDiameter))
            {
                throw new ArgumentException("Неверное значение диаметра расположения болтов");
            }
            var selectedBoltsCountLines = _valuesRelations.Where
                (item => (int)item[0] == diskDiameter && (int)item[2] == boltsCount).ToList();

            var currentLine = selectedBoltsCountLines.Where
                (item => ((double)item[3]).EqualTo(boltArrangementDiameter)).First();
            _widthValues = (List<double>)currentLine[1];
            _centralHoleDiameterValues = (List<double>)currentLine[4];

            ValuesChanged?.Invoke(this, new ValuesChangeEventArgs
                (AvailableValuesChangeType.BoltArrangementDiameterChanged));
        }

        /// <summary>
        /// Изменить зависимые параметры количества
        /// болтов и венлиляционных отверстий
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <returns>Допустимые зависимости для текущего диаметра</returns>
        private List<List<object>> ChangeDependentCounts(int diskDiameter)
        {
            _airVentsCountValues = _airVentsCountRelations[diskDiameter];

            var selectedDiskDiameterLines = _valuesRelations.Where
                (item => (int)item[0] == diskDiameter).ToList();
            var collectionBoltsCount = new List<int>();

            foreach (var line in selectedDiskDiameterLines)
            {
                var boltsCountItem = (int)line[2];
                if (!collectionBoltsCount.Contains(boltsCountItem))
                {
                    collectionBoltsCount.Add(boltsCountItem);
                }
            }

            _boltsCountValues = collectionBoltsCount;
            return selectedDiskDiameterLines;
        }

        /// <summary>
        /// Изменить зависимый параметр диаметра расположения болтов
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="boltsCount">Количество болтов</param>
        /// <returns>Допустимые зависимости для текущего количества болтов</returns>
        private List<List<object>> ChangeDependentBoltArrangementDiameter
            (int diskDiameter, int boltsCount)
        {
            var selectedBoltsCountLines = _valuesRelations.Where
                (item => (int)item[0] == diskDiameter && (int)item[2] == boltsCount).ToList();

            var collectionBoltArrangementDiameter = new List<double>();

            foreach (var line in selectedBoltsCountLines)
            {
                var boltArrangementDiameterItem = (double)line[3];
                if (!collectionBoltArrangementDiameter.Contains(boltArrangementDiameterItem))
                {
                    collectionBoltArrangementDiameter.Add(boltArrangementDiameterItem);
                }
            }

            _boltArrangementDiameterValues = collectionBoltArrangementDiameter;

            return selectedBoltsCountLines;
        }

        /// <summary>
        /// Событие изменения доступных параметров
        /// </summary>
        public event EventHandler<ValuesChangeEventArgs> ValuesChanged;
    }
}
