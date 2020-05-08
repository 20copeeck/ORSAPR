using NUnit.Framework;
using Model;

namespace UnitTests
{
    [TestFixture]
    [Description("Модульные тесты для класса DoubleExtensions")]
    class DoubleExtensionsTests
    {
        [Test(Description = "Негативный тест метода EqualTo")]
        [TestCase(1.11022305e-16, TestName = 
            "Негативный тест со значением погрешности незначительно превышающей максимальное")]
        [TestCase(1e-10, TestName = 
            "Негативный тест со значением погрешности значительно превышающей максимальное")]
        public void EqualTor_NegativeTest(double epsilon)
        {
            Assert.IsFalse(DoubleExtensions.EqualTo(0, epsilon));
        }

        [Test(Description = "Позитивный тест метода EqualTo")]
        [TestCase(1.110223e-16, TestName = 
            "Позитивынй тест с максимальным значением погрешности")]
        [TestCase(1.1102229999e-16, TestName =
            "Позитивынй тест со значением погрешности близкой к максимальной")]
        [TestCase(1e-20, TestName =
            "Позитивынй тест со значением погрешности значительно меньшей максимальной")]
        public void EqualTor_PositiveTest(double epsilon)
        {
            Assert.IsTrue(DoubleExtensions.EqualTo(0, epsilon));
        }
    }
}
