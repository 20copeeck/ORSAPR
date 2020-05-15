using NUnit.Framework;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса LineSegment")]
    class LineSegmentTests
    {
        /// <summary>
        /// Параметры отрезка
        /// </summary>
        private LineSegment _lineSegment;

        [SetUp]
        public void SetLineSegment()
        {
            _lineSegment = new LineSegment((0, 216.938908), (0, 221.138908));
        }

        [Test(Description = "Позитивный тест геттера FirstPoint")]
        public void GetFirstPoint_PositiveTest()
        {
            var expected = (0, 216.938908);
            var actual = _lineSegment.FirstPoint;
            Assert.AreEqual(expected, actual, "Геттер FirstPoint " +
                "возвращает неправильные координаты первой точки");
        }

        [Test(Description = "Позитивный тест геттера SecondPoint")]
        public void GetSecondPoint_PositiveTest()
        {
            var expected = (0, 221.138908);
            var actual = _lineSegment.SecondPoint;
            Assert.AreEqual(expected, actual, "Геттер SecondPoint " +
                "возвращает неправильные координаты второй точки");
        }
    }
}
