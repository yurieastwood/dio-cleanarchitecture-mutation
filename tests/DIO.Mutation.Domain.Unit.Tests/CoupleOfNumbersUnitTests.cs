using FluentAssertions;
using NUnit.Framework;
// ReSharper disable InvalidXmlDocComment

namespace DIO.Mutation.Domain.Unit.Tests
{
    [TestFixture]
    public class CoupleOfNumbersUnitTests
    {
        /*
         * [Test-01]
         * This test will show that 100% coverage does not means tested.
         * This is the poorest test because in fact we are not really testing.
         */
        [TestCase(1, 2)]
        [TestCase(-1, -2)]
        public void WhenCallSumDetails_FromCoupleOfNumbers_ShouldNotBeNullOrEmpty(int number1, int number2)
        {
            //Arrange
            var coupleOfNumbers = new CoupleOfNumbers(number1, number2);

            //Act-
            var sumValueDetails = coupleOfNumbers.GetSumValueDetails();

            //Assert
            sumValueDetails.Should().NotBeNullOrEmpty();
        }

        // ################################################################
        // Uncomment the Test-02 for the second level of unit test quality which is ~80% of mutation score.
        // Good but not enough.
        // ################################################################
        ///*
        // * [Test-02]
        // * This test will show how the mutation tool works and how we can use it to identify the improvements to do in order to make our tests more confident.
        // */
        //[TestCase(1, 2, "POSITIVE-ODD")]
        //[TestCase(-1, -2, "NEGATIVE-ODD")]
        //[TestCase(-1, 2, "POSITIVE-ODD")]
        //[TestCase(3, 5, "POSITIVE-EVEN")]
        //public void WhenCallSumDetails_FromCoupleOfNumbers_ShouldReturnTheDetailsAsExpected_WithMutationOpenPoints(int number1, int number2, string result)
        //{
        //    //Arrange
        //    var coupleOfNumbers = new CoupleOfNumbers(number1, number2);

        //    //Act
        //    var sumValueDetails = coupleOfNumbers.GetSumValueDetails();

        //    //Assert
        //    sumValueDetails.Should().Be(result);
        //}

        // ################################################################
        // Uncomment the Test-03 for the third level of unit test quality with 100% of mutation score.
        // ################################################################
        ///*
        // * [Test-03]
        // * Based on mutation tool we added some adjustments and our tests becomes more confident and safe.
        // */
        //[TestCase(1, 2, "POSITIVE-ODD")]
        //[TestCase(-1, -2, "NEGATIVE-ODD")]
        //[TestCase(-1, 2, "POSITIVE-ODD")]
        //[TestCase(-2, -2, "NEGATIVE-EVEN")]
        //[TestCase(3, 5, "POSITIVE-EVEN")]
        //[TestCase(0, 0, "POSITIVE-EVEN")]
        //[TestCase(-1, 1, "POSITIVE-EVEN")]
        //public void WhenCallSumDetails_FromCoupleOfNumbers_ShouldReturnTheDetailsAsExpected(int number1, int number2, string result)
        //{
        //    //Arrange
        //    var coupleOfNumbers = new CoupleOfNumbers(number1, number2);

        //    //Act
        //    var sumValueDetails = coupleOfNumbers.GetSumValueDetails();

        //    //Assert
        //    sumValueDetails.Should().Be(result);
        //}
    }
}
