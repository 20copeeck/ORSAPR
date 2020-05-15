namespace Model
{
    /// <summary>
    /// Параметры дуги
    /// </summary>
    public class ArcSegment
    {
        /// <summary>
        /// Координаты центра
        /// </summary>
        public (double X, double Y) CentralPoint { get; }
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius;
        /// <summary>
        /// Координаты первой точки
        /// </summary>
        public (double X, double Y) FirstPoint { get; }
        /// <summary>
        /// Координаты второй точки
        /// </summary>
        public (double X, double Y) SecondPoint { get; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="centralPoint">Координаты центра</param>
        /// <param name="radius">Радиус</param>
        /// <param name="firstPoint">Координаты первой точки</param>
        /// <param name="secondPoint">Координаты второй точки</param>
        public ArcSegment((double, double) centralPoint, double radius,
            (double, double) firstPoint, (double, double) secondPoint)
        {
            CentralPoint = centralPoint;
            Radius = radius;
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
    }
}
