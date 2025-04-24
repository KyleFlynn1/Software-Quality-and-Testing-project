using ClassLibrary1;
using NUnit.Framework;
using Moq;

namespace InsuranceServiceTests
{
    [TestFixture]
    public class InsuranceServiceTests
    {

        [TestCase(25, "casual", ExpectedResult = 5.0)]
        [TestCase(31, "casual", ExpectedResult = 2.5)]
        [TestCase(17, "casual", ExpectedResult = 0.0)]
        [TestCase(20, "hardcore", ExpectedResult = 6.0)]
        [TestCase(40, "hardcore", ExpectedResult = 5.0)]
        [TestCase(17, "hardcore", ExpectedResult = 0.0)]
        [TestCase(55, "casual", ExpectedResult = 2.5 * 0.75)]
        [TestCase(55, "hardcore", ExpectedResult = 5.0 * 0.75)]
        [TestCase(30, "Null", ExpectedResult = 0.0)]
        public static double Test1(int age, string gameMode)
        {
            // arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(ds => ds.GetDiscount()).Returns(0.75); // Mocking the discount service
            var insuranceService = new InsuranceService(mockDiscountService.Object);

            // act
            double correctPremium = insuranceService.CalcPremium(age, gameMode);

            // assert
            return correctPremium;
        }
    }
}
