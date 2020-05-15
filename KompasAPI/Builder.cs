using Kompas6API5;
using Kompas6Constants3D;
using System;
using Model;

namespace KompasAPI
{
    /// <summary>
    /// Отрисовщик-построитель диска
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Объект подключения к Компас API 
        /// </summary>
        private KompasConnector _kompasConnector;
        /// <summary>
        /// Объект Компаса
        /// </summary>
        private KompasObject _kompas;
        /// <summary>
        /// Указатель на интерфейс, компонент сборки
        /// </summary>
        private ksPart _part;

        /// <summary>
        /// Торцевая линия лицевой стороны обода
        /// </summary>
        private LineSegment _endLineOfFrontSideRim;
        /// <summary>
        /// Верхняя горизонтальная линия боковой закраины лицевой стороны
        /// </summary>
        private LineSegment _topHorizontalLineOfFrontSideFlange;
        /// <summary>
        /// Внутренняя вертикальная линия боковой закраины лицевой стороны
        /// </summary>
        private LineSegment _innerVerticalLineOfFrontSideFlange;
        /// <summary>
        /// Верхняя линия полки лицевой стороны
        /// </summary>
        private LineSegment _topLineShelfOfFrontSide;
        /// <summary>
        /// Верхняя линия скоса полки лицевой стороны
        /// </summary>
        private LineSegment _topBevelLineShelfOfFrontSide;
        /// <summary>
        /// Верхняя линия центральной плоскости обода
        /// </summary>
        private LineSegment _topLineOfCentralPlaneRim;
        /// <summary>
        /// Верхняя линия скоса полки задней стороны
        /// </summary>
        private LineSegment _topBevelLineShelfOfBackSide;
        /// <summary>
        /// Верхняя линия полки задней стороны
        /// </summary>
        private LineSegment _topLineShelfOfBackSide;
        /// <summary>
        /// Внутренняя вертикальная линия боковой закраины задней стороны
        /// </summary>
        private LineSegment _innerVerticalLineOfBackSideFlange;
        /// <summary>
        /// Верхняя горизонтальная линия боковой закраины задней стороны
        /// </summary>
        private LineSegment _topHorizontalLineOfBackSideFlange;
        /// <summary>
        /// Торцевая линия задней стороны обода
        /// </summary>
        private LineSegment _endLineOfBackSideRim;
        /// <summary>
        ///  Нижняя горизонтальная линия боковой закраины лицевой стороны
        /// </summary>
        private LineSegment _bottomHorizontalLineOfFrontSideFlange;
        /// <summary>
        /// Наружняя вертикальная линия боковой закраины лицевой стороны
        /// </summary>
        private LineSegment _outerVerticalLineOfFrontSideFlange;
        /// <summary>
        /// Нижняя линия полки лицевой стороны
        /// </summary>
        private LineSegment _bottomLineShelfOfFrontSide;
        /// <summary>
        /// Нижняя линия скоса полки лицевой стороны
        /// </summary>
        private LineSegment _bottomBevelLineShelfOfFrontSide;
        /// <summary>
        /// Нижний левый отрезок центральной плоскости обода
        /// </summary>
        private LineSegment _bottomLeftLineOfCentralPlaneRim;
        /// <summary>
        /// Нижний правый отрезок центральной плоскости обода
        /// </summary>
        private LineSegment _bottomRightLineOfCentralPlaneRim;
        /// <summary>
        /// Нижняя линия скоса полки задней стороны
        /// </summary>
        private LineSegment _bottmBevelLineShelfOfBackSide;
        /// <summary>
        /// Нижняя линия полки задней стороны
        /// </summary>
        private LineSegment _bottomLineShelfOfBackSide;
        /// <summary>
        /// Наружняя вертикальная линия боковой закраины задней стороны
        /// </summary>
        private LineSegment _outerVerticalLineOfBackSideFlange;
        /// <summary>
        /// Нижняя горизонтальная линия боковой закраины задней стороны
        /// </summary>
        private LineSegment _bottomHorizontalLineOfBackSideFlange;
        /// <summary>
        /// Линия верхнего торца колесного диска
        /// </summary>
        private LineSegment _lineOfTopEndOfWheelDisk;
        /// <summary>
        /// Горизонтальная линия плоскости крепления 
        /// колесного диска к ободу
        /// </summary>
        private LineSegment _horizontalLineOfPlaneAttachmentWheelDiskToRim;
        /// <summary>
        /// Внутреняя линяя плоскости вентиляционных отверстий
        /// </summary>
        private LineSegment _innerLineOfPlaneVents;
        /// <summary>
        /// Внутренняя линия скоса под плоскостью 
        /// вентиляционных отверстий
        /// </summary>
        private LineSegment _innerBevelLineUnderPlaneVents;
        /// <summary>
        /// Внутренняя линия плоскости крепления диска
        /// </summary>
        private LineSegment _innerLineToPlaneOfMountingDisk;
        /// <summary>
        /// Внутренняя линия плоскости крепежных отверстий
        /// </summary>
        private LineSegment _innerLineOfMountingHolePlane;
        /// <summary>
        /// Верхняя линия крепежного торца диска
        /// </summary>
        private LineSegment _topLineOfMountingEndOfWheelDisk;
        /// <summary>
        /// Торцевая линия плоскости крепления колесного диска
        /// </summary>
        private LineSegment _endLineOfMountingPlaneWheelDisk;
        /// <summary>
        /// Нижняя линия крепежного торца диска
        /// </summary>
        private LineSegment _bottomLineOfMountingEndOfWheelDisk;
        /// <summary>
        /// Внешняя линия плоскости крепежных отверстий
        /// </summary>
        private LineSegment _outerLineOfMountingHolePlane;
        /// <summary>
        /// Внешняя линия плоскости крепления диска
        /// </summary>
        private LineSegment _outerLineToPlaneOfMountingDisk;
        /// <summary>
        /// Внешняя линия скоса под плоскостью 
        /// вентиляционных отверстий
        /// </summary>
        private LineSegment _outerBevelLineUnderPlaneVents;
        /// <summary>
        /// Внешняя линяя плоскости вентиляционных отверстий
        /// </summary>
        private LineSegment _outerLineOfPlaneVents;
        /// <summary>
        /// Линия для хампа
        /// </summary>
        private LineSegment _humpLine;
        /// <summary>
        /// Осевая линия OX
        /// </summary>
        private LineSegment _centerLineOX;

        /// <summary>
        /// Верхняя дуга боковой закраины лицевой стороны
        /// </summary>
        private ArcSegment _topArcOfFrontSideFlange;
        /// <summary>
        /// Верхняя дуга полки лицевой стороны
        /// </summary>
        private ArcSegment _topArcShelfOfFrontSide;
        /// <summary>
        /// Верхняя дуга скоса полки лицевой стороны
        /// </summary>
        private ArcSegment _topArcOfBevelShelvesOfFrontSide;
        /// <summary>
        /// Верхняя левая дуга центральной плоскости обода
        /// </summary>
        private ArcSegment _topLeftArcOfCentalPlaneRim;
        /// <summary>
        /// Верхняя правая дуга центральной плоскости обода
        /// </summary>
        private ArcSegment _topRightArcOfCentalPlaneRim;
        /// <summary>
        /// Верхняя дуга скоса полки задней стороны
        /// </summary>
        private ArcSegment _topArcOfBevelShelvesOfBackSide;
        /// <summary>
        /// Верхняя дуга полки задней стороны
        /// </summary>
        private ArcSegment _topArcShelfOfBackSide;
        /// <summary>
        /// Верхняя дуга боковой закраины задней стороны
        /// </summary>
        private ArcSegment _topArcOfBackSideFlange;
        /// <summary>
        /// Нижняя дуга боковой закраины лицевой стороны
        /// </summary>
        private ArcSegment _bottomArcOfFrontSideFlange;
        /// <summary>
        /// Нижняя дуга полки лицевой стороны
        /// </summary>
        private ArcSegment _bottomArcShelfOfFrontSide;
        /// <summary>
        /// Нижняя дуга скоса полки лицевой стороны
        /// </summary>
        private ArcSegment _bottomArcOfBevelShelvesOfFrontSide;
        /// <summary>
        /// Нижняя левая дуга центральной плоскости обода
        /// </summary>
        private ArcSegment _bottomLeftArcOfCentalPlaneRim;
        /// <summary>
        /// Нижняя правая дуга центральной плоскости обода
        /// </summary>
        private ArcSegment _bottomRightArcOfCentalPlaneRim;
        /// <summary>
        /// Нижняя дуга скоса полки задней стороны
        /// </summary>
        private ArcSegment _bottomArcOfBevelShelvesOfBackSide;
        /// <summary>
        /// Нижняя дуга полки задней стороны
        /// </summary>
        private ArcSegment _bottomArcShelfOfBackSide;
        /// <summary>
        /// Нижняя дуга боковой закраины задней стороны
        /// </summary>
        private ArcSegment _bottomArcOfBackSideFlange;
        /// <summary>
        /// Внутреняя дуга плоскости вентиляционных отверстий
        /// </summary>
        private ArcSegment _innerArcOfVentsplane;
        /// <summary>
        /// Внутренняя дуга скоса под плоскостью 
        /// вентиляционных отверстий
        /// </summary>
        private ArcSegment _innerArcBevelUnderPlaneVents;
        /// <summary>
        /// Верхняя внутренняя дуга плоскости крепления диска
        /// </summary>
        private ArcSegment _topInnerArcOfPlaneOfMountingDisk;
        /// <summary>
        /// Нижняя внутренняя дуга плоскости крепления диска
        /// </summary>
        private ArcSegment _bottomInnerArcOfPlaneOfMountingDisk;
        /// <summary>
        /// Верхняя внутренняя дуга плоскости крепежных отверстий
        /// </summary>
        private ArcSegment _topInnerArcOfMountingHolePlane;
        /// <summary>
        /// Нижняя внутренняя дуга плоскости крепежных отверстий
        /// </summary>
        private ArcSegment _bottomInnerArcOfMountingHolePlane;
        /// <summary>
        /// Нижняя внешняя дуга плоскости крепежных отверстий
        /// </summary>
        private ArcSegment _bottomOuterArcOfMountingHolePlane;
        /// <summary>
        /// Верхняя внешняя дуга плоскости крепежных отверстий
        /// </summary>
        private ArcSegment _topOuterArcOfMountingHolePlane;
        /// <summary>
        /// Нижняя внешняя дуга плоскости крепления диска
        /// </summary>
        private ArcSegment _bottomOuterArcOfPlaneOfMountingDisk;
        /// <summary>
        /// Верхняя внешняя дуга плоскости крепления диска
        /// </summary>
        private ArcSegment _topOuterArcOfPlaneOfMountingDisk;
        /// <summary>
        /// Внешняя дуга скоса под плоскостью 
        /// вентиляционных отверстий
        /// </summary>
        private ArcSegment _outerArcBevelUnderPlaneVents;
        /// <summary>
        /// Внешняя дуга плоскости вентиляционных отверстий
        /// </summary>
        private ArcSegment _outerArcOfVentsplane;
        /// <summary>
        /// Верхняя духа хампа
        /// </summary>
        private ArcSegment _topArcHump;
        /// <summary>
        /// Дуга основания хампа
        /// </summary>
        private ArcSegment _baseArcHump;

