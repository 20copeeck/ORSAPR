using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;

namespace ORSAPR
{
    public class Builder
    {
        private KompasConnector _kompasConnector;
        private KompasObject _kompas;
        private ksPart _part;

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

        private void Initialize()
        {
            try
            {
                _kompas = KompasConnector.KompasObject;
                if (_kompas == null)
                {
                    throw new NullReferenceException("Экземпляр компаса равен null");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            var iDocument3D = (ksDocument3D)_kompas.Document3D();
            iDocument3D.Create(false, true);
            //Получение интерфейса детали
            _part = (ksPart)iDocument3D.GetPart((short)Part_Type.pTop_Part);
        }

        private ksEntity DrawMainDiskSketch()
        {
            //Получаем интерфейс базовой плоскости ХОZ
            var planeXOZ = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            //Создаем новый эскиз
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            //Получаем интерфейс свойств эскиза
            var iDefinitionSketch = sketch.GetDefinition();
            //Устанавливаем плоскость эскиза
            iDefinitionSketch.SetPlane(planeXOZ);
            //Создание эскиза
            sketch.Create();
            //Создание нового 2Д документа
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();

            int diamDisk = 16;
            int defoultDiamDisk = 16;
            double coef = (diamDisk * 25.4 - defoultDiamDisk * 25.4) / 2;

            double centalHole = 108.5;

            doc.ksLineSeg(0, 216.938908 + coef, 0, 221.138908 + coef, 1);
            doc.ksLineSeg(0, 221.138908 + coef, 3.3, 221.138908 + coef, 1);
            doc.ksArcByPoint(3.3, 211.438908 + coef, 9.7, 3.3, 221.138908 + coef, 13, 211.438908 + coef, -1, 1);
            doc.ksLineSeg(13, 211.438908 + coef, 13, 211.169558 + coef, 1);
            doc.ksArcByPoint(21, 211.169558 + coef, 8, 13, 211.169558 + coef, 20.302754, 203.2 + coef, 1, 1);
            doc.ksLineSeg(20.302754, 203.2 + coef, 30.967828, 202.266927 + coef, 1);
            doc.ksArcByPoint(30.122417, 192.603838 + coef, 9.7, 30.967828, 202.266927 + coef, 39.237435, 195.921434 + coef, -1, 1);
            doc.ksLineSeg(39.237435, 195.921434 + coef, 40.717837, 191.854063 + coef, 1);
            doc.ksArcByPoint(49.832856, 195.171659 + coef, 9.7, 40.717837, 191.854063 + coef, 49.832856, 185.471659 + coef, 1, 1);
            doc.ksLineSeg(49.832856, 185.471659 + coef, 96.030545, 185.471659 + coef, 1);
            doc.ksArcByPoint(96.030545, 195.171659 + coef, 9.7, 96.030545, 185.471659 + coef, 99.455486, 186.09643 + coef, 1, 1);
            doc.ksLineSeg(139.626804, 201.256861 + coef, 99.455486, 186.09643 + coef, 1);
            doc.ksArcByPoint(143.051744, 192.181632 + coef, 9.7, 139.626804, 201.256861 + coef, 142.206334, 201.844721 + coef, -1, 1);
            doc.ksLineSeg(157.697246, 203.2 + coef, 142.206334, 201.844721 + coef, 1);
            doc.ksArcByPoint(157, 211.169558 + coef, 8, 157.697246, 203.2 + coef, 165, 211.169558 + coef, 1, 1);
            doc.ksLineSeg(165, 211.438908 + coef, 165, 211.169558 + coef, 1);
            doc.ksArcByPoint(174.7, 211.438908 + coef, 9.7, 165, 211.438908 + coef, 174.7, 221.138908 + coef, -1, 1);
            doc.ksLineSeg(174.7, 221.138908 + coef, 178, 221.138908 + coef, 1);
            doc.ksLineSeg(178, 216.938908 + coef, 178, 221.138908 + coef, 1);

            doc.ksLineSeg(0, 216.938908 + coef, 3.3, 216.938908 + coef, 1);
            doc.ksArcByPoint(3.3, 211.438908 + coef, 5.5, 3.3, 216.938908 + coef, 8.8, 211.438908 + coef, -1, 1);
            doc.ksLineSeg(8.8, 211.438908 + coef, 8.8, 211.169558 + coef, 1);
            doc.ksArcByPoint(21, 211.169558 + coef, 12.2, 8.8, 211.169558 + coef, 19.9367, 199.015982 + coef, 1, 1);
            doc.ksLineSeg(30.601773, 198.082909 + coef, 19.9367, 199.015982 + coef, 1);
            doc.ksArcByPoint(30.122417, 192.603838 + coef, 5.5, 30.601773, 198.082909 + coef, 35.290726, 194.484949 + coef, -1, 1);
            doc.ksLineSeg(36.771128, 190.417579 + coef, 35.290726, 194.484949 + coef, 1);
            doc.ksArcByPoint(49.832856, 195.171659 + coef, 13.9, 36.771128, 190.417579 + coef, 49.832856, 181.271659 + coef, 1, 1);

            doc.ksLineSeg(53.280301, 181.271659 + coef, 49.832856, 181.271659 + coef, 1);
            doc.ksLineSeg(96.030545, 181.271659 + coef, 89, 181.271659 + coef, 1);

            doc.ksArcByPoint(96.030545, 195.171659 + coef, 13.9, 96.030545, 181.271659 + coef, 100.93845, 182.166949 + coef, 1, 1);
            doc.ksLineSeg(141.109768, 197.327381 + coef, 100.93845, 182.166949 + coef, 1);
            doc.ksArcByPoint(143.051744, 192.181632 + coef, 5.5, 141.109768, 197.327381 + coef, 142.572388, 197.660703 + coef, -1, 1);
            doc.ksLineSeg(142.572388, 197.660703 + coef, 158.0633, 199.015982 + coef, 1);
            doc.ksArcByPoint(157, 211.169557 + coef, 12.2, 158.0633, 199.015982 + coef, 169.2, 211.169558 + coef, 1, 1);
            doc.ksLineSeg(169.2, 211.438908 + coef, 169.2, 211.169558 + coef, 1);
            doc.ksArcByPoint(174.7, 211.438908 + coef, 5.5, 169.2, 211.438908 + coef, 174.7, 216.938908 + coef, -1, 1);
            doc.ksLineSeg(178, 216.938908 + coef, 174.7, 216.938908 + coef, 1);

            doc.ksLineSeg(89, 181.271659 + coef, 89, 177.071659 + coef, 1);
            doc.ksLineSeg(89, 177.071659 + coef, 53.280301, 177.071659 + coef, 1);
            doc.ksArcByPoint(53.280301, 167.371659 + coef, 9.7, 53.280301, 177.071659 + coef, 44.489115, 171.471056 + coef, 1, 1);
            doc.ksLineSeg(44.489115, 171.471056 + coef, 30.474023, 141.415595 + coef, 1);
            doc.ksArcByPoint(41.530978, 136.259652 + coef, 12.2, 30.474023, 141.415595 + coef, 35.430978, 125.694142 + coef, 1, 1);
            doc.ksLineSeg(62.15, 110.267908 + coef, 35.430978, 125.694142 + coef, 1);
            doc.ksArcByPoint(57.3, 101.867462 + coef, 9.7, 62.15, 110.267908 + coef, 67, 101.867462 + coef, -1, 1);
            doc.ksLineSeg(67, 93.038654 + coef, 67, 101.867462 + coef, 1);
            doc.ksArcByPoint(53.1, 93.038654 + coef, 13.9, 67, 93.038654 + coef, 63.990722, 84.401398 + coef, -1, 1);
            doc.ksArcByPoint(68.3, 80.983779 + coef, 5.5, 63.990722, 84.401398 + coef, 62.8, 80.983779 + coef, 1, 1);
            doc.ksLineSeg(62.8, 60.788908 + coef, 62.8, 80.983779 + coef, 1);
            doc.ksArcByPoint(64.1, 60.788908 + coef, 1.3, 62.8, 60.788908 + coef, 64.1, 59.488908 + coef, 1, 1);
            doc.ksLineSeg(64.1, 59.488908 + coef, 67, 59.488908 + coef, 1);
            doc.ksLineSeg(67, 55.288908 + coef, 67, 59.488908 + coef, 1);

            doc.ksLineSeg(64.1, 55.288908 + coef, 67, 55.288908 + coef, 1);
            doc.ksArcByPoint(64.1, 60.788908 + coef, 5.5, 64.1, 55.288908 + coef, 58.6, 60.788908 + coef, -1, 1);
            doc.ksLineSeg(58.6, 80.983779 + coef, 58.6, 60.788908 + coef, 1);
            doc.ksArcByPoint(68.3, 80.983779 + coef, 9.7, 58.6, 80.983779 + coef, 60.7, 87.011217 + coef, -1, 1);
            doc.ksArcByPoint(53.1, 93.038654 + coef, 9.7, 60.7, 87.011217 + coef, 62.8, 93.038654 + coef, 1, 1);
            doc.ksLineSeg(62.8, 93.038654 + coef, 62.8, 101.867462 + coef, 1);
            doc.ksArcByPoint(57.3, 101.867462 + coef, 5.5, 62.8, 101.867462 + coef, 60.05, 106.630601 + coef, 1, 1);
            doc.ksLineSeg(60.05, 106.630601 + coef, 33.330978, 122.056836 + coef, 1);
            doc.ksArcByPoint(41.530978, 136.259652 + coef, 16.4, 33.330978, 122.056836 + coef, 26.667531, 143.190592 + coef, -1, 1);
            doc.ksLineSeg(40.682622, 173.246052 + coef, 26.667531, 143.190592 + coef, 1);
            doc.ksArcByPoint(53.280301, 167.371659 + coef, 13.9, 40.682622, 173.246052 + coef, 53.280301, 181.271659 + coef, -1, 1);

            doc.ksLineSeg(0, 0, 100, 0, 3);
            iDefinitionSketch.EndEdit();
            return sketch;
        }

        private void SqueezeRotation(ksEntity sketch)
        {
            //Выдавливание вращением
            ksEntity rotatedEntity = _part.NewEntity((short)Obj3dType.o3d_bossRotated);
            ksBossRotatedDefinition rotatedDefinition = rotatedEntity.GetDefinition();
            rotatedDefinition.SetThinParam(false);
            rotatedDefinition.SetSketch(sketch);
            rotatedEntity.Create();
        }

        //Obj3dType.o3d_planeXOY (plane1)
        //Obj3dType.o3d_planeYOZ (plane2)
        //
        //Obj3dType.o3d_planeYOZ (plane1)
        //Obj3dType.o3d_planeXOZ (plane2)
        private ksEntity CreateAxis(Kompas6Constants3D.Obj3dType plane1, Kompas6Constants3D.Obj3dType plane2)
        {
            //Получаем интерфейсы базовых плоскостей
            var firstPlane = _part.GetDefaultEntity((short)plane1);
            var secondPlane = _part.GetDefaultEntity((short)plane2);
            //Получаем ось, как результат пересечения двух плоскостей
            var axis = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_axis2Planes);
            ksAxis2PlanesDefinition axisPlanesDefinition = axis.GetDefinition();
            axisPlanesDefinition.SetPlane(1, firstPlane);
            axisPlanesDefinition.SetPlane(2, secondPlane);
            axis.Create();
            return axis;
        }

        // Первая наклонная(plane) - Obj3dType.o3d_planeXOY
        // var axis = CreateAxis(Obj3dType.o3d_planeXOY, Obj3dType.o3d_planeYOZ)
        // angle = 65
        //
        // Вторая наклонная(plane) - Obj3dType.o3d_planeYOZ
        // var axis = CreateAxis(Obj3dType.o3d_planeYOZ, Obj3dType.o3d_planeXOZ)
        // angle = -20
        private ksEntity CreatePlaneAngle(int angle, Kompas6Constants3D.Obj3dType plane, ksEntity axis)
        {
            //Наклоненная плоскость
            var planeAngle = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_planeAngle);
            ksPlaneAngleDefinition planeAngleDefinition = planeAngle.GetDefinition();
            planeAngleDefinition.angle = angle;
            var basePlane = _part.GetDefaultEntity((short)plane);
            planeAngleDefinition.SetPlane(basePlane);
            planeAngleDefinition.SetAxis(axis);
            planeAngle.Create();
            return planeAngle;
        }

