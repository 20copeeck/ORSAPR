using NUnit.Framework;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса ArcSegment")]
    class ArcSegmentTests
    {
        /// <summary>
        /// Параметры дуги
        /// </summary>
        private ArcSegment _arcSegment;

        [SetUp]
        public void SetArcSegment()
        {
            _arcSegment = new ArcSegment((3.3, 211.438908), 9.7, 
                (3.3, 221.138908), (13, 211.438908));
        }

        [Test(Description = "Позитивный тест геттера CentralPoint")]
        public void GetCentralPoint_PositiveTest()
        {
            var expected = (3.3, 211.438908);
            var actual = _arcSegment.CentralPoint;
            Assert.AreEqual(expected, actual, "Геттер CentralPoint " +
                "возвращает неправильные координаты центра дуги");
        }

        [Test(Description = "Позитивный тест геттера Radius")]
        public void GetRadius_PositiveTest()
        {
            var expected = 9.7;
            var actual = _arcSegment.Radius;
            Assert.AreEqual(expected, actual, 
                "Геттер Radius возвращает неправильный радиус");
        }

        [Test(Description = "Позитивный тест геттера FirstPoint")]
        public void GetFirstPoint_PositiveTest()
        {
            var expected = (3.3, 221.138908);
            var actual = _arcSegment.FirstPoint;
            Assert.AreEqual(expected, actual, "Геттер FirstPoint " +
                "возвращает неправильные координаты первой точки");
        }

        [Test(Description = "Позитивный тест геттера SecondPoint")]
        public void GetSecondPoint_PositiveTest()
        {
            var expected = (13, 211.438908);
            var actual = _arcSegment.SecondPoint;
            Assert.AreEqual(expected, actual, "Геттер SecondPoint " +
                "возвращает неправильные координаты второй точки");
        }
    }
}
