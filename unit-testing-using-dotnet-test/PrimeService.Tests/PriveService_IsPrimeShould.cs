using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

       [Theory]
       [InlineData(4)]
       [InlineData(9)]
       [InlineData(12)]
        public void IsPrime_InputIs1_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }


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