        private ksEntity DrawAirVentsSketch()
        {
            var axis = CreateAxis(Obj3dType.o3d_planeXOY, Obj3dType.o3d_planeYOZ);
            var plane = CreatePlaneAngle(65, Obj3dType.o3d_planeXOY, axis);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            //Получаем интерфейс свойств эскиза
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(plane);
            sketch.Create();
            //Создание нового 2Д документа
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle(157.63, 0, 15, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        }

        // DrawSketch2()
        // extrusionParam.depthReverse = 40;
        //
        // DrawSketch3()
        // extrusionParam.depthNormal = 65;
        //
        // DrawSketch4()
        // extrusionParam.depthNormal = 110;
        private ksEntity CutExtrusion(ksEntity sketch, Kompas6Constants3D.Direction_Type direction, int depth)
        {
            //Операция вырезать выдавливанием
            ksEntity cutExtrusion = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            //Интерфейс операции вырезать выдавливанием
            ksCutExtrusionDefinition extrusionDefinition = cutExtrusion.GetDefinition();
            //Интерфейс структуры параметров выдавливания
            ksExtrusionParam extrusionParam = (ksExtrusionParam)extrusionDefinition.ExtrusionParam();
            //Эскиз операции вырезать выдавливанием
            extrusionDefinition.SetSketch(sketch);
            if (direction == Direction_Type.dtReverse)
            {
                // Направление выдавливания
                extrusionParam.direction = (short)direction;
                // Тип выдавливания
                extrusionParam.typeReverse = (short)End_Type.etBlind;
                // Глубина выдавливания
                extrusionParam.depthReverse = depth;
            }
            else
            {
                // Направление выдавливания
                extrusionParam.direction = (short)direction;
                // Тип выдавливания
                extrusionParam.typeNormal = (short)End_Type.etBlind;
                // Глубина выдавливания
                extrusionParam.depthNormal = depth;
            }
            // Создание операции
            cutExtrusion.Create();
            return cutExtrusion;
        }

        // numberElements = 12
        // CutExtrusion() с dtReverse
        //
        // numberElements = 5
        // CutExtrusion() с dtNormal
        private void CopyInCircules(int numberElements, ksEntity arrayElements)
        {
            //Операция массив по концентрической сетке
            ksEntity circularCopy = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_circularCopy);
            //Интерфейс операции массив по концентрической сетке
            ksCircularCopyDefinition circularCopyDefinition = circularCopy.GetDefinition();
            //Устанавливаем ось операции
            var axis = CreateAxis(Obj3dType.o3d_planeXOY, Obj3dType.o3d_planeXOZ);
            circularCopyDefinition.SetAxis(axis);
            //Устанавливаем параметры копирования
            circularCopyDefinition.SetCopyParamAlongDir(numberElements, 360, true, false);
            //Получаем массив копируемых элементов
            ksEntityCollection entityCollection = circularCopyDefinition.GetOperationArray();
            entityCollection.Clear();
            //Заполняем массив копируемых элементов
            entityCollection.Add(arrayElements);
            //Создаем операцию
            circularCopy.Create();
        }

