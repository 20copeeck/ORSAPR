using Kompas6API5;
using System;
using System.Runtime.InteropServices;

namespace KompasAPI
{
    /// <summary>
    /// Запуск и завершение работы программы KOMPAS 3D
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Объект Компаса
        /// </summary>
        public KompasObject KompasObject { get; private set; }

        /// <summary>
        /// Открыть программу Компас 3D
        /// </summary>
        public void StartKompas()
        {
            KompasObject kompas = null;
            try
            {
                kompas = (KompasObject)Marshal.GetActiveObject
                    ("KOMPAS.Application.5");
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
        /// Закрыть программу Компас 3D
        /// </summary>
        public void StopKompas()
        {
            KompasObject.Quit();
            KompasObject = null;
        }
    }
}

