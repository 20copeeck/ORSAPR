using System;
using NUnit.Framework;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса DiskParams")]
    public class DiskParamsTests
    {
        /// <summary>
        /// Параметры диска
        /// </summary>
        private DiskParams _diskParams;

        [SetUp]
        public void SetParams()
        {
            _diskParams = new DiskParams();
        }

        [Test(Description = "Негативный тест сеттера свойства DiskDiameter")]
        [TestCase(12, TestName = 
            "Негативный тест со значением диаметра диска меньше минимального")]
        [TestCase(20, TestName = 
            "Негативный тест со значением диаметра диска больше максимального")]
        public void SetDiskDiameter_NegativeTest(int diskDiameter)
        {
            Assert.Throws<ArgumentException>(() => _diskParams.DiskDiameter = diskDiameter);
        }

        [Test(Description = "Позитивный тест сеттера свойства DiskDiameter")]
        [TestCase(13, TestName = "Позитивный тест со значением диаметра диска 13")]
        [TestCase(14, TestName = "Позитивный тест со значением диаметра диска 14")]
        [TestCase(15, TestName = "Позитивный тест со значением диаметра диска 15")]
        [TestCase(16, TestName = "Позитивный тест со значением диаметра диска 16")]
        [TestCase(17, TestName = "Позитивный тест со значением диаметра диска 17")]
        [TestCase(18, TestName = "Позитивный тест со значением диаметра диска 18")]
        [TestCase(19, TestName = "Позитивный тест со значением диаметра диска 19")]
        public void SetDiskDiameter_PositiveTest(int diskDiameter)
        {
            _diskParams.DiskDiameter = diskDiameter;
        }

        [Test(Description = "Позитивный тест геттера DiskDiameter")]
        public void GetDiskDiameter_PositiveTest()
        {
            var expected = 16;
            _diskParams.DiskDiameter = expected;
            var actual = _diskParams.DiskDiameter;
            Assert.AreEqual(expected, actual,
                "Геттер DiskDiameter возвращает неправильное значение диаметра диска");
        }

        [Test(Description = "Негативный тест сеттера свойства Width")]
        [TestCase(6, TestName = "Негативный тест со значением ширины меньше минимальной")]
        [TestCase(10.5, TestName = "Негативный тест со значением ширины больше максимальной")]
        [TestCase(7.5, TestName = 
            "Негативный тест со значением ширины в промежутке между допустимыми значениями")]
        public void SetWidth_NegativeTest(double width)
        {
            Assert.Throws<ArgumentException>(() => _diskParams.Width = width);
        }

        [Test(Description = "Позитивный тест сеттера свойства Width")]
        [TestCase(6.5, TestName = "Позитивный тест со значением ширины 6.5")]
        [TestCase(7, TestName = "Позитивный тест со значением ширины 7")]
        [TestCase(8, TestName = "Позитивный тест со значением ширины 8")]
        [TestCase(10, TestName = "Позитивный тест со значением ширины 10")]
        public void SetWidth_PositiveTest(double width)
        {
            _diskParams.Width = width;
        }

        [Test(Description = "Позитивный тест геттера Width")]
        public void GetWidth_PositiveTest()
        {
            var expected = 6.5;
            _diskParams.Width = expected;
            var actual = _diskParams.Width;
            Assert.AreEqual(expected, actual,
                "Геттер Width возвращает неправильное значение ширины");
        }

        [Test(Description = "Негативный тест сеттера свойства BoltsCount")]
        [TestCase(3, TestName = 
            "Негативный тест со значением количества болтов меньше минимального")]
        [TestCase(7, TestName = 
            "Негативный тест со значением количества болтов больше максимального")]
        public void SetBoltsCount_NegativeTest(int boltsCount)
        {
            Assert.Throws<ArgumentException>(() => _diskParams.BoltsCount = boltsCount);
        }

        [Test(Description = "Позитивный тест сеттера свойства BoltsCount")]
        [TestCase(4, TestName = "Позитивный тест со значением количества болтов 4")]
        [TestCase(5, TestName = "Позитивный тест со значением количества болтов 5")]
        [TestCase(6, TestName = "Позитивный тест со значением количества болтов 6")]
        public void SetBoltsCount_PositiveTest(int boltsCount)
        {
            _diskParams.BoltsCount = boltsCount;
        }

        [Test(Description = "Позитивный тест геттера BoltsCount")]
        public void GetBoltsCount_PositiveTest()
        {
            var expected = 5;
            _diskParams.BoltsCount = expected;
            var actual = _diskParams.BoltsCount;
            Assert.AreEqual(expected, actual,
                "Геттер BoltsCount возвращает неправильное значение количества болтов");
        }

        [Test(Description = "Негативный тест сеттера свойства BoltArrangementDiameter")]
        [TestCase(97, TestName = 
            "Негативный тест со значением диаметра расположения болтов меньше минимального")]
        [TestCase(170, TestName = 
            "Негативный тест со значением диаметра расположения болтов больше максимального")]
        [TestCase(112.5, TestName = 
            "Негативный тест со значением диаметра расположения болтов в промежутке между " +
            "допустимыми значениями")]
        public void SetBoltArrangementDiameter_NegativeTest(double boltArrangementDiameter)
        {
            Assert.Throws<ArgumentException>(() => 
            _diskParams.BoltArrangementDiameter = boltArrangementDiameter);
        }

        [Test(Description = "Позитивный тест сеттера свойства BoltArrangementDiameter")]
        [TestCase(98, TestName = 
            "Позитивный тест со значением диаметра расположения болтов 98")]
        [TestCase(114.3, TestName = 
            "Позитивный тест со значением диаметра расположения болтов 114.3")]
        [TestCase(115, TestName = 
            "Позитивный тест со значением диаметра расположения болтов 115")]
        [TestCase(165, TestName = 
            "Позитивный тест со значением диаметра расположения болтов 165")]
        public void SetBoltArrangementDiameter_PositiveTest(double boltArrangementDiameter)
        {
            _diskParams.BoltArrangementDiameter = boltArrangementDiameter;
        }

        [Test(Description = "Позитивный тест геттера BoltArrangementDiameter")]
        public void GetBoltArrangementDiameter_PositiveTest()
        {
            var expected = 139.7;
            _diskParams.BoltArrangementDiameter = expected;
            var actual = _diskParams.BoltArrangementDiameter;
            Assert.AreEqual(expected, actual,
                "Геттер BoltArrangementDiameter возвращает неправильное значение диаметра " +
                "расположения болтов");
        }

        [Test(Description = "Негативный тест сеттера свойства CentralHoleDiameter")]
        [TestCase(95, TestName = 
            "Негативный тест со значением диаметра центрального отверстия меньше минимального")]
        [TestCase(110.5, TestName =
            "Негативный тест со значением диаметра центрального отверстия больше максимального")]
        [TestCase(100, TestName =
            "Негативный тест со значением диаметра центрального отверстия в промежутке между " +
            "допустимыми значениями")]
        public void SetCentralHoleDiameter_NegativeTest(double centralHoleDiameter)
        {
            Assert.Throws<ArgumentException>(() => 
            _diskParams.CentralHoleDiameter = centralHoleDiameter);
        }

        [Test(Description = "Позитивный тест сеттера свойства CentralHoleDiameter")]
        [TestCase(95.3, TestName = 
            "Позитивный тест со значением диаметра центрального отверстия 95.3")]
        [TestCase(98.1, TestName = 
            "Позитивный тест со значением диаметра центрального отверстия 98.1")]
        [TestCase(98.6, TestName = 
            "Позитивный тест со значением диаметра центрального отверстия 98.6")]
        [TestCase(108.5, TestName = 
            "Позитивный тест со значением диаметра центрального отверстия 108.5")]
        [TestCase(110.1, TestName = 
            "Позитивный тест со значением диаметра центрального отверстия 110.1")]
        public void SetCentralHoleDiameter_PositiveTest(double centralHoleDiameter)
        {
            _diskParams.CentralHoleDiameter = centralHoleDiameter;
        }

        [Test(Description = "Позитивный тест геттера CentralHoleDiameter")]
        public void GetCentralHoleDiameter_PositiveTest()
        {
            var expected = 108.5;
            _diskParams.CentralHoleDiameter = expected;
            var actual = _diskParams.CentralHoleDiameter;
            Assert.AreEqual(expected, actual,
                "Геттер CentralHoleDiameter возвращает неправильное значение диаметра " +
                "центрального отверстия");
        }

        [Test(Description = "Негативный тест сеттера свойства AirVentsCount")]
        [TestCase(11, TestName = 
            "Негативный тест со значением количества вентиляционных отверстий " +
            "меньше минимального")]
        [TestCase(17, TestName =
            "Негативный тест со значением количества вентиляционных отверстий " +
            "больше максимального")]
        public void SetAirVentsCount_NegativeTest(int airVentsCount)
        {
            Assert.Throws<ArgumentException>(() => _diskParams.AirVentsCount = airVentsCount);
        }

        [Test(Description = "Позитивный тест сеттера свойства AirVentsCount")]
        [TestCase(12, TestName = 
            "Позитивный тест со значением количества вентиляционных отверстий 12")]
        [TestCase(13, TestName = 
            "Позитивный тест со значением количества вентиляционных отверстий 13")]
        [TestCase(14, TestName = 
            "Позитивный тест со значением количества вентиляционных отверстий 14")]
        [TestCase(15, TestName = 
            "Позитивный тест со значением количества вентиляционных отверстий 15")]
        [TestCase(16, TestName = 
            "Позитивный тест со значением количества вентиляционных отверстий 16")]
        public void SetAirVentsCount_PositiveTest(int airVentsCount)
        {
            _diskParams.AirVentsCount = airVentsCount;
        }

        [Test(Description = "Позитивный тест геттера AirVentsCount")]
        public void GetAirVentsCount_PositiveTest()
        {
            var expected = 12;
            _diskParams.AirVentsCount = expected;
            var actual = _diskParams.AirVentsCount;
            Assert.AreEqual(expected, actual,
                "Геттер AirVentsCount возвращает неправильное значение количества" +
                " вентиляционных отверстий");
        }

        [Test(Description = "Негативный тест сеттера свойства AirVentsDiameter")]
        [TestCase(14, TestName =
            "Негативный тест со значением диаметра вентиляционных отверстий " +
            "меньше минимального")]
        [TestCase(41, TestName =
            "Негативный тест со значением диаметра вентиляционных отверстий " +
            "больше максимального")]
        [TestCase(-20, TestName =
            "Негативный тест с отрицательным значением диаметра вентиляционных отверстий")]
        public void SetAirVentsDiameter_NegativeTest(decimal airVentsDiameter)
        {
            Assert.Throws<ArgumentException>(() =>
            _diskParams.AirVentsDiameter = airVentsDiameter);
        }

        [Test(Description = "Позитивный тест сеттера свойства AirVentsDiameter")]
        [TestCase(15, TestName = 
            "Позитивный тест со значением диаметра вентиляционных отверстий 15")]
        [TestCase(25.5, TestName = 
            "Позитивный тест со значением диаметра вентиляционных отверстий 25.5")]
        [TestCase(40, TestName = 
            "Позитивный тест со значением диаметра вентиляционных отверстий 40")]
        public void SetAirVentsDiameter_PositiveTest(decimal airVentsDiameter)
        {
            _diskParams.AirVentsDiameter = airVentsDiameter;
        }

        [Test(Description = "Позитивный тест геттера AirVentsDiameter")]
        public void GetAirVentsDiameter_PositiveTest()
        {
            var expected = 30;
            _diskParams.AirVentsDiameter = expected;
            var actual = _diskParams.AirVentsDiameter;
            Assert.AreEqual(expected, actual,
                "Геттер AirVentsDiameter возвращает неправильное значение диаметра " +
                "вентиляционных отверстий");
        }
    }
}
