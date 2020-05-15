using NUnit.Framework;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса ValuesChangeEventArgs")]
    class ValuesChangeEventArgsTests
    {
        [Test(Description = "Позитивный тест геттера Type")]
        [TestCase(AvailableValuesChangeType.DiskDiameterChanged, TestName =
            "Позитивный тест с изменением диаметра диска")]
        [TestCase(AvailableValuesChangeType.BoltsCountChanged, TestName =
            "Позитивный тест с изменением количества болтов")]
        [TestCase(AvailableValuesChangeType.BoltArrangementDiameterChanged, 
            TestName = "Позитивный тест с изменением диаметра " +
            "расположения болтов")]
        public void GetType_PositiveTest
            (AvailableValuesChangeType changeType)
        {
            ValuesChangeEventArgs valuesChangeEventArgs = 
                new ValuesChangeEventArgs(changeType);
            Assert.AreEqual(changeType, valuesChangeEventArgs.Type);
        }
    }
}
