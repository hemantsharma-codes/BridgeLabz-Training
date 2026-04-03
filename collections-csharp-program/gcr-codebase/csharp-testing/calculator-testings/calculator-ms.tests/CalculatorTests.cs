using calculator_testing;

namespace CaculatorMs.Tests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        private Calculator calc;

        [TestInitialize]
        public void Init()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnCorrectSum()
        {
            Assert.AreEqual(8,calc.Add(5,3));
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnCorrectSubtraction()
        {
            Assert.AreEqual(6, calc.Subtract(8, 2));
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnCorrectDivision()
        {
            Assert.AreEqual(2, calc.Divide(10, 5));
        }

        [TestMethod]
        public void Multiply_TwoNumber_ReturnCorrectMultiplication()
        {
            Assert.AreEqual(10, calc.Multiply(2, 5));
        }

        [TestMethod]
        public void Divide_ByZero_Throws()
        {
            try
            {
                calc.Divide(5, 0);
                Assert.Fail("No exception thrown");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