        /// <summary>
        /// Подключение к Компас API
        /// </summary>
        public KompasConnector KompasConnector
        {
            get
            {
                if (_kompasConnector == null)
                {
                    _kompasConnector = new KompasConnector();
                }
                return _kompasConnector;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Builder()
        {
            _endLineOfFrontSideRim = 
                new LineSegment((0, 216.938908), (0, 221.138908));
            _topHorizontalLineOfFrontSideFlange = 
                new LineSegment((0, 221.138908), (3.3, 221.138908));
            _innerVerticalLineOfFrontSideFlange = 
                new LineSegment((13, 211.438908), (13, 211.169558));
            _topLineShelfOfFrontSide = 
                new LineSegment((20.302754, 203.2), (30.967828, 202.266927));
            _topBevelLineShelfOfFrontSide = 
                new LineSegment((39.237435, 195.921434), (40.717837, 191.854063));
            _topLineOfCentralPlaneRim = 
                new LineSegment((49.832856, 185.471659), (95.89835, 185.471659));
            _topBevelLineShelfOfBackSide = 
                new LineSegment((154.428192, 201.597111), (98.530815, 185.8357));
            _topLineShelfOfBackSide = 
                new LineSegment((170.797246, 203.2), (156.215246, 201.92424));
            _innerVerticalLineOfBackSideFlange = 
                new LineSegment((178.1, 211.438908), (178.1, 211.169558));
            _topHorizontalLineOfBackSideFlange = 
                new LineSegment((187.8, 221.138908), (191.1, 221.138908));
            _endLineOfBackSideRim = 
                new LineSegment((191.1, 216.938908), (191.1, 221.138908));
            _bottomHorizontalLineOfFrontSideFlange = 
                new LineSegment((0, 216.938908), (3.3, 216.938908));
            _outerVerticalLineOfFrontSideFlange = 
                new LineSegment((8.8, 211.438908), (8.8, 211.169558));
            _bottomLineShelfOfFrontSide = 
                new LineSegment((30.601773, 198.082909), (19.9367, 199.015982));
            _bottomBevelLineShelfOfFrontSide = 
                new LineSegment((36.771128, 190.417579), (35.290726, 194.484949));
            _bottomLeftLineOfCentralPlaneRim = 
                new LineSegment((53.280301, 181.271659), (49.832856, 181.271659));
            _bottomRightLineOfCentralPlaneRim = 
                new LineSegment((95.846251, 181.271659), (89, 181.271659));
            _bottmBevelLineShelfOfBackSide = 
                new LineSegment((155.171888, 197.519024), (99.632216, 181.797188));
            _bottomLineShelfOfBackSide = 
                new LineSegment((156.190575, 197.706038), (171.1633, 199.015982));
            _outerVerticalLineOfBackSideFlange = 
                new LineSegment((182.3, 211.438908), (182.3, 211.169558));
            _bottomHorizontalLineOfBackSideFlange = 
                new LineSegment((191.1, 216.938908), (187.8, 216.938908));
            _lineOfTopEndOfWheelDisk = 
                new LineSegment((89, 181.271659), (89, 177.071659));
            _horizontalLineOfPlaneAttachmentWheelDiskToRim = 
                new LineSegment((89, 177.071659), (53.280301, 177.071659));
            _innerLineOfPlaneVents = 
                new LineSegment((44.489115, 171.471056), (30.474023, 141.415595));
            _innerBevelLineUnderPlaneVents = 
                new LineSegment((62.15, 110.267908), (35.430978, 125.694142));
            _innerLineToPlaneOfMountingDisk = 
                new LineSegment((67, 91.999746), (67, 101.867462));
            _innerLineOfMountingHolePlane = 
                new LineSegment((62.8, 59.75), (62.8, 79.944871));
            _topLineOfMountingEndOfWheelDisk = 
                new LineSegment((64.1, 58.45), (67, 58.45));
            _endLineOfMountingPlaneWheelDisk = 
                new LineSegment((67, 54.25), (67, 58.45));
            _bottomLineOfMountingEndOfWheelDisk = 
                new LineSegment((64.1, 54.25), (67, 54.25));
            _outerLineOfMountingHolePlane = 
                new LineSegment((58.6, 79.944871), (58.6, 59.75));
            _outerLineToPlaneOfMountingDisk = 
                new LineSegment((62.8, 91.999746), (62.8, 101.867462));
            _outerBevelLineUnderPlaneVents = 
                new LineSegment((60.05, 106.630601), (33.330978, 122.056836));
            _outerLineOfPlaneVents = 
                new LineSegment((40.682622, 173.246052), (26.667531, 143.190592));
            _humpLine = 
                new LineSegment((39.237435, 195.921434), (37.396914, 200.978224));
            _centerLineOX = new LineSegment((0, 0), (100, 0));

            _topArcOfFrontSideFlange = 
                new ArcSegment((3.3, 211.438908), 9.7, 
                (3.3, 221.138908), (13, 211.438908));
            _topArcShelfOfFrontSide = 
                new ArcSegment((21, 211.169558), 8, 
                (13, 211.169558), (20.302754, 203.2));
            _topArcOfBevelShelvesOfFrontSide = 
                new ArcSegment((30.122417, 192.603838), 9.7, 
                (30.967828, 202.266927), (39.237435, 195.921434));
            _topLeftArcOfCentalPlaneRim = 
                new ArcSegment((49.832856, 195.171659), 9.7, 
                (40.717837, 191.854063), (49.832856, 185.471659));
            _topRightArcOfCentalPlaneRim = 
                new ArcSegment((95.89835, 195.171659), 9.7, 
                (95.89835, 185.471659), (98.530815, 185.8357));
            _topArcOfBevelShelvesOfBackSide = 
                new ArcSegment((157.060657, 192.261152), 9.7, 
                (154.428192, 201.597111), (156.215246, 201.92424));
            _topArcShelfOfBackSide = 
                new ArcSegment((170.1, 211.169558), 8, 
                (170.797246, 203.2), (178.1, 211.169558));
            _topArcOfBackSideFlange = 
                new ArcSegment((187.8, 211.438908), 9.7, 
                (178.1, 211.438908), (187.8, 221.138908));
            _bottomArcOfFrontSideFlange = 
                new ArcSegment((3.3, 211.438908), 5.5, 
                (3.3, 216.938908), (8.8, 211.438908));
            _bottomArcShelfOfFrontSide = 
                new ArcSegment((21, 211.169558), 12.2, 
                (8.8, 211.169558), (19.9367, 199.015982));
            _bottomArcOfBevelShelvesOfFrontSide = 
                new ArcSegment((30.122417, 192.603838), 5.5, 
                (30.601773, 198.082909), (35.290726, 194.484949));
            _bottomLeftArcOfCentalPlaneRim = 
                new ArcSegment((49.832856, 195.171659), 13.9, 
                (36.771128, 190.417579), (49.832856, 181.271659));
            _bottomRightArcOfCentalPlaneRim = 
                new ArcSegment((95.846251, 195.171659), 13.9, 
                (95.846251, 181.271659), (99.632216, 181.797188));
            _bottomArcOfBevelShelvesOfBackSide = 
                new ArcSegment((156.669932, 192.226968), 5.5, 
                (155.171888, 197.519024), (156.190575, 197.706038));
            _bottomArcShelfOfBackSide = 
                new ArcSegment((170.1, 211.169557), 12.2, 
                (171.1633, 199.015982), (182.3, 211.169558));
            _bottomArcOfBackSideFlange = 
                new ArcSegment((187.8, 211.438908), 5.5, 
                (182.3, 211.438908), (187.8, 216.938908));
            _innerArcOfVentsplane = 
                new ArcSegment((53.280301, 167.371659), 9.7, 
                (53.280301, 177.071659), (44.489115, 171.471056));
            _innerArcBevelUnderPlaneVents = 
                new ArcSegment((41.530978, 136.259652), 12.2, 
                (30.474023, 141.415595), (35.430978, 125.694142));
            _topInnerArcOfPlaneOfMountingDisk = 
                new ArcSegment((57.3, 101.867462), 9.7, 
                (62.15, 110.267908), (67, 101.867462));
            _bottomInnerArcOfPlaneOfMountingDisk = 
                new ArcSegment((53.1, 91.999746), 13.9, 
                (67, 91.999746), (63.990722, 83.36249));
            _topInnerArcOfMountingHolePlane = 
                new ArcSegment((68.3, 79.944871), 5.5, 
                (63.990722, 83.36249), (62.8, 79.944871));
            _bottomInnerArcOfMountingHolePlane = 
                new ArcSegment((64.1, 59.75), 1.3, 
                (62.8, 59.75), (64.1, 58.45));
            _bottomOuterArcOfMountingHolePlane = 
                new ArcSegment((64.1, 59.75), 5.5, 
                (64.1, 54.25), (58.6, 59.75));
            _topOuterArcOfMountingHolePlane = 
                new ArcSegment((68.3, 79.944871), 9.7, 
                (58.6, 79.944871), (60.7, 85.972309));
            _bottomOuterArcOfPlaneOfMountingDisk = 
                new ArcSegment((53.1, 91.999746), 9.7, 
                (60.7, 85.972309), (62.8, 91.999746));
            _topOuterArcOfPlaneOfMountingDisk = 
                new ArcSegment((57.3, 101.867462), 5.5, 
                (62.8, 101.867462), (60.05, 106.630601));
            _outerArcBevelUnderPlaneVents = 
                new ArcSegment((41.530978, 136.259652), 16.4, 
                (33.330978, 122.056836), (26.667531, 143.190592));
            _outerArcOfVentsplane = 
                new ArcSegment((53.280301, 167.371659), 13.9, 
                (40.682622, 173.246052), (53.280301, 181.271659));
            _topArcHump = 
                new ArcSegment((34.223889, 199.823337), 3.376663, 
                (37.396914, 200.978224), (31.786351, 202.160057));
            _baseArcHump = 
                new ArcSegment((30.122417, 192.603838), 9.7, 
                (31.786351, 202.160057), (39.237435, 195.921434));
        }

        /// <summary>
        /// Построить 3D-объект автомобильного штампованного диска
        /// </summary>
        /// <param name="diskParams">Параметры диска</param>
        /// <returns>true или false</returns>
        public bool Build(DiskParams diskParams)
        {
            Initialize();
            var mainDiskSketch = DrawMainDiskSketch(diskParams);
            SqueezeRotation(mainDiskSketch);

            if(diskParams.HumpFlag == true)
            {
                var humpSketch = DrawHumpSketch
                    (diskParams.DiskDiameter, diskParams.DefaultDiskDiameter);
                SqueezeRotation(humpSketch);
            }

            var airVentsSketch = DrawAirVentsSketch(diskParams); 
            var airVents = CutExtrusion
                (airVentsSketch, diskParams.DepthExtrusionAirVentsSketch);
            CopyInCircules(diskParams.AirVentsCount, airVents);

            var boltHoleSketch = DrawBoltHoleSketch
                (diskParams.BoltArrangementDiameter, 
                diskParams.BoltHoleDiameter);
            var boltHole = CutExtrusion
                (boltHoleSketch, diskParams.DepthExtrusionBoltHoleSketch);
            CopyInCircules(diskParams.BoltsCount, boltHole);

            var nippleHoleSketch = DrawNippleHoleSketch(diskParams);
            CutExtrusion
                (nippleHoleSketch, diskParams.DepthExtrusionNippleHoleSketch);
            return true;
        }

        /// <summary>
        /// Инициализация объекта и детали Компаса
        /// </summary>
        private void Initialize()
        {
            _kompas = KompasConnector.KompasObject;
            if (_kompas == null)
            {
                throw new NullReferenceException("Экземпляр компаса равен null");
            }

            var iDocument3D = (ksDocument3D)_kompas.Document3D();
            iDocument3D.Create(false, true);
            _part = (ksPart)iDocument3D.GetPart((short)Part_Type.pTop_Part);
        }

        /// <summary>
        /// Перевести из дюймов в миллиметры 
        /// </summary>
        /// <param name="value">Значение в дюймах</param>
        /// <returns>Значение в миллиметрах</returns>
        private double ConvertFromInchesToMillimeters(double value)
        {
            return value * 25.4;
        }

        /// <summary>
        /// Нарисовать основной эскиз диска
        /// </summary>
        /// <param name="diskParams">Параметры диска</param>
        /// <returns>Основной эскиз диска</returns>
        private ksEntity DrawMainDiskSketch(DiskParams diskParams)
        {
            var planeXOZ = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeXOZ);
            sketch.Create();
            
            double coefficientDiskDiameter = (ConvertFromInchesToMillimeters
                (diskParams.DiskDiameter) - ConvertFromInchesToMillimeters
                (diskParams.DefaultDiskDiameter)) / 2;
            double coefficientWidth = (ConvertFromInchesToMillimeters
                (diskParams.Width) - ConvertFromInchesToMillimeters
                (diskParams.DefaultWidth));
            double coefficientCentralHole = (diskParams.CentralHoleDiameter -
                diskParams.DefaultCentralHoleDiameter) / 2;
            double coefficientAttachedPlane = diskParams.BoltArrangementDiameter / 2 +
                diskParams.BoltHoleDiameter / 2 - (diskParams.CentralHoleDiameter / 2 + 
                diskParams.LengthOfAttachedPlane);

            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksLineSeg(_endLineOfFrontSideRim.FirstPoint.X, 
                _endLineOfFrontSideRim.FirstPoint.Y + coefficientDiskDiameter, 
                _endLineOfFrontSideRim.SecondPoint.X, 
                _endLineOfFrontSideRim.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksLineSeg(_topHorizontalLineOfFrontSideFlange.FirstPoint.X, 
                _topHorizontalLineOfFrontSideFlange.FirstPoint.Y + coefficientDiskDiameter, 
                _topHorizontalLineOfFrontSideFlange.SecondPoint.X, 
                _topHorizontalLineOfFrontSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcOfFrontSideFlange.CentralPoint.X, 
                _topArcOfFrontSideFlange.CentralPoint.Y + coefficientDiskDiameter, 
                _topArcOfFrontSideFlange.Radius, _topArcOfFrontSideFlange.FirstPoint.X, 
                _topArcOfFrontSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _topArcOfFrontSideFlange.SecondPoint.X, 
                _topArcOfFrontSideFlange.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_innerVerticalLineOfFrontSideFlange.FirstPoint.X,
                _innerVerticalLineOfFrontSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _innerVerticalLineOfFrontSideFlange.SecondPoint.X, 
                _innerVerticalLineOfFrontSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcShelfOfFrontSide.CentralPoint.X, 
                _topArcShelfOfFrontSide.CentralPoint.Y + coefficientDiskDiameter, 
                _topArcShelfOfFrontSide.Radius, _topArcShelfOfFrontSide.FirstPoint.X, 
                _topArcShelfOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _topArcShelfOfFrontSide.SecondPoint.X, 
                _topArcShelfOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_topLineShelfOfFrontSide.FirstPoint.X, 
                _topLineShelfOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _topLineShelfOfFrontSide.SecondPoint.X, 
                _topLineShelfOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcOfBevelShelvesOfFrontSide.CentralPoint.X, 
                _topArcOfBevelShelvesOfFrontSide.CentralPoint.Y + coefficientDiskDiameter, 
                _topArcOfBevelShelvesOfFrontSide.Radius, 
                _topArcOfBevelShelvesOfFrontSide.FirstPoint.X, 
                _topArcOfBevelShelvesOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _topArcOfBevelShelvesOfFrontSide.SecondPoint.X, 
                _topArcOfBevelShelvesOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_topBevelLineShelfOfFrontSide.FirstPoint.X, 
                _topBevelLineShelfOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _topBevelLineShelfOfFrontSide.SecondPoint.X, 
                _topBevelLineShelfOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topLeftArcOfCentalPlaneRim.CentralPoint.X, 
                _topLeftArcOfCentalPlaneRim.CentralPoint.Y + coefficientDiskDiameter, 
                _topLeftArcOfCentalPlaneRim.Radius, _topLeftArcOfCentalPlaneRim.FirstPoint.X, 
                _topLeftArcOfCentalPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _topLeftArcOfCentalPlaneRim.SecondPoint.X,
                _topLeftArcOfCentalPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_topLineOfCentralPlaneRim.FirstPoint.X, 
                _topLineOfCentralPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _topLineOfCentralPlaneRim.SecondPoint.X, 
                _topLineOfCentralPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topRightArcOfCentalPlaneRim.CentralPoint.X, 
                _topRightArcOfCentalPlaneRim.CentralPoint.Y + coefficientDiskDiameter, 
                _topRightArcOfCentalPlaneRim.Radius, _topRightArcOfCentalPlaneRim.FirstPoint.X, 
                _topRightArcOfCentalPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _topRightArcOfCentalPlaneRim.SecondPoint.X,
                _topRightArcOfCentalPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_topBevelLineShelfOfBackSide.FirstPoint.X + coefficientWidth, 
                _topBevelLineShelfOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _topBevelLineShelfOfBackSide.SecondPoint.X, 
                _topBevelLineShelfOfBackSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcOfBevelShelvesOfBackSide.CentralPoint.X + coefficientWidth,
                _topArcOfBevelShelvesOfBackSide.CentralPoint.Y + coefficientDiskDiameter, 
                _topArcOfBevelShelvesOfBackSide.Radius,
                _topArcOfBevelShelvesOfBackSide.FirstPoint.X + coefficientWidth, 
                _topArcOfBevelShelvesOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _topArcOfBevelShelvesOfBackSide.SecondPoint.X + coefficientWidth, 
                _topArcOfBevelShelvesOfBackSide.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_topLineShelfOfBackSide.FirstPoint.X + coefficientWidth, 
                _topLineShelfOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _topLineShelfOfBackSide.SecondPoint.X + coefficientWidth, 
                _topLineShelfOfBackSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcShelfOfBackSide.CentralPoint.X + coefficientWidth, 
                _topArcShelfOfBackSide.CentralPoint.Y + coefficientDiskDiameter,
                _topArcShelfOfBackSide.Radius, 
                _topArcShelfOfBackSide.FirstPoint.X + coefficientWidth, 
                _topArcShelfOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _topArcShelfOfBackSide.SecondPoint.X + coefficientWidth, 
                _topArcShelfOfBackSide.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_innerVerticalLineOfBackSideFlange.FirstPoint.X + coefficientWidth, 
                _innerVerticalLineOfBackSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _innerVerticalLineOfBackSideFlange.SecondPoint.X + coefficientWidth, 
                _innerVerticalLineOfBackSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcOfBackSideFlange.CentralPoint.X + coefficientWidth, 
                _topArcOfBackSideFlange.CentralPoint.Y + coefficientDiskDiameter,
                _topArcOfBackSideFlange.Radius,
                _topArcOfBackSideFlange.FirstPoint.X + coefficientWidth, 
                _topArcOfBackSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _topArcOfBackSideFlange.SecondPoint.X + coefficientWidth, 
                _topArcOfBackSideFlange.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_topHorizontalLineOfBackSideFlange.FirstPoint.X + coefficientWidth, 
                _topHorizontalLineOfBackSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _topHorizontalLineOfBackSideFlange.SecondPoint.X + coefficientWidth, 
                _topHorizontalLineOfBackSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksLineSeg(_endLineOfBackSideRim.FirstPoint.X + coefficientWidth, 
                _endLineOfBackSideRim.FirstPoint.Y + coefficientDiskDiameter,
                _endLineOfBackSideRim.SecondPoint.X + coefficientWidth, 
                _endLineOfBackSideRim.SecondPoint.Y + coefficientDiskDiameter, 1);

            doc.ksLineSeg(_bottomHorizontalLineOfFrontSideFlange.FirstPoint.X, 
                _bottomHorizontalLineOfFrontSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _bottomHorizontalLineOfFrontSideFlange.SecondPoint.X, 
                _bottomHorizontalLineOfFrontSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomArcOfFrontSideFlange.CentralPoint.X, 
                _bottomArcOfFrontSideFlange.CentralPoint.Y + coefficientDiskDiameter,
                _bottomArcOfFrontSideFlange.Radius,
                _bottomArcOfFrontSideFlange.FirstPoint.X,
                _bottomArcOfFrontSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _bottomArcOfFrontSideFlange.SecondPoint.X, 
                _bottomArcOfFrontSideFlange.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_outerVerticalLineOfFrontSideFlange.FirstPoint.X,
                _outerVerticalLineOfFrontSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _outerVerticalLineOfFrontSideFlange.SecondPoint.X, 
                _outerVerticalLineOfFrontSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomArcShelfOfFrontSide.CentralPoint.X,
                _bottomArcShelfOfFrontSide.CentralPoint.Y + coefficientDiskDiameter,
                _bottomArcShelfOfFrontSide.Radius, _bottomArcShelfOfFrontSide.FirstPoint.X, 
                _bottomArcShelfOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomArcShelfOfFrontSide.SecondPoint.X, 
                _bottomArcShelfOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_bottomLineShelfOfFrontSide.FirstPoint.X, 
                _bottomLineShelfOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomLineShelfOfFrontSide.SecondPoint.X, 
                _bottomLineShelfOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomArcOfBevelShelvesOfFrontSide.CentralPoint.X, 
                _bottomArcOfBevelShelvesOfFrontSide.CentralPoint.Y + coefficientDiskDiameter,
                _bottomArcOfBevelShelvesOfFrontSide.Radius,
                _bottomArcOfBevelShelvesOfFrontSide.FirstPoint.X,
                _bottomArcOfBevelShelvesOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomArcOfBevelShelvesOfFrontSide.SecondPoint.X, 
                _bottomArcOfBevelShelvesOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_bottomBevelLineShelfOfFrontSide.FirstPoint.X,
                _bottomBevelLineShelfOfFrontSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomBevelLineShelfOfFrontSide.SecondPoint.X, 
                _bottomBevelLineShelfOfFrontSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomLeftArcOfCentalPlaneRim.CentralPoint.X,
                _bottomLeftArcOfCentalPlaneRim.CentralPoint.Y + coefficientDiskDiameter, 
                _bottomLeftArcOfCentalPlaneRim.Radius, _bottomLeftArcOfCentalPlaneRim.FirstPoint.X, 
                _bottomLeftArcOfCentalPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _bottomLeftArcOfCentalPlaneRim.SecondPoint.X, 
                _bottomLeftArcOfCentalPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1, 1);

            doc.ksLineSeg(_bottomLeftLineOfCentralPlaneRim.FirstPoint.X, 
                _bottomLeftLineOfCentralPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _bottomLeftLineOfCentralPlaneRim.SecondPoint.X, 
                _bottomLeftLineOfCentralPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksLineSeg(_bottomRightLineOfCentralPlaneRim.FirstPoint.X, 
                _bottomRightLineOfCentralPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _bottomRightLineOfCentralPlaneRim.SecondPoint.X, 
                _bottomRightLineOfCentralPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1);

            doc.ksArcByPoint(_bottomRightArcOfCentalPlaneRim.CentralPoint.X, 
                _bottomRightArcOfCentalPlaneRim.CentralPoint.Y + coefficientDiskDiameter,
                _bottomRightArcOfCentalPlaneRim.Radius, 
                _bottomRightArcOfCentalPlaneRim.FirstPoint.X, 
                _bottomRightArcOfCentalPlaneRim.FirstPoint.Y + coefficientDiskDiameter,
                _bottomRightArcOfCentalPlaneRim.SecondPoint.X, 
                _bottomRightArcOfCentalPlaneRim.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_bottmBevelLineShelfOfBackSide.FirstPoint.X + coefficientWidth, 
                _bottmBevelLineShelfOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottmBevelLineShelfOfBackSide.SecondPoint.X, 
                _bottmBevelLineShelfOfBackSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomArcOfBevelShelvesOfBackSide.CentralPoint.X + coefficientWidth, 
                _bottomArcOfBevelShelvesOfBackSide.CentralPoint.Y + coefficientDiskDiameter, 
                _bottomArcOfBevelShelvesOfBackSide.Radius,
                _bottomArcOfBevelShelvesOfBackSide.FirstPoint.X + coefficientWidth, 
                _bottomArcOfBevelShelvesOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomArcOfBevelShelvesOfBackSide.SecondPoint.X + coefficientWidth, 
                _bottomArcOfBevelShelvesOfBackSide.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_bottomLineShelfOfBackSide.FirstPoint.X + coefficientWidth, 
                _bottomLineShelfOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomLineShelfOfBackSide.SecondPoint.X + coefficientWidth, 
                _bottomLineShelfOfBackSide.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomArcShelfOfBackSide.CentralPoint.X + coefficientWidth, 
                _bottomArcShelfOfBackSide.CentralPoint.Y + coefficientDiskDiameter, 
                _bottomArcShelfOfBackSide.Radius,
                _bottomArcShelfOfBackSide.FirstPoint.X + coefficientWidth, 
                _bottomArcShelfOfBackSide.FirstPoint.Y + coefficientDiskDiameter,
                _bottomArcShelfOfBackSide.SecondPoint.X + coefficientWidth, 
                _bottomArcShelfOfBackSide.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_outerVerticalLineOfBackSideFlange.FirstPoint.X + coefficientWidth, 
                _outerVerticalLineOfBackSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _outerVerticalLineOfBackSideFlange.SecondPoint.X + coefficientWidth, 
                _outerVerticalLineOfBackSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_bottomArcOfBackSideFlange.CentralPoint.X + coefficientWidth, 
                _bottomArcOfBackSideFlange.CentralPoint.Y + coefficientDiskDiameter,
                _bottomArcOfBackSideFlange.Radius,
                _bottomArcOfBackSideFlange.FirstPoint.X + coefficientWidth,
                _bottomArcOfBackSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _bottomArcOfBackSideFlange.SecondPoint.X + coefficientWidth,
                _bottomArcOfBackSideFlange.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_bottomHorizontalLineOfBackSideFlange.FirstPoint.X + coefficientWidth,
                _bottomHorizontalLineOfBackSideFlange.FirstPoint.Y + coefficientDiskDiameter,
                _bottomHorizontalLineOfBackSideFlange.SecondPoint.X + coefficientWidth,
                _bottomHorizontalLineOfBackSideFlange.SecondPoint.Y + coefficientDiskDiameter, 1);

            doc.ksLineSeg(_lineOfTopEndOfWheelDisk.FirstPoint.X, 
                _lineOfTopEndOfWheelDisk.FirstPoint.Y + coefficientDiskDiameter,
                _lineOfTopEndOfWheelDisk.SecondPoint.X, 
                _lineOfTopEndOfWheelDisk.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksLineSeg(_horizontalLineOfPlaneAttachmentWheelDiskToRim.FirstPoint.X, 
                _horizontalLineOfPlaneAttachmentWheelDiskToRim.FirstPoint.Y + coefficientDiskDiameter,
                _horizontalLineOfPlaneAttachmentWheelDiskToRim.SecondPoint.X, 
                _horizontalLineOfPlaneAttachmentWheelDiskToRim.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_innerArcOfVentsplane.CentralPoint.X, 
                _innerArcOfVentsplane.CentralPoint.Y + coefficientDiskDiameter, 
                _innerArcOfVentsplane.Radius, _innerArcOfVentsplane.FirstPoint.X, 
                _innerArcOfVentsplane.FirstPoint.Y + coefficientDiskDiameter,
                _innerArcOfVentsplane.SecondPoint.X, 
                _innerArcOfVentsplane.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_innerLineOfPlaneVents.FirstPoint.X, 
                _innerLineOfPlaneVents.FirstPoint.Y + coefficientDiskDiameter,
                _innerLineOfPlaneVents.SecondPoint.X, 
                _innerLineOfPlaneVents.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_innerArcBevelUnderPlaneVents.CentralPoint.X, 
                _innerArcBevelUnderPlaneVents.CentralPoint.Y + coefficientDiskDiameter, 
                _innerArcBevelUnderPlaneVents.Radius,
                _innerArcBevelUnderPlaneVents.FirstPoint.X, 
                _innerArcBevelUnderPlaneVents.FirstPoint.Y + coefficientDiskDiameter,
                _innerArcBevelUnderPlaneVents.SecondPoint.X, 
                _innerArcBevelUnderPlaneVents.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(_innerBevelLineUnderPlaneVents.FirstPoint.X, 
                _innerBevelLineUnderPlaneVents.FirstPoint.Y + coefficientCentralHole,
                _innerBevelLineUnderPlaneVents.SecondPoint.X, 
                _innerBevelLineUnderPlaneVents.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topInnerArcOfPlaneOfMountingDisk.CentralPoint.X,
                _topInnerArcOfPlaneOfMountingDisk.CentralPoint.Y + coefficientCentralHole,
                _topInnerArcOfPlaneOfMountingDisk.Radius,
                _topInnerArcOfPlaneOfMountingDisk.FirstPoint.X,
                _topInnerArcOfPlaneOfMountingDisk.FirstPoint.Y + coefficientCentralHole,
                _topInnerArcOfPlaneOfMountingDisk.SecondPoint.X,
                _topInnerArcOfPlaneOfMountingDisk.SecondPoint.Y + coefficientCentralHole, -1, 1);
            doc.ksLineSeg(_innerLineToPlaneOfMountingDisk.FirstPoint.X,
                _innerLineToPlaneOfMountingDisk.FirstPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane,
                _innerLineToPlaneOfMountingDisk.SecondPoint.X,
                _innerLineToPlaneOfMountingDisk.SecondPoint.Y + coefficientCentralHole, 1);
            doc.ksArcByPoint(_bottomInnerArcOfPlaneOfMountingDisk.CentralPoint.X,
                _bottomInnerArcOfPlaneOfMountingDisk.CentralPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane,
                _bottomInnerArcOfPlaneOfMountingDisk.Radius,
                _bottomInnerArcOfPlaneOfMountingDisk.FirstPoint.X, 
                _bottomInnerArcOfPlaneOfMountingDisk.FirstPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane,
                _bottomInnerArcOfPlaneOfMountingDisk.SecondPoint.X,
                _bottomInnerArcOfPlaneOfMountingDisk.SecondPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane, -1, 1);
            doc.ksArcByPoint(_topInnerArcOfMountingHolePlane.CentralPoint.X, 
                _topInnerArcOfMountingHolePlane.CentralPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane, 
                _topInnerArcOfMountingHolePlane.Radius,
                _topInnerArcOfMountingHolePlane.FirstPoint.X, 
                _topInnerArcOfMountingHolePlane.FirstPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane,
                _topInnerArcOfMountingHolePlane.SecondPoint.X, 
                _topInnerArcOfMountingHolePlane.SecondPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane, 1, 1);
            doc.ksLineSeg(_innerLineOfMountingHolePlane.FirstPoint.X, 
                _innerLineOfMountingHolePlane.FirstPoint.Y + coefficientCentralHole,
                _innerLineOfMountingHolePlane.SecondPoint.X, 
                _innerLineOfMountingHolePlane.SecondPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane, 1);
            doc.ksArcByPoint(_bottomInnerArcOfMountingHolePlane.CentralPoint.X, 
                _bottomInnerArcOfMountingHolePlane.CentralPoint.Y + 
                coefficientCentralHole, _bottomInnerArcOfMountingHolePlane.Radius,
                _bottomInnerArcOfMountingHolePlane.FirstPoint.X, 
                _bottomInnerArcOfMountingHolePlane.FirstPoint.Y + coefficientCentralHole,
                _bottomInnerArcOfMountingHolePlane.SecondPoint.X, 
                _bottomInnerArcOfMountingHolePlane.SecondPoint.Y + coefficientCentralHole, 1, 1);
            doc.ksLineSeg(_topLineOfMountingEndOfWheelDisk.FirstPoint.X, 
                _topLineOfMountingEndOfWheelDisk.FirstPoint.Y + coefficientCentralHole,
                _topLineOfMountingEndOfWheelDisk.SecondPoint.X, 
                _topLineOfMountingEndOfWheelDisk.SecondPoint.Y + coefficientCentralHole, 1);
            doc.ksLineSeg(_endLineOfMountingPlaneWheelDisk.FirstPoint.X,
                _endLineOfMountingPlaneWheelDisk.FirstPoint.Y + coefficientCentralHole,
                _endLineOfMountingPlaneWheelDisk.SecondPoint.X, 
                _endLineOfMountingPlaneWheelDisk.SecondPoint.Y + coefficientCentralHole, 1);

            doc.ksLineSeg(_bottomLineOfMountingEndOfWheelDisk.FirstPoint.X,
                _bottomLineOfMountingEndOfWheelDisk.FirstPoint.Y + coefficientCentralHole,
                _bottomLineOfMountingEndOfWheelDisk.SecondPoint.X, 
                _bottomLineOfMountingEndOfWheelDisk.SecondPoint.Y + coefficientCentralHole, 1);
            doc.ksArcByPoint(_bottomOuterArcOfMountingHolePlane.CentralPoint.X,
                _bottomOuterArcOfMountingHolePlane.CentralPoint.Y + coefficientCentralHole,
                _bottomOuterArcOfMountingHolePlane.Radius,
                _bottomOuterArcOfMountingHolePlane.FirstPoint.X, 
                _bottomOuterArcOfMountingHolePlane.FirstPoint.Y + coefficientCentralHole,
                _bottomOuterArcOfMountingHolePlane.SecondPoint.X,
                _bottomOuterArcOfMountingHolePlane.SecondPoint.Y + coefficientCentralHole, -1, 1);
            doc.ksLineSeg(_outerLineOfMountingHolePlane.FirstPoint.X,
                _outerLineOfMountingHolePlane.FirstPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane,
                _outerLineOfMountingHolePlane.SecondPoint.X, 
                _outerLineOfMountingHolePlane.SecondPoint.Y + coefficientCentralHole, 1);
            doc.ksArcByPoint(_topOuterArcOfMountingHolePlane.CentralPoint.X, 
                _topOuterArcOfMountingHolePlane.CentralPoint.Y + 
                coefficientCentralHole + coefficientAttachedPlane, 
                _topOuterArcOfMountingHolePlane.Radius,
                _topOuterArcOfMountingHolePlane.FirstPoint.X,
                _topOuterArcOfMountingHolePlane.FirstPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane,
                _topOuterArcOfMountingHolePlane.SecondPoint.X, 
                _topOuterArcOfMountingHolePlane.SecondPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane, -1, 1);
            doc.ksArcByPoint(_bottomOuterArcOfPlaneOfMountingDisk.CentralPoint.X,
                _bottomOuterArcOfPlaneOfMountingDisk.CentralPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane,
                _bottomOuterArcOfPlaneOfMountingDisk.Radius,
                _bottomOuterArcOfPlaneOfMountingDisk.FirstPoint.X, 
                _bottomOuterArcOfPlaneOfMountingDisk.FirstPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane,
                _bottomOuterArcOfPlaneOfMountingDisk.SecondPoint.X, 
                _bottomOuterArcOfPlaneOfMountingDisk.SecondPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane, 1, 1);
            doc.ksLineSeg(_outerLineToPlaneOfMountingDisk.FirstPoint.X,
                _outerLineToPlaneOfMountingDisk.FirstPoint.Y 
                + coefficientCentralHole + coefficientAttachedPlane,
                _outerLineToPlaneOfMountingDisk.SecondPoint.X, 
                _outerLineToPlaneOfMountingDisk.SecondPoint.Y + coefficientCentralHole, 1);
            doc.ksArcByPoint(_topOuterArcOfPlaneOfMountingDisk.CentralPoint.X, 
                _topOuterArcOfPlaneOfMountingDisk.CentralPoint.Y + coefficientCentralHole, 
                _topOuterArcOfPlaneOfMountingDisk.Radius,
                _topOuterArcOfPlaneOfMountingDisk.FirstPoint.X, 
                _topOuterArcOfPlaneOfMountingDisk.FirstPoint.Y + coefficientCentralHole,
                _topOuterArcOfPlaneOfMountingDisk.SecondPoint.X, 
                _topOuterArcOfPlaneOfMountingDisk.SecondPoint.Y + coefficientCentralHole, 1, 1);
            doc.ksLineSeg(_outerBevelLineUnderPlaneVents.FirstPoint.X,
                _outerBevelLineUnderPlaneVents.FirstPoint.Y + coefficientCentralHole,
                _outerBevelLineUnderPlaneVents.SecondPoint.X,
                _outerBevelLineUnderPlaneVents.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_outerArcBevelUnderPlaneVents.CentralPoint.X, 
                _outerArcBevelUnderPlaneVents.CentralPoint.Y + coefficientDiskDiameter,
                _outerArcBevelUnderPlaneVents.Radius,
                _outerArcBevelUnderPlaneVents.FirstPoint.X, 
                _outerArcBevelUnderPlaneVents.FirstPoint.Y + coefficientDiskDiameter,
                _outerArcBevelUnderPlaneVents.SecondPoint.X,
                _outerArcBevelUnderPlaneVents.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(_outerLineOfPlaneVents.FirstPoint.X, 
                _outerLineOfPlaneVents.FirstPoint.Y + coefficientDiskDiameter,
                _outerLineOfPlaneVents.SecondPoint.X, 
                _outerLineOfPlaneVents.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_outerArcOfVentsplane.CentralPoint.X, 
                _outerArcOfVentsplane.CentralPoint.Y + coefficientDiskDiameter,
                _outerArcOfVentsplane.Radius, _outerArcOfVentsplane.FirstPoint.X,
                _outerArcOfVentsplane.FirstPoint.Y + coefficientDiskDiameter,
                _outerArcOfVentsplane.SecondPoint.X,
                _outerArcOfVentsplane.SecondPoint.Y + coefficientDiskDiameter, -1, 1);

            doc.ksLineSeg(_centerLineOX.FirstPoint.X, _centerLineOX.FirstPoint.Y, 
                _centerLineOX.SecondPoint.X, _centerLineOX.SecondPoint.Y, 3);
            iDefinitionSketch.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Выдавить вращением
        /// </summary>
        /// <param name="sketch">Главный эскиз диска</param>
        private void SqueezeRotation(ksEntity sketch)
        {
            ksEntity rotatedEntity = _part.NewEntity((short)Obj3dType.o3d_bossRotated);
            ksBossRotatedDefinition rotatedDefinition = rotatedEntity.GetDefinition();
            rotatedDefinition.SetThinParam(false);
            rotatedDefinition.SetSketch(sketch);
            rotatedEntity.Create();
        }

        /// <summary>
        /// Создать ось на пересечении двух плоскостей
        /// </summary>
        /// <param name="plane1">Первая плоскость</param>
        /// <param name="plane2">Вторая плоскость</param>
        /// <returns>Ось</returns>
        private ksEntity CreateAxis
            (Kompas6Constants3D.Obj3dType plane1, Kompas6Constants3D.Obj3dType plane2)
        {
            var firstPlane = _part.GetDefaultEntity((short)plane1);
            var secondPlane = _part.GetDefaultEntity((short)plane2);
            var axis = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_axis2Planes);
            ksAxis2PlanesDefinition axisPlanesDefinition = axis.GetDefinition();
            axisPlanesDefinition.SetPlane(1, firstPlane);
            axisPlanesDefinition.SetPlane(2, secondPlane);
            axis.Create();
            return axis;
        }

        /// <summary>
        /// Создать наклонную плоскость
        /// </summary>
        /// <param name="angle">Угол наклона</param>
        /// <param name="plane">Плоскость</param>
        /// <param name="axis">Ось</param>
        /// <returns>Плоскость под углом</returns>
        private ksEntity CreatePlaneAngle
            (int angle, Kompas6Constants3D.Obj3dType plane, ksEntity axis)
        {
            var planeAngle = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_planeAngle);
            ksPlaneAngleDefinition planeAngleDefinition = planeAngle.GetDefinition();
            planeAngleDefinition.angle = angle;
            var basePlane = _part.GetDefaultEntity((short)plane);
            planeAngleDefinition.SetPlane(basePlane);
            planeAngleDefinition.SetAxis(axis);
            planeAngle.Create();
            return planeAngle;
        }

        /// <summary>
        /// Сместить плоскость
        /// </summary>
        /// <param name="plane">Смещаемая плоскость</param>
        /// <param name="distanceFromAirVentsPlane">Дистанция смещения</param>
        /// <returns>Смещенная плоскость</returns>
        private ksEntity MovePlane(ksEntity plane, int distanceFromAirVentsPlane)
        {
            var planeOffset = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition planeOffsetDefinition = planeOffset.GetDefinition();
            planeOffsetDefinition.direction = true;
            planeOffsetDefinition.offset = distanceFromAirVentsPlane;
            planeOffsetDefinition.SetPlane(plane);
            planeOffset.Create();
            return planeOffset;
        }

        /// <summary>
        /// Нарисовать эскиз вентиляционного отверстия
        /// </summary>
        /// <param name="diskParams">Параметры диска</param>
        /// <returns>Эскиз вентиляционного отверстия</returns>
        private ksEntity DrawAirVentsSketch(DiskParams diskParams)
        {
            var axis = CreateAxis(Obj3dType.o3d_planeXOY, Obj3dType.o3d_planeYOZ);
            var planeAngel = CreatePlaneAngle
                (diskParams.AirVentsAnglePlane, Obj3dType.o3d_planeXOY, axis);
            var planeOffset = MovePlane
                (planeAngel, diskParams.DistanceFromAirVentsPlane);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeOffset);
            sketch.Create();
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle
                (diskParams.AirVentsArrangementDiameters[diskParams.DiskDiameter],
                0, (double)diskParams.AirVentsDiameter / 2, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        }
        
        /// <summary>
        /// Вырезать выдавливанием
        /// </summary>
        /// <param name="sketch">Эскиз</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <returns>Отверстие</returns>
        private ksEntity CutExtrusion(ksEntity sketch, int depth)
        {
            ksEntity cutExtrusion = 
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition extrusionDefinition = 
                cutExtrusion.GetDefinition();
            ksExtrusionParam extrusionParam = 
                (ksExtrusionParam)extrusionDefinition.ExtrusionParam();
            extrusionDefinition.SetSketch(sketch);           
            extrusionParam.direction = (short)Direction_Type.dtNormal;
            extrusionParam.typeNormal = (short)End_Type.etBlind;
            extrusionParam.depthNormal = depth;
            cutExtrusion.Create();
            return cutExtrusion;
        }

        /// <summary>
        /// Копировать по концентрической сетке
        /// </summary>
        /// <param name="countElements">Количество копий</param>
        /// <param name="arrayElements">Элемент копирования</param>
        private void CopyInCircules(int countElements, ksEntity arrayElements)
        {
            ksEntity circularCopy = 
                (ksEntity)_part.NewEntity((short)Obj3dType.o3d_circularCopy);
            ksCircularCopyDefinition circularCopyDefinition = 
                circularCopy.GetDefinition();
            var axis = CreateAxis(Obj3dType.o3d_planeXOY, Obj3dType.o3d_planeXOZ);
            circularCopyDefinition.SetAxis(axis);
            circularCopyDefinition.SetCopyParamAlongDir
                (countElements, 360, true, false);
            ksEntityCollection entityCollection = 
                circularCopyDefinition.GetOperationArray();
            entityCollection.Clear();
            entityCollection.Add(arrayElements);
            circularCopy.Create();
        }

        /// <summary>
        /// Нарисовать эскиз отверстия под болт
        /// </summary>
        /// <param name="boltArrangementDiameter">Диаметр расположения болтов</param>
        /// <param name="boltHoleDiameter">Диаметр отверстия под болт</param>
        /// <returns>Эскиз отверстия под болт</returns>
        private ksEntity DrawBoltHoleSketch
            (double boltArrangementDiameter, double boltHoleDiameter)
        {
            var planeYOZ = _part.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeYOZ);
            sketch.Create();
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle(0, boltArrangementDiameter / 2, boltHoleDiameter / 2, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        }

        /// <summary>
        /// Нарисовать эскиз отверстия под ниппель
        /// </summary>
        /// <param name="diskParams">Параметры диска</param>
        /// <returns>Эскиз отверстия под ниппель</returns>
        private ksEntity DrawNippleHoleSketch(DiskParams diskParams)
        {
            var axis = CreateAxis(Obj3dType.o3d_planeYOZ, Obj3dType.o3d_planeXOZ);
            var planeAngle = CreatePlaneAngle
                (diskParams.NippleHoleAnglePlane, Obj3dType.o3d_planeYOZ, axis);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeAngle);
            sketch.Create();
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle
                (diskParams.NippleHoleArrangementDiameters[diskParams.DiskDiameter], 
                0, diskParams.NippleHoleDiameter / 2, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        } 

        /// <summary>
        /// Нарисовать эскиз хампа
        /// </summary>
        /// <param name="diskDiameter">Диаметр диска</param>
        /// <param name="defaultDiskDiameter">Диаметр диска по умолчанию</param>
        /// <returns></returns>
        private ksEntity DrawHumpSketch(int diskDiameter, int defaultDiskDiameter)
        {
            var planeXOZ = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeXOZ);
            sketch.Create();

            double coefficientDiskDiameter = 
                (ConvertFromInchesToMillimeters(diskDiameter) - 
                ConvertFromInchesToMillimeters(defaultDiskDiameter)) / 2;

            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksLineSeg(_humpLine.FirstPoint.X, 
                _humpLine.FirstPoint.Y + coefficientDiskDiameter,
                _humpLine.SecondPoint.X, 
                _humpLine.SecondPoint.Y + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(_topArcHump.CentralPoint.X, 
                _topArcHump.CentralPoint.Y + coefficientDiskDiameter, 
                _topArcHump.Radius,
                _topArcHump.FirstPoint.X, 
                _topArcHump.FirstPoint.Y + coefficientDiskDiameter,
                _topArcHump.SecondPoint.X, 
                _topArcHump.SecondPoint.Y + coefficientDiskDiameter, 1, 1);
            doc.ksArcByPoint(_baseArcHump.CentralPoint.X, 
                _baseArcHump.CentralPoint.Y + coefficientDiskDiameter, 
                _baseArcHump.Radius,
                _baseArcHump.FirstPoint.X, 
                _baseArcHump.FirstPoint.Y + coefficientDiskDiameter,
                _baseArcHump.SecondPoint.X, 
                _baseArcHump.SecondPoint.Y + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(
                _centerLineOX.FirstPoint.X, _centerLineOX.FirstPoint.Y,
                _centerLineOX.SecondPoint.X, _centerLineOX.SecondPoint.Y, 3);

            iDefinitionSketch.EndEdit();
            return sketch;
        }
    }
}
