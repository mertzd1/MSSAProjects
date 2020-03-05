using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{   //this is the test that determines if the method PrimeService works properly
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        //This will pass if I input a nonPrime number
       [Theory]
       [InlineData(4)]
       [InlineData(9)]
       [InlineData(12)]
        public void IsPrime_InputIs1_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        //this test will pass if I input a prime number
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(13)]
        public void IsPrime_InputIs1_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should not be prime");
        }
    }
}