using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class CalculatorServiceTests
    {
        private CalculatorService _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new CalculatorService();
        }

        [Test]
        public void TestAdd()
        {
            int actualResult = _calc.Add(1, 2);
            Assert.AreEqual(3, actualResult);
        }

        [Test]
        public void TestMi()
        {
            int actualResult1 = _calc.Sub(2, 2);
            Assert.AreEqual(0, actualResult1);
        }

        [Test]
        public void TestMn()
        {
            int actualResult2 = _calc.Mul(2, 2);
            Assert.AreEqual(4, actualResult2);
        }

        [Test]

        public void TestDz()
        {
            int actualResult3 = _calc.Div(4, 2);
            Assert.AreEqual(2, actualResult3);
        }

        [TestCase(1, 2, 3)]
        public void TestAdd2(int a, int b, int c)
        {
            int actualResult = _calc.Add(a, b);
            Assert.AreEqual(c, actualResult);
        }

    }
}