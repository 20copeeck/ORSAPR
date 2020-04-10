using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;
using System.Runtime.InteropServices;

namespace ORSAPR
{
    public class KompasConnector
    {
        public KompasObject KompasObject { get; private set; }

        public void StartKompas()
        {
            KompasObject kompas = null;
            //Экзмпляр уже существует
            //Отображение необходимо в каждом случае
            //так как возможна ошибка при подключении 
            //к уже закрытому экземпляру
            try
            {
                kompas = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
                kompas.Visible = true;
            }
            //Создание нового экзмепляра
            catch
            {
                Type type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                kompas = (KompasObject)Activator.CreateInstance(type);
                kompas.Visible = true;
            }
                                    
            kompas.ActivateControllerAPI();
            KompasObject = kompas;
        }

        public void StopKompas()
        {
            KompasObject.Quit();
            KompasObject = null;
        }
    }
}

