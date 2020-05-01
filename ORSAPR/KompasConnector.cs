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
    /// <summary>
    /// Класс обеспечивающий запуск и завершение работы программы KOMPAS 3D
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Объект KOMPAS-а
        /// </summary>
        public KompasObject KompasObject { get; private set; }

        /// <summary>
        /// Открыть программу KOMPAS 3D
        /// </summary>
        public void StartKompas()
        {
            KompasObject kompas = null;
            try
            {
                kompas = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
                kompas.Visible = true;
            }
            catch
            {
                Type type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                kompas = (KompasObject)Activator.CreateInstance(type);
                kompas.Visible = true;
            }
            kompas.ActivateControllerAPI();
            KompasObject = kompas;
        }

        /// <summary>
        /// Закрыть программу KOMPAS 3D
        /// </summary>
        public void StopKompas()
        {
            if(KompasObject != null)
            {
                KompasObject.Quit();
                KompasObject = null;
            }
            else
            {
                throw new Exception("KOMPAS 3D уже закрыт");
            }
        }
    }
}

