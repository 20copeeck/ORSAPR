using NUnit.Framework;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса ParamsValidator")]
    class ParamsValidatorTests
    {
        /// <summary>
        /// Доступные параметры
        /// </summary>
        private AvailableParameters _availableParameters;

        [SetUp]
        public void SetAvailableParameters()
        {
            var diskParams = new DiskParams();
            _availableParameters = diskParams.AvailableParameters;
        }

        [Test(Description = 
            "Негативный тест метода IsValidDiskDiameter")]
        [TestCase(12, TestName = "Негативный тест со значением " +
            "диаметра диска меньше минимального")]
        [TestCase(20, TestName = "Негативный тест со значением " +
            "диаметра диска больше максимального")]
        public void IsValidDiskDiameter_NegativeTest(int diskDiameter)
        {
            Assert.IsFalse(ParamsValidator.IsValidDiskDiameter
                (_availableParameters, diskDiameter)); 
        }

        [Test(Description = 
            "Позитивный тест метода IsValidDiskDiameter")]
        [TestCase(13, TestName = 
            "Позитивный тест со значением диаметра диска 13")]
        [TestCase(14, TestName = 
            "Позитивный тест со значением диаметра диска 14")]
        [TestCase(15, TestName = 
            "Позитивный тест со значением диаметра диска 15")]
        [TestCase(16, TestName = 
            "Позитивный тест со значением диаметра диска 16")]
        [TestCase(17, TestName = 
            "Позитивный тест со значением диаметра диска 17")]
        [TestCase(18, TestName = 
            "Позитивный тест со значением диаметра диска 18")]
        [TestCase(19, TestName = 
            "Позитивный тест со значением диаметра диска 19")]
        public void IsValidDiskDiameter_PositiveTest(int diskDiameter)
        {
            Assert.IsTrue(ParamsValidator.IsValidDiskDiameter
                (_availableParameters, diskDiameter));
        }

        [Test(Description = "Негативный тест метода IsValidWidth")]
        [TestCase(6, TestName = "Негативный тест со значением ширины " +
            "диска меньше минимального")]
        [TestCase(11, TestName = "Негативный тест со значением ширины " +
            "диска больше максимального")]
        [TestCase(7.5, TestName = "Негативный тест со значением ширины" +
            " в промежутке между допустимыми значениями")]
        public void IsValidWidth_NegativeTest(double width)
        {
            Assert.IsFalse(ParamsValidator.IsValidWidth
                (_availableParameters, width));
        }

        [Test(Description = "Позитивный тест метода IsValidWidth")]
        [TestCase(6.5, TestName = 
            "Позитивный тест со значением ширины диска 6.5")]
        [TestCase(7, TestName = 
            "Позитивный тест со значением ширины диска 7")]
        [TestCase(8, TestName = 
            "Позитивный тест со значением ширины диска 8")]
        [TestCase(10, TestName = 
            "Позитивный тест со значением ширины диска 10")]
        public void IsValidWidth_PositiveTest(double width)
        {
            Assert.IsTrue(ParamsValidator.IsValidWidth
                (_availableParameters, width));
        }

        [Test(Description = "Негативный тест метода IsValidBoltsCount")]
        [TestCase(3, TestName = "Негативный тест со значением количества" +
            " болтов меньше минимального")]
        [TestCase(7, TestName = "Негативный тест со значением количества" +
            " болтов больше максимального")]
        public void IsValidBoltsCount_NegativeTest(int boltsCount)
        {
            Assert.IsFalse(ParamsValidator.IsValidBoltsCount
                (_availableParameters, boltsCount));
        }
        
        [Test(Description = "Позитивный тест метода IsValidBoltsCount")]
        [TestCase(4, TestName = 
            "Позитивный тест со значением количества болтов 4")]
        [TestCase(5, TestName = 
            "Позитивный тест со значением количества болтов 5")]
        [TestCase(6, TestName = 
            "Позитивный тест со значением количества болтов 6")]
        public void IsValidBoltsCount_PositiveTest(int boltsCount)
        {
            Assert.IsTrue(ParamsValidator.IsValidBoltsCount
                (_availableParameters, boltsCount));
        }

        [Test(Description = 
            "Негативный тест метода IsValidBoltArrangementDiameter")]
        [TestCase(97, TestName = "Негативный тест со значением диаметра" +
            " расположения болтов меньше минимального")]
        [TestCase(166, TestName = "Негативный тест со значением диаметра" +
            " расположения болтов больше максимального")]
        [TestCase(139.5, TestName = "Негативный тест со значением " +
            "диаметра расположения болтов в промежутке между " +
            "допустимыми значениями")]
        public void IsValidBoltArrangementDiameter_NegativeTest
            (double boltArrangementDiameter)
        {
            Assert.IsFalse
                (ParamsValidator.IsValidBoltArrangementDiameter
                (_availableParameters, boltArrangementDiameter));
        }

        [Test(Description = 
            "Позитивный тест метода IsValidBoltArrangementDiameter")]
        [TestCase(98, TestName = "Позитивный тест со значением " +
            "диаметра расположения болтов 98")]
        [TestCase(139.7, TestName = "Позитивный тест со значением " +
            "диаметра расположения болтов 139.7")]
        [TestCase(165, TestName = "Позитивный тест со значением " +
            "диаметра расположения болтов 165")]
        public void IsValidBoltArrangementDiameter_PositiveTest
            (double boltArrangementDiameter)
        {
            Assert.IsTrue
                (ParamsValidator.IsValidBoltArrangementDiameter
                (_availableParameters, boltArrangementDiameter));
        }

        [Test(Description = 
            "Негативный тест метода IsValidCentralHoleDiameter")]
        [TestCase(95, TestName = "Негативный тест со значением диаметра" +
            " центрального отверстия меньше минимального")]
        [TestCase(111, TestName = "Негативный тест со значением диаметра" +
            " центрального отверстия больше максимального")]
        [TestCase(98.5, TestName = "Негативный тест со значением диаметра" +
            " центрального отверстия в промежутке между " +
            "допустимыми значениями")]
        public void IsValidCentralHoleDiameter_NegativeTest
            (double centralHoleDiameter)
        {
            Assert.IsFalse
                (ParamsValidator.IsValidCentralHoleDiameter
                (_availableParameters, centralHoleDiameter));
        }

        [Test(Description = 
            "Позитивный тест метода IsValidCentralHoleDiameter")]
        [TestCase(95.3, TestName = 
            "Позитивный тест со значением центрального отверстия 95.3")]
        [TestCase(98.1, TestName = 
            "Позитивный тест со значением центрального отверстия 98.1")]
        [TestCase(98.6, TestName = 
            "Позитивный тест со значением центрального отверстия 98.6")]
        [TestCase(108.5, TestName = 
            "Позитивный тест со значением центрального отверстия 108.5")]
        [TestCase(110.1, TestName = 
            "Позитивный тест со значением центрального отверстия 110.1")]
        public void IsValidCentralHoleDiameter_PositiveTest
            (double centralHoleDiameter)
        {
            Assert.IsTrue(ParamsValidator.IsValidCentralHoleDiameter
                (_availableParameters, centralHoleDiameter));
        }

        [Test(Description = 
            "Негативный тест метода IsValidAirVentsCount")]
        [TestCase(11, TestName =
            "Негативный тест со значением количества вентиляционных " +
            "отверстий меньше минимального")]
        [TestCase(17, TestName =
            "Негативный тест со значением количества вентиляционных " +
            "отверстий больше максимального")]
        public void IsValidAirVentsCount_NegativeTest
            (double airVentsCount)
        {
            Assert.IsFalse(ParamsValidator.IsValidAirVentsCount
                (_availableParameters, airVentsCount));
        }

        [Test(Description = 
            "Позитивный тест метода IsValidAirVentsCount")]
        [TestCase(12, TestName = "Позитивный тест со значением количества" +
            " вентиляционных отверстий 12")]
        [TestCase(13, TestName = "Позитивный тест со значением количества" +
            " вентиляционных отверстий 13")]
        [TestCase(14, TestName = "Позитивный тест со значением количества" +
            " вентиляционных отверстий 14")]
        [TestCase(15, TestName = "Позитивный тест со значением количества" +
            " вентиляционных отверстий 15")]
        [TestCase(16, TestName = "Позитивный тест со значением количества" +
            " вентиляционных отверстий 16")]
        public void IsValidAirVentsCount_PositiveTest(double airVentsCount)
        {
            Assert.IsTrue(ParamsValidator.IsValidAirVentsCount
                (_availableParameters, airVentsCount));
        }

        [Test(Description = 
            "Негативный тест метода IsValidAirVentsDiameter")]
        [TestCase(14, TestName = "Негативный тест со значением диаметра" +
            " вентиляционных отверстий меньше минимального")]
        [TestCase(41, TestName = "Негативный тест со значением диаметра" +
            " вентиляционных отверстий больше максимального")]
        [TestCase(-20, TestName = "Негативный тест с отрицательным " +
            "значением диаметра вентиляционных отверстий")]
        public void IsValidAirVentsDiameter_NegativeTest
            (decimal airVentsDiameter)
        {
            Assert.IsFalse(ParamsValidator.IsValidAirVentsDiameter
                (_availableParameters, airVentsDiameter));
        }

        [Test(Description = 
            "Позитивный тест метода IsValidAirVentsDiameter")]
        [TestCase(15, TestName = "Позитивный тест со значением диаметра" +
            " вентиляционных отверстий 15")]
        [TestCase(25.5, TestName = "Позитивный тест со значением диаметра" +
            " вентиляционных отверстий 25.5")]
        [TestCase(40, TestName = "Позитивный тест со значением диаметра" +
            " вентиляционных отверстий 40")]
        public void IsValidAirVentsDiameter_PositiveTest
            (decimal airVentsDiameter)
        {
            Assert.IsTrue(ParamsValidator.IsValidAirVentsDiameter
                (_availableParameters, airVentsDiameter));
        }
    }
}
