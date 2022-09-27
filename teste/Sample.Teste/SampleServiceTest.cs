using Xunit;

namespace Sample.Test
{
    public class SampleServiceTest
    {
        private readonly SampleService _sampleService;

        public SampleServiceTest()
        {
            //arrange (qualquer tipo de vaiavel necessaria para montar o teste)
            _sampleService = new SampleService();
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(3)]
        public void IsEven_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do metodo a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenario proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(4)]
        [InlineData(2)]
        [InlineData(0)]
        public void IsEven_ValuesLessThan1_ReturnTrue(int value)
        {
            //act (chamada do metodo a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenario proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsOdd_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do metodo a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenario proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void IsOdd_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do metodo a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenario proposto no resultado do teste)
            Assert.True(result);
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }


    }
}
