using NUnit.Framework;
using System.Collections.Generic;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса ValuesRelation")]
    class ValuesRelationTests
    {
        /// <summary>
        /// Зависимость доступных значений
        /// </summary>
        private ValuesRelation _valuesRelation;

        [SetUp]
        public void SetValuesRelation()
        {
            _valuesRelation = new ValuesRelation
                (
                    13,
                    new List<double>() { 5, 5.5 },
                    4,
                    98.0,
                    new List<double>() { 58.6, 60.1 }
                );
        }

        [Test(Description = "Позитивный тест геттера DiskDiameter")]
        public void GetDiskDiameter_PositiveTest()
        {
            var expected = 13;
            var actual = _valuesRelation.DiskDiameter;
            Assert.AreEqual(expected, actual, "Геттер DiskDiameter " +
                "возвращает неправильное значение диаметра диска");
        }

        [Test(Description = "Позитивный тест геттера Widths")]
        public void GetWidths_PositiveTest()
        {
            var expected = new List<double>() { 5, 5.5 };
            var actual = _valuesRelation.Widths;
            CollectionAssert.AreEqual(expected, actual, "Геттер Widths " +
                "возвращает неправильную коллекцию ширин диска");
        }

        [Test(Description = "Позитивный тест геттера BoltCount")]
        public void GetBoltCount_PositiveTest()
        {
            var expected = 4;
            var actual = _valuesRelation.BoltCount;
            Assert.AreEqual(expected, actual, "Геттер BoltCount " +
                "возвращает неправильное значение количества болтов");
        }

        [Test(Description = 
            "Позитивный тест геттера BoltArrangementDiameter")]
        public void GetBoltArrangementDiameter_PositiveTest()
        {
            var expected = 98.0;
            var actual = _valuesRelation.BoltArrangementDiameter;
            Assert.AreEqual(expected, actual, 
                "Геттер BoltArrangementDiameter возвращает неправильное " +
                "значение диаметра расположения болтов");
        }

        [Test(Description = 
            "Позитивный тест геттера CentralHoleDiameters")]
        public void GetCentralHoleDiameters_PositiveTest()
        {
            var expected = new List<double>() { 58.6, 60.1 };
            var actual = _valuesRelation.CentralHoleDiameters;
            CollectionAssert.AreEqual(expected, actual, 
                "Геттер CentralHoleDiameters возвращает неправильную " +
                "коллекцию диаметров центрального отверстия");
        }
    }
}
