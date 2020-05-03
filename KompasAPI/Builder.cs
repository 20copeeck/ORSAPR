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
        /// Построить 3D-объект автомобильного штампованного диска
        /// </summary>
        /// <param name="diskParams">Параметры диска</param>
        /// <returns>true или false</returns>
        public bool Build(DiskParams diskParams)
        {
            Initialize();
            var mainDiskSketch = DrawMainDiskSketch(diskParams);
            SqueezeRotation(mainDiskSketch);

            var airVentsSketch = DrawAirVentsSketch(diskParams); 
            var airVents = CutExtrusion(airVentsSketch, diskParams.DepthExtrusionAirVentsSketch);
            CopyInCircules(diskParams.AirVentsCount, airVents);

            var boltHoleSketch = DrawBoltHoleSketch(diskParams.BoltArrangementDiameter, 
                diskParams.BoltHoleDiameter);
            var boltHole = CutExtrusion(boltHoleSketch, diskParams.DepthExtrusionBoltHoleSketch);
            CopyInCircules(diskParams.BoltsCount, boltHole);

            var nippleHoleSketch = DrawNippleHoleSketch(diskParams);
            CutExtrusion(nippleHoleSketch, diskParams.DepthExtrusionNippleHoleSketch);

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
            
            double coefficientDiskDiameter = (ConvertFromInchesToMillimeters(diskParams.DiskDiameter)
                - ConvertFromInchesToMillimeters(diskParams.DefaultDiskDiameter)) / 2;
            double coefficientWidth = (ConvertFromInchesToMillimeters(diskParams.Width)
                - ConvertFromInchesToMillimeters(diskParams.DefaultWidth));
            double coefficientCentralHole = (diskParams.CentralHoleDiameter -
                diskParams.DefaultCentralHoleDiameter) / 2;
            double coefficientAttachedPlane = diskParams.BoltArrangementDiameter / 2 +
                diskParams.BoltHoleDiameter / 2 - (diskParams.CentralHoleDiameter / 2 + 
                diskParams.LengthOfAttachedPlane);

            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksLineSeg(0, 216.938908 + coefficientDiskDiameter, 
                0, 221.138908 + coefficientDiskDiameter, 1);
            doc.ksLineSeg(0, 221.138908 + coefficientDiskDiameter, 
                3.3, 221.138908 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(3.3, 211.438908 + coefficientDiskDiameter, 9.7, 
                3.3, 221.138908 + coefficientDiskDiameter, 
                13, 211.438908 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(13, 211.438908 + coefficientDiskDiameter, 
                13, 211.169558 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(21, 211.169558 + coefficientDiskDiameter, 8, 
                13, 211.169558 + coefficientDiskDiameter, 
                20.302754, 203.2 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(20.302754, 203.2 + coefficientDiskDiameter, 
                30.967828, 202.266927 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(30.122417, 192.603838 + coefficientDiskDiameter, 9.7, 
                30.967828, 202.266927 + coefficientDiskDiameter, 
                39.237435, 195.921434 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(39.237435, 195.921434 + coefficientDiskDiameter, 
                40.717837, 191.854063 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(49.832856, 195.171659 + coefficientDiskDiameter, 9.7, 
                40.717837, 191.854063 + coefficientDiskDiameter, 
                49.832856, 185.471659 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(49.832856, 185.471659 + coefficientDiskDiameter, 
                95.89835, 185.471659 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(95.89835, 195.171659 + coefficientDiskDiameter, 9.7, 
                95.89835, 185.471659 + coefficientDiskDiameter, 
                98.530815, 185.8357 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(154.428192 + coefficientWidth, 201.597111 + coefficientDiskDiameter, 
                98.530815, 185.8357 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(157.060657 + coefficientWidth, 192.261152 + coefficientDiskDiameter, 9.7, 
                154.428192 + coefficientWidth, 201.597111 + coefficientDiskDiameter, 
                156.215246 + coefficientWidth, 201.92424 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(170.797246 + coefficientWidth, 203.2 + coefficientDiskDiameter, 
                156.215246 + coefficientWidth, 201.92424 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(170.1 + coefficientWidth, 211.169558 + coefficientDiskDiameter, 8,
                170.797246 + coefficientWidth, 203.2 + coefficientDiskDiameter, 
                178.1 + coefficientWidth, 211.169558 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(178.1 + coefficientWidth, 211.438908 + coefficientDiskDiameter, 
                178.1 + coefficientWidth, 211.169558 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(187.8 + coefficientWidth, 211.438908 + coefficientDiskDiameter, 9.7,
                178.1 + coefficientWidth, 211.438908 + coefficientDiskDiameter, 
                187.8 + coefficientWidth, 221.138908 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(187.8 + coefficientWidth, 221.138908 + coefficientDiskDiameter, 
                191.1 + coefficientWidth, 221.138908 + coefficientDiskDiameter, 1);
            doc.ksLineSeg(191.1 + coefficientWidth, 216.938908 + coefficientDiskDiameter, 
                191.1 + coefficientWidth, 221.138908 + coefficientDiskDiameter, 1);

            doc.ksLineSeg(0, 216.938908 + coefficientDiskDiameter, 
                3.3, 216.938908 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(3.3, 211.438908 + coefficientDiskDiameter, 5.5, 
                3.3, 216.938908 + coefficientDiskDiameter, 
                8.8, 211.438908 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(8.8, 211.438908 + coefficientDiskDiameter, 
                8.8, 211.169558 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(21, 211.169558 + coefficientDiskDiameter, 12.2, 
                8.8, 211.169558 + coefficientDiskDiameter, 
                19.9367, 199.015982 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(30.601773, 198.082909 + coefficientDiskDiameter, 
                19.9367, 199.015982 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(30.122417, 192.603838 + coefficientDiskDiameter, 5.5, 
                30.601773, 198.082909 + coefficientDiskDiameter, 
                35.290726, 194.484949 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(36.771128, 190.417579 + coefficientDiskDiameter, 
                35.290726, 194.484949 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(49.832856, 195.171659 + coefficientDiskDiameter, 13.9, 
                36.771128, 190.417579 + coefficientDiskDiameter, 
                49.832856, 181.271659 + coefficientDiskDiameter, 1, 1);

            doc.ksLineSeg(53.280301, 181.271659 + coefficientDiskDiameter, 
                49.832856, 181.271659 + coefficientDiskDiameter, 1);
            doc.ksLineSeg(95.846251, 181.271659 + coefficientDiskDiameter, 
                89, 181.271659 + coefficientDiskDiameter, 1);

            doc.ksArcByPoint(95.846251, 195.171659 + coefficientDiskDiameter, 13.9, 
                95.846251, 181.271659 + coefficientDiskDiameter,
                99.632216, 181.797188 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(155.171888 + coefficientWidth, 197.519024 + coefficientDiskDiameter, 
                99.632216, 181.797188 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(156.669932 + coefficientWidth, 192.226968 + coefficientDiskDiameter, 5.5, 
                155.171888 + coefficientWidth, 197.519024 + coefficientDiskDiameter, 
                156.190575 + coefficientWidth, 197.706038 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(156.190575 + coefficientWidth, 197.706038 + coefficientDiskDiameter, 
                171.1633 + coefficientWidth, 199.015982 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(170.1 + coefficientWidth, 211.169557 + coefficientDiskDiameter, 12.2, 
                171.1633 + coefficientWidth, 199.015982 + coefficientDiskDiameter, 
                182.3 + coefficientWidth, 211.169558 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(182.3 + coefficientWidth, 211.438908 + coefficientDiskDiameter, 
                182.3 + coefficientWidth, 211.169558 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(187.8 + coefficientWidth, 211.438908 + coefficientDiskDiameter, 5.5, 
                182.3 + coefficientWidth, 211.438908 + coefficientDiskDiameter, 
                187.8 + coefficientWidth, 216.938908 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(191.1 + coefficientWidth, 216.938908 + coefficientDiskDiameter, 
                187.8 + coefficientWidth, 216.938908 + coefficientDiskDiameter, 1);

            doc.ksLineSeg(89, 181.271659 + coefficientDiskDiameter, 
                89, 177.071659 + coefficientDiskDiameter, 1);
            doc.ksLineSeg(89, 177.071659 + coefficientDiskDiameter,
                53.280301, 177.071659 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(53.280301, 167.371659 + coefficientDiskDiameter, 9.7,
                53.280301, 177.071659 + coefficientDiskDiameter,
                44.489115, 171.471056 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(44.489115, 171.471056 + coefficientDiskDiameter,
                30.474023, 141.415595 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(41.530978, 136.259652 + coefficientDiskDiameter, 12.2,
                30.474023, 141.415595 + coefficientDiskDiameter,
                35.430978, 125.694142 + coefficientDiskDiameter, 1, 1);
            doc.ksLineSeg(62.15, 110.267908 + coefficientCentralHole,
                35.430978, 125.694142 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(57.3, 101.867462 + coefficientCentralHole, 9.7,
                62.15, 110.267908 + coefficientCentralHole,
                67, 101.867462 + coefficientCentralHole, -1, 1);
            doc.ksLineSeg(67, 91.999746 + coefficientCentralHole + coefficientAttachedPlane,
                67, 101.867462 + coefficientCentralHole, 1);
            doc.ksArcByPoint(53.1, 91.999746 + coefficientCentralHole + coefficientAttachedPlane, 13.9,
                67, 91.999746 + coefficientCentralHole + coefficientAttachedPlane,
                63.990722, 83.36249 + coefficientCentralHole + coefficientAttachedPlane, -1, 1);
            doc.ksArcByPoint(68.3, 79.944871 + coefficientCentralHole + coefficientAttachedPlane, 5.5,
                63.990722, 83.36249 + coefficientCentralHole + coefficientAttachedPlane,
                62.8, 79.944871 + coefficientCentralHole + coefficientAttachedPlane, 1, 1);
            doc.ksLineSeg(62.8, 59.75 + coefficientCentralHole,
                62.8, 79.944871 + coefficientCentralHole + coefficientAttachedPlane, 1);
            doc.ksArcByPoint(64.1, 59.75 + coefficientCentralHole, 1.3,
                62.8, 59.75 + coefficientCentralHole,
                64.1, 58.45 + coefficientCentralHole, 1, 1);
            doc.ksLineSeg(64.1, 58.45 + coefficientCentralHole,
                67, 58.45 + coefficientCentralHole, 1);
            doc.ksLineSeg(67, 54.25 + coefficientCentralHole,
                67, 58.45 + coefficientCentralHole, 1);

            doc.ksLineSeg(64.1, 54.25 + coefficientCentralHole,
                67, 54.25 + coefficientCentralHole, 1);
            doc.ksArcByPoint(64.1, 59.75 + coefficientCentralHole, 5.5,
                64.1, 54.25 + coefficientCentralHole,
                58.6, 59.75 + coefficientCentralHole, -1, 1);
            doc.ksLineSeg(58.6, 79.944871 + coefficientCentralHole + coefficientAttachedPlane,
                58.6, 59.75 + coefficientCentralHole, 1);
            doc.ksArcByPoint(68.3, 79.944871 + coefficientCentralHole + coefficientAttachedPlane, 9.7,
                58.6, 79.944871 + coefficientCentralHole + coefficientAttachedPlane,
                60.7, 85.972309 + coefficientCentralHole + coefficientAttachedPlane, -1, 1);
            doc.ksArcByPoint(53.1, 91.999746 + coefficientCentralHole + coefficientAttachedPlane, 9.7,
                60.7, 85.972309 + coefficientCentralHole + coefficientAttachedPlane,
                62.8, 91.999746 + coefficientCentralHole + coefficientAttachedPlane, 1, 1);
            doc.ksLineSeg(62.8, 91.999746 + coefficientCentralHole + coefficientAttachedPlane,
                62.8, 101.867462 + coefficientCentralHole, 1);
            doc.ksArcByPoint(57.3, 101.867462 + coefficientCentralHole, 5.5,
                62.8, 101.867462 + coefficientCentralHole,
                60.05, 106.630601 + coefficientCentralHole, 1, 1);
            doc.ksLineSeg(60.05, 106.630601 + coefficientCentralHole,
                33.330978, 122.056836 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(41.530978, 136.259652 + coefficientDiskDiameter, 16.4,
                33.330978, 122.056836 + coefficientDiskDiameter,
                26.667531, 143.190592 + coefficientDiskDiameter, -1, 1);
            doc.ksLineSeg(40.682622, 173.246052 + coefficientDiskDiameter,
                26.667531, 143.190592 + coefficientDiskDiameter, 1);
            doc.ksArcByPoint(53.280301, 167.371659 + coefficientDiskDiameter,
                13.9, 40.682622, 173.246052 + coefficientDiskDiameter,
                53.280301, 181.271659 + coefficientDiskDiameter, -1, 1);

            doc.ksLineSeg(0, 0, 100, 0, 3);
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
        private ksEntity CreateAxis(Kompas6Constants3D.Obj3dType plane1, Kompas6Constants3D.Obj3dType plane2)
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
        private ksEntity CreatePlaneAngle(int angle, Kompas6Constants3D.Obj3dType plane, ksEntity axis)
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
            var planeAngel = CreatePlaneAngle(diskParams.AirVentsAnglePlane, Obj3dType.o3d_planeXOY, axis);
            var planeOffset = MovePlane(planeAngel, diskParams.DistanceFromAirVentsPlane);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeOffset);
            sketch.Create();
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle(diskParams.AirVentsArrangementDiameters[diskParams.DiskDiameter], 0,
                (double)diskParams.AirVentsDiameter / 2, 1);
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
            ksEntity cutExtrusion = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition extrusionDefinition = cutExtrusion.GetDefinition();
            ksExtrusionParam extrusionParam = (ksExtrusionParam)extrusionDefinition.ExtrusionParam();
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
            ksEntity circularCopy = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_circularCopy);
            ksCircularCopyDefinition circularCopyDefinition = circularCopy.GetDefinition();
            var axis = CreateAxis(Obj3dType.o3d_planeXOY, Obj3dType.o3d_planeXOZ);
            circularCopyDefinition.SetAxis(axis);
            circularCopyDefinition.SetCopyParamAlongDir(countElements, 360, true, false);
            ksEntityCollection entityCollection = circularCopyDefinition.GetOperationArray();
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
        private ksEntity DrawBoltHoleSketch(double boltArrangementDiameter, double boltHoleDiameter)
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
            var planeAngle = CreatePlaneAngle(diskParams.NippleHoleAnglePlane, Obj3dType.o3d_planeYOZ, axis);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeAngle);
            sketch.Create();
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle(diskParams.NippleHoleArrangementDiameters[diskParams.DiskDiameter], 0, 
                diskParams.NippleHoleDiameter / 2, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        } 
    }
}
