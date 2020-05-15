namespace Model
{
    /// <summary>
    /// Параметры отрезка
    /// </summary>
    public class LineSegment
    {
        /// <summary>
        /// Координаты первой точки
        /// </summary>
        public (double X, double Y) FirstPoint { get; }
        /// <summary>
        /// Координаты второй точки
        /// </summary>
        public (double X, double Y) SecondPoint { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstPoint">Координаты первой точки</param>
        /// <param name="secondPoint">Координаты второй точки</param>
        public LineSegment
            ((double, double) firstPoint, (double, double) secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
    }
}
