using System;
using NUnit.Framework;
using System.Collections.Generic;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса AvailableParameters")]
    class AvailableParametersTests
    {
        /// <summary>
        /// Доступные параметры
        /// </summary>
        private AvailableParameters _availableParameters;
        /// <summary>
        /// Параметры диска
        /// </summary>
        private DiskParams _diskParams;

        [SetUp]
        public void SetAvailableParameters()
        {
            _diskParams = new DiskParams();
            _availableParameters = _diskParams.AvailableParameters;
        }

        [Test(Description = "Позитивный тест геттера DiskDiameterValues")]
        public void GetDiskDiameterValues_PositiveTest()
        {
            var expected = new List<int>() { 13, 14, 15, 16, 17, 18, 19 };
            var actual = _availableParameters.DiskDiameterValues;
            CollectionAssert.AreEqual(expected, actual, 
                "Геттер DiskDiameterValues возвращает неправильную коллекцию " +
                "допустимых значений диаметра диска");
        }

        [Test(Description = "Позитивный тест геттера WidthValues")]
        public void GetWidthValues_PositiveTest()
        {
            var expected = new List<double>() { 6.5, 7, 8, 10 };
            var actual = _availableParameters.WidthValues;
            CollectionAssert.AreEqual(expected, actual,
                "Геттер WidthValues возвращает неправильную коллекцию " +
                "допустимых значений ширины диска");
        }

        [Test(Description = "Позитивный тест геттера BoltsCountValues")]
        public void GetBoltsCountValues_PositiveTest()
        {
            var expected = new List<int>() { 4, 5, 6 };
            var actual = _availableParameters.BoltsCountValues;
            CollectionAssert.AreEqual(expected, actual,
                "Геттер BoltsCountValues возвращает неправильную коллекцию " +
                "допустимых значений количества болтов");
        }

        [Test(Description = "Позитивный тест геттера BoltArrangementDiameterValues")]
        public void GetBoltArrangementDiameterValues_PositiveTest()
        {
            var expected = new List<double>() { 98, 100, 105, 108, 110, 112, 114.3, 115,
                118, 120, 127, 130, 139.7, 150, 160, 165 };
            var actual = _availableParameters.BoltArrangementDiameterValues;
            CollectionAssert.AreEqual(expected, actual,
                "Геттер BoltArrangementDiameterValues возвращает неправильную коллекцию" +
                " допустимых значений диаметра расположения болтов");
        }

        [Test(Description = "Позитивный тест геттера CentralHoleDiameterValues")]
        public void GetCentralHoleDiameterValues_PositiveTest()
        {
            var expected = new List<double>() { 95.3, 98.1, 98.6, 108.5, 110.1 };
            var actual = _availableParameters.CentralHoleDiameterValues;
            CollectionAssert.AreEqual(expected, actual,
                "Геттер CentralHoleDiameterValues возвращает неправильную коллекцию" +
                " допустимых значений диаметра центрального отверстия диска");
        }

        [Test(Description = "Позитивный тест геттера AirVentsCountValues")]
        public void GetAirVentsCountValues_PositiveTest()
        {
            var expected = new List<int>() { 12, 13, 14, 15, 16 };
            var actual = _availableParameters.AirVentsCountValues;
            CollectionAssert.AreEqual(expected, actual,
                "Геттер AirVentsCountValues возвращает неправильную коллекцию" +
                " допустимых значений количества вентиляционных отверстий");
        }

        [Test(Description = 
            "Негативный тест метода ChangeDiskDiameterDependentQuantities")]
        [TestCase(12, TestName = 
            "Негативный тест со значением диаметра диска меньше минимального")]
        [TestCase(20, TestName = 
            "Негативный тест со значением диаметра диска больше максимального")]
        public void ChangeDiskDiameterDependentQuantities_NegativeTest(int diskDiameter)
        {
            Assert.Throws<ArgumentException>(() => 
            _availableParameters.ChangeDiskDiameterDependentQuantities(diskDiameter));
        }

        [Test(Description =
            "Позитивный тест метода ChangeDiskDiameterDependentQuantities")]
        [TestCase(13, TestName = "Позитивный тест со значением диаметра диска 13")]
        [TestCase(14, TestName = "Позитивный тест со значением диаметра диска 14")]
        [TestCase(15, TestName = "Позитивный тест со значением диаметра диска 15")]
        [TestCase(16, TestName = "Позитивный тест со значением диаметра диска 16")]
        [TestCase(17, TestName = "Позитивный тест со значением диаметра диска 17")]
        [TestCase(18, TestName = "Позитивный тест со значением диаметра диска 18")]
        [TestCase(19, TestName = "Позитивный тест со значением диаметра диска 19")]
        public void ChangeDiskDiameterDependentQuantities_PositiveTest(int diskDiameter)
        {
            _availableParameters.ChangeDiskDiameterDependentQuantities(diskDiameter);
        }

        [Test(Description = 
            "Негативный тест метода ChangeBoltsCountDependentQuantities")]
        [TestCase(16, 7, TestName = "Негативный тест с корректным значением " +
            "диаметра диска и значением количества болтов больше максимального")]
        [TestCase(16, 3, TestName = "Негативный тест с корректным значением " +
            "диаметра диска и значением количества болтов меньше минимального")]
        [TestCase(12, 3, TestName = "Негативный тест с некорректными значениями " +
            "диаметра диска и количества болтов")]
        [TestCase(12, 5, TestName = "Негативный тест с некорректным значением " +
            "диаметра диска и корректным значением количества болтов")]
        public void ChangeBoltsCountDependentQuantities_NegativeTest
            (int diskDiameter, int boltsCount)
        {
            Assert.Throws<ArgumentException>(() => 
            _availableParameters.ChangeBoltsCountDependentQuantities
            (diskDiameter, boltsCount));
        }

        [Test(Description =
            "Позитивный тест метода ChangeBoltsCountDependentQuantities")]
        [TestCase(16, 4, TestName = "Позитивный тест с корректным значением диаметра" +
            " диска и значением количества болтов 4")]
        [TestCase(16, 5, TestName = "Позитивный тест с корректным значением диаметра" +
            " диска и значением количества болтов 5")]
        [TestCase(16, 6, TestName = "Позитивный тест с корректным значением диаметра" +
            " диска и значением количества болтов 6")]
        public void ChangeBoltsCountDependentQuantities_PositiveTest
            (int diskDiameter, int boltsCount)
        {
            _availableParameters.ChangeBoltsCountDependentQuantities 
                (diskDiameter, boltsCount);
        }

        [Test(Description =
            "Негативный тест метода ChangeBoltArrangementDiameterDependentQuantities")]
        [TestCase(16, 5, 166, TestName = "Негативный тест с корректными значениями " +
            "диаметра диска и количества болтов, и значением " +
            "диаметра расположения болтов больше максимального")]
        [TestCase(16, 5, 97, TestName = "Негативный тест с корректными значениями " +
            "диаметра диска и количества болтов, и значением " +
            "диаметра расположения болтов меньше минимального")]
        [TestCase(16, 5, 115.5, TestName = "Негативный тест с корректными значениями " +
            "диаметра диска и количества болтов, и значением " +
            "диаметра расположения болтов в промежутке между допустимыми значениями")]
        [TestCase(12, 3, 97, TestName = "Негативный тест с некорректными значениями " +
            "диаметра диска, количества и диаметра расположения болтов")]
        [TestCase(12, 5, 139.7, TestName = "Негативный тест с некорректным значением " +
            "диаметра диска и корректными значениями количества и " +
            "диаметра расположения болтов")]
        [TestCase(16, 3, 139.7, TestName = "Негативный тест с некорректным значением " +
            "количества болтов и корректными значениями диаметров диска и" +
            " расположения болтов")]
        [TestCase(12, 3, 139.7, TestName = "Негативный тест с некорректными значениями " +
            "количества болтов и диаметра диска и корректным значением" +
            " диаметра расположения болтов")]
        public void ChangeBoltArrangementDiameterDependentQuantities_NegativeTest
            (int diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            Assert.Throws<ArgumentException>(() =>
            _availableParameters.ChangeBoltArrangementDiameterDependentQuantities
            (diskDiameter, boltsCount, boltArrangementDiameter));
        }

        [Test(Description =
            "Позитивный тест метода ChangeBoltArrangementDiameterDependentQuantities")]
        [TestCase(16, 5, 98, TestName = "Позитивный тест с корректными значениями диаметра" +
            " и количества ботов, и значением диаметра расположения болтов 98")]
        [TestCase(16, 5, 139.7, TestName = "Позитивный тест с корректными значениями диаметра" +
            " и количества ботов, и значением диаметра расположения болтов 139.7")]
        [TestCase(16, 5, 165, TestName = "Позитивный тест с корректными значениями диаметра" +
            " и количества ботов, и значением диаметра расположения болтов 165")]
        public void ChangeBoltArrangementDiameterDependentQuantities_PositiveTest
            (int diskDiameter, int boltsCount, double boltArrangementDiameter)
        {
            _availableParameters.ChangeBoltArrangementDiameterDependentQuantities
            (diskDiameter, boltsCount, boltArrangementDiameter);
        }

        [Test(Description = "Позитивный тест запуска события ValuesChanged")]
        [TestCase(AvailableValuesChangeType.DiskDiameterChanged, TestName = 
            "Позитивный тест запуска события с изменением диаметра диска")]
        [TestCase(AvailableValuesChangeType.BoltsCountChanged, TestName = 
            "Позитивный тест запуска события с изменением количества болтов")]
        [TestCase(AvailableValuesChangeType.BoltArrangementDiameterChanged, TestName = 
            "Позитивный тест запуска события с изменением диаметра расположения болтов")]
        public void ValuesChanged_WhenCalled_IsSuccessfull
            (AvailableValuesChangeType expectedChangeType)
        {
            AvailableValuesChangeType actualChangeType = 0;

            _availableParameters.ValuesChanged += (sender, args) =>
            {
                actualChangeType = args.Type;
            };

            switch(expectedChangeType)
            {
                case AvailableValuesChangeType.DiskDiameterChanged:
                    _availableParameters.ChangeDiskDiameterDependentQuantities
                        (_diskParams.DefaultDiskDiameter);
                    break;

                case AvailableValuesChangeType.BoltsCountChanged:
                    _availableParameters.ChangeDiskDiameterDependentQuantities
                        (_diskParams.DefaultDiskDiameter);
                    _availableParameters.ChangeBoltsCountDependentQuantities
                        (_diskParams.DefaultDiskDiameter, _diskParams.DefaultBoltsCount);
                    break;

                case AvailableValuesChangeType.BoltArrangementDiameterChanged:
                    _availableParameters.ChangeDiskDiameterDependentQuantities
                        (_diskParams.DefaultDiskDiameter);
                    _availableParameters.ChangeBoltsCountDependentQuantities
                        (_diskParams.DefaultDiskDiameter, _diskParams.DefaultBoltsCount);
                    _availableParameters.ChangeBoltArrangementDiameterDependentQuantities
                        (_diskParams.DefaultDiskDiameter, _diskParams.DefaultBoltsCount,
                        _diskParams.DefaultBoltArrangementDiameter);
                    break;
            }

            Assert.AreEqual(expectedChangeType, actualChangeType);
        }
    }
}
