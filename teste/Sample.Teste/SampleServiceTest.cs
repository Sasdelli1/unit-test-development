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

        [Fact]
        public void Subtract_MultipleValues_ReturnSuccess()
        {
            //arrange
            var value1 = 80;
            var value2 = 1;
            var value3 = 1;
            var value4 = 1;
            var value5 = 1;
            var total = 100;
            var withTotal = 16;
            var withoutTotal = 76;

            //act
            var resultWithTotal = _sampleService.Subtract(total, value1, value2, value3, value4, value5);
            var resultWithoutTotal = _sampleService.Subtract(value1, value2, value3, value4, value5);

            //Assert
            Assert.Equal(withTotal, resultWithTotal);
            Assert.Equal(withoutTotal, resultWithoutTotal);
        }

        [Theory]
        [InlineData(5)]

        public void Sum_MultipleValues_ReturnSuccess(int values)
        {


            //act
            var resultWithoutTotal = _sampleService.Sum(values, values, values,values);
            

            //Assert
            Assert.Equal(values, resultWithoutTotal);
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
