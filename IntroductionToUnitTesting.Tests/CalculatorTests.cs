using NUnit.Framework;

namespace IntroductionToUnitTesting.Tests
{
    public class CalculatorTests
    {
        private Calculator myCalculator;

        [SetUp]
        public void Setup()
        {
            myCalculator = new Calculator();
        }

        // GIVEN  some data -> WHEN - a particular action happens -> THEN a result is expected
        [TestCase(5, 7, 12, Ignore = "Testing from testcase")]
        [TestCase(22, 3, 25)]
        [TestCase(1, 4, 5)]
        public void GivenTwoNumbers_WhenAdding_ResultIsEqualToAddedVariables(int x, int y, int expectedResult)
        {
            // ARRANGE
            //int x = 7;
            //int y = 5;

            // ACT
            int result = myCalculator.Add(x, y);

            // ASSERT
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [Ignore("Because I say so")]
        public void GivenTwoNumbers_WhenSubtracting_ResultIsEqualToSubtractedVariables()
        {
            // ARRANGE
            int x = 7;
            int y = 5;

            // ACT
            int result = myCalculator.Subtract(x, y);

            // ASSERT
            Assert.AreEqual(2, result);
        }

        [TestCase(5, 3, 15)]
        public void GivenTwoNumers_WhenMultiplying_ResultIsCorrect(int x, int y, int expected)
        {
            // ACT
            int result = myCalculator.Multiply(x, y);

            // ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}