using unittestDemo;
namespace UnittestDemo.Tests
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void sumTwoIntNumbersPositiveTest()
        {
            Assert.AreEqual(170, MathHelper.sumTwoNumbers(5, 165));
        }
        [TestMethod]
        public void sumTwoDoubleNumbersPositiveTest()
        {
            Assert.AreEqual(170.0, MathHelper.sumTwoNumbers(5.0, 165.0));
        }
        [TestMethod]
        public void sumTwoFloatNumbersPositiveTest()
        {
            Assert.AreEqual(170.0f, MathHelper.sumTwoNumbers(5.0f, 165.0f));
        }
        [TestMethod]
        public void sumTwoDecimalNumbersPositiveTest()
        {
            Assert.AreEqual(170.0m, MathHelper.sumTwoNumbers(5.0m, 165.0m));
        }

        [TestMethod]
        public void getDividorsCountPositiveTest()
        {
            Assert.AreEqual(3, MathHelper.getDividorsCount(10));
        }

        [TestMethod]
        public void getDividorsCountNegativeNumberTest()
        {
            Assert.AreEqual(3, MathHelper.getDividorsCount(-10));
        }
    }
}