        private ksEntity DrawBoltHoleSketch()
        {
            var planeYOZ = _part.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            //Получаем интерфейс свойств эскиза
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeYOZ);
            sketch.Create();
            //Создание нового 2Д документа
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle(0, 69.85, 7.5, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        }

        private ksEntity DrawNippleHoleSketch()
        {
            var axis = CreateAxis(Obj3dType.o3d_planeYOZ, Obj3dType.o3d_planeXOZ);
            var planeAngle = CreatePlaneAngle(-20, Obj3dType.o3d_planeYOZ, axis);
            var sketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            //Получаем интерфейс свойств эскиза
            var iDefinitionSketch = sketch.GetDefinition();
            iDefinitionSketch.SetPlane(planeAngle);
            sketch.Create();
            //Создание нового 2Д документа
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();
            doc.ksCircle(-166.218487, 0, 5.65, 1);
            iDefinitionSketch.EndEdit();
            return sketch;
        }

        public bool Build(DiskParams diskParams)
        {
            var diskDiameter = (diskParams.DiskDiameter * 25.4) / 2;




            Initialize();
            // Отрисовка основного эскиза
            var mainDiskSketch = DrawMainDiskSketch();
            // Выдавливание вращением
            SqueezeRotation(mainDiskSketch);
                        
            // Отрисовка эскиза вентиляционного отверстия
            var airVentsSketch = DrawAirVentsSketch();
            // Вырезать выдавливанием 
            var airVents = CutExtrusion(airVentsSketch, Direction_Type.dtReverse, 40);
            // Массив по концентрической сетке
            CopyInCircules(12, airVents);

            // Отрисовать эскиз отверстия под болт
            var boltHoleSketch = DrawBoltHoleSketch();
            // Вырезать выдавливанием
            var boltHole = CutExtrusion(boltHoleSketch, Direction_Type.dtNormal, 65);
            // Массив по концентрической сетке
            CopyInCircules(5, boltHole);

            // Отрисовка эскиза под ниппель
            var nippleHoleSketch = DrawNippleHoleSketch();
            // Вырезать выдавливанием
            CutExtrusion(nippleHoleSketch, Direction_Type.dtNormal, 110);

            return true;
        }
    }
}
