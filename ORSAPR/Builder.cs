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

        public bool Build()
        {
            var kompas = KompasConnector.KompasObject;
            if (kompas == null)
            {
                return false;
            }
            var iDocument3D = (ksDocument3D)kompas.Document3D();
            iDocument3D.Create(false, true);
            //Получение интерфейса детали
            var iPart = (ksPart)iDocument3D.GetPart((short)Part_Type.pTop_Part);

            //Получаем интерфейс базовой плоскости ХОZ
            var planeXOZ = iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            //Создаем новый эскиз
            var iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);
            //Получаем интерфейс свойств эскиза
            var iDefinitionSketch = iSketch.GetDefinition();
            //Устанавливаем плоскость эскиза
            iDefinitionSketch.SetPlane(planeXOZ);
            //Создание эскиза
            iSketch.Create();
            //Создание нового 2Д документа
            var doc = (ksDocument2D)iDefinitionSketch.BeginEdit();

            doc.ksLineSeg(0, 215.9, 0, 220.1, 1);
            doc.ksLineSeg(0, 220.1, 3.3, 220.1, 1);
            doc.ksArcByPoint(3.3, 210.4, 9.7, 3.3, 220.1, 13, 210.4, -1, 1);
            doc.ksLineSeg(13, 210.4, 13, 210.130649, 1);
            doc.ksArcByPoint(21, 210.130649, 8, 13, 210.130649, 20.302754, 202.161092, 1, 1);
            doc.ksLineSeg(20.302754, 202.161092, 30.967828, 201.228019, 1);
            doc.ksArcByPoint(30.122417, 191.56493, 9.7, 30.967828, 201.228019, 39.237435, 194.882526, -1, 1);
            doc.ksLineSeg(39.237435, 194.882526, 40.717837, 190.815155, 1);
            doc.ksArcByPoint(49.832856, 194.13275, 9.7, 40.717837, 190.815155, 49.832856, 184.43275, 1, 1);
            doc.ksLineSeg(49.832856, 184.43275, 96.030545, 184.43275, 1);
            doc.ksArcByPoint(96.030545, 194.13275, 9.7, 96.030545, 184.43275, 99.455486, 185.057521, 1, 1);
            doc.ksLineSeg(139.626804, 200.217953, 99.455486, 185.057521, 1);
            doc.ksArcByPoint(143.051744, 191.142724, 9.7, 139.626804, 200.217953, 142.206334, 200.805813, -1, 1);
            doc.ksLineSeg(157.697246, 202.161092, 142.206334, 200.805813, 1);
            doc.ksArcByPoint(157, 210.130649, 8, 157.697246, 202.161092, 165, 210.130649, 1, 1);
            doc.ksLineSeg(165, 210.4, 165, 210.130649, 1);
            doc.ksArcByPoint(174.7, 210.4, 9.7, 165, 210.4, 174.7, 220.1, -1, 1);
            doc.ksLineSeg(174.7, 220.1, 178, 220.1, 1);
            doc.ksLineSeg(178, 215.9, 178, 220.1, 1);

            doc.ksLineSeg(0, 215.9, 3.3, 215.9, 1);
            doc.ksArcByPoint(3.3, 210.4, 5.5, 3.3, 215.9, 8.8, 210.4, -1, 1);
            doc.ksLineSeg(8.8, 210.4, 8.8, 210.130649, 1);
            doc.ksArcByPoint(21, 210.130649, 12.2, 8.8, 210.130649, 19.9367, 197.977074, 1, 1);
            doc.ksLineSeg(30.601773, 197.044001, 19.9367, 197.977074, 1);
            doc.ksArcByPoint(30.122417, 191.56493, 5.5, 30.601773, 197.044001, 35.290726, 193.446041, -1, 1);
            doc.ksLineSeg(36.771128, 189.37867, 35.290726, 193.446041, 1);
            doc.ksArcByPoint(49.832856, 194.13275, 13.9, 36.771128, 189.37867, 49.832856, 180.23275, 1, 1);
            
            
            doc.ksLineSeg(96.030545, 180.23275, 89, 180.23275, 1);
            doc.ksLineSeg(53.280301, 180.23275, 49.832856, 180.23275, 1);


            doc.ksArcByPoint(96.030545, 194.13275, 13.9, 96.030545, 180.23275, 100.93845, 181.128041, 1, 1);
            doc.ksLineSeg(141.109768, 196.288472, 100.93845, 181.128041, 1);
            doc.ksArcByPoint(143.051744, 191.142724, 5.5, 141.109768, 196.288472, 142.572388, 196.621795, -1, 1);
            doc.ksLineSeg(142.572388, 196.621795, 158.0633, 197.977074, 1);
            doc.ksArcByPoint(157, 210.130649, 12.2, 158.0633, 197.977074, 169.2, 210.130649, 1, 1);
            doc.ksLineSeg(169.2, 210.4, 169.2, 210.130649, 1);
            doc.ksArcByPoint(174.7, 210.4, 5.5, 169.2, 210.4, 174.7, 215.9, -1, 1);
            doc.ksLineSeg(178, 215.9, 174.7, 215.9, 1);

            doc.ksLineSeg(89, 180.23275, 89, 176.03275, 1);
            doc.ksLineSeg(89, 176.03275, 53.280301, 176.03275, 1);
            doc.ksArcByPoint(53.280301, 166.33275, 9.7, 53.280301, 176.03275, 44.489115, 170.432148, 1, 1);
            doc.ksLineSeg(44.489115, 170.432148, 30.474023, 140.376687, 1);
            doc.ksArcByPoint(41.530978, 135.220744, 12.2, 30.474023, 140.376687, 35.430978, 124.655234, 1, 1);
            doc.ksLineSeg(62.15, 109.229, 35.430978, 124.655234, 1);
            doc.ksArcByPoint(57.3, 100.828553, 9.7, 62.15, 109.229, 67, 100.828553, -1, 1);
            doc.ksLineSeg(67, 91.999746, 67, 100.828553, 1);
            doc.ksArcByPoint(53.1, 91.999746, 13.9, 67, 91.999746, 63.990722, 83.36249, -1, 1);
            doc.ksArcByPoint(68.3, 79.944871, 5.5, 63.990722, 83.36249, 62.8, 79.944871, 1, 1);
            doc.ksLineSeg(62.8, 59.75, 62.8, 79.944871, 1);
            doc.ksArcByPoint(64.1, 59.75, 1.3, 62.8, 59.75, 64.1, 58.45, 1, 1);
            doc.ksLineSeg(64.1, 58.45, 67, 58.45, 1);
            doc.ksLineSeg(67, 54.25, 67, 58.45, 1);
            
            doc.ksLineSeg(64.1, 54.25, 67, 54.25, 1);
            doc.ksArcByPoint(64.1, 59.75, 5.5, 64.1, 54.25, 58.6, 59.75, -1, 1);
            doc.ksLineSeg(58.6, 79.944871, 58.6, 59.75, 1);
            doc.ksArcByPoint(68.3, 79.944871, 9.7, 58.6, 79.944871, 60.7, 85.972308, -1, 1);
            doc.ksArcByPoint(53.1, 91.999746, 9.7, 60.7, 85.972308, 62.8, 91.999746, 1, 1);
            doc.ksLineSeg(62.8, 91.999746, 62.8, 100.828553, 1);
            doc.ksArcByPoint(57.3, 100.828553, 5.5, 62.8, 100.828553, 60.05, 105.591693, 1, 1);
            doc.ksLineSeg(60.05, 105.591693, 33.330978, 121.017927, 1);
            doc.ksArcByPoint(41.530978, 135.220744, 16.4, 33.330978, 121.017927, 26.667531, 142.151684, -1, 1);
            doc.ksLineSeg(40.682622, 172.207144, 26.667531, 142.151684, 1);
            doc.ksArcByPoint(53.280301, 166.33275, 13.9, 40.682622, 172.207144, 53.280301, 180.23275, -1, 1);

            doc.ksLineSeg(0, 0, 100, 0, 3);
            iDefinitionSketch.EndEdit();

            //Выдавливание вращением
            ksEntity rotatedEntity = iPart.NewEntity((short)Obj3dType.o3d_bossRotated);
            ksBossRotatedDefinition rotatedDefinition = rotatedEntity.GetDefinition();

            rotatedDefinition.SetThinParam(false);
            rotatedDefinition.SetSketch(iSketch);

            rotatedEntity.Create();

            //Получаем интерфейсы базовых плоскостей
            var planeXOY = iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            var planeYOZ = iPart.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ);

            //Получаем ось, как результат пересечения двух плоскостей
            var axis = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_axis2Planes);
            ksAxis2PlanesDefinition axis2PlanesDefinition = axis.GetDefinition();
            axis2PlanesDefinition.SetPlane(1, planeXOY);
            axis2PlanesDefinition.SetPlane(2, planeYOZ);
            axis.Create();

            //Наклоненная плоскость
            var planeAngle = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_planeAngle);
            ksPlaneAngleDefinition planeAngleDefinition = planeAngle.GetDefinition();
            planeAngleDefinition.angle = 65;
            planeAngleDefinition.SetPlane(planeXOY);
            planeAngleDefinition.SetAxis(axis);
            planeAngle.Create();

            // _________Э_С_К_И_З_____________

            var sketch2 =
            (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);
            var definitionSketch2 = sketch2.GetDefinition();
            definitionSketch2.SetPlane(planeAngle);
            sketch2.Create();
            doc = (ksDocument2D)definitionSketch2.BeginEdit();

            doc.ksCircle(156.247227, 0, 15, 1);

            definitionSketch2.EndEdit();

            //Операция вырезать выдавливанием
            ksEntity cutExtrusion = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            //Интерфейс операции вырезать выдавливанием
            ksCutExtrusionDefinition extrusionDefinition = cutExtrusion.GetDefinition();
            //Интерфейс структуры параметров выдавливания
            ksExtrusionParam extrusionParam =
            (ksExtrusionParam)extrusionDefinition.ExtrusionParam();
            //Эскиз операции вырезать выдавливанием
            extrusionDefinition.SetSketch(sketch2);
            // Направление выдавливания
            extrusionParam.direction = (short)Direction_Type.dtReverse;
            // Тип выдавливания
            extrusionParam.typeReverse = (short)End_Type.etBlind;
            // Глубина выдавливания
            extrusionParam.depthReverse = 40;
            // Создание операции
            cutExtrusion.Create();

            //Операция массив по концентрической сетке
            ksEntity circularCopy = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_circularCopy);
            //Интерфейс операции массив по концентрической сетке
            ksCircularCopyDefinition circularCopyDefinition = circularCopy.GetDefinition();


            return true;
        }
    }
}
