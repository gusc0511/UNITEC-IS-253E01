using Xunit;
using Application253E01;

namespace Application.UnitTest
{
    public class UnitTestFigura
    {
        [Theory]
        [InlineData(3, 4, 5, 12)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(7, 24, 25, 56)]
        [InlineData(9, 12, 15, 36)]
        [InlineData(8, 15, 17, 40)]
        [InlineData(10, 24, 26, 60)]
        [InlineData(12, 16, 20, 48)]
        [InlineData(5, 5, 7.07, 17.07)]
        [InlineData(6, 6, 8.49, 20.49)]
        
        public void TestPerimetro(double ladoA, double ladoB, double ladoC, double esperado)
        {
            double resultado = Figura253E01.Perimetro(ladoA, ladoB, ladoC);
            Assert.Equal(esperado, resultado, precision: 1);
        }

        [Theory]
        [InlineData(4, 6, 12.0)]
        [InlineData(5, 10, 25.0)]
        [InlineData(8, 7, 28.0)]
        [InlineData(12, 9, 54.0)]
        [InlineData(6, 5, 15.0)]
        [InlineData(10, 8, 40.0)]
        [InlineData(7, 6, 21.0)]
        [InlineData(9, 4, 18.0)]
        [InlineData(3, 5, 7.5)]
        [InlineData(2, 6, 6.0)]

        public void TestArea(double @base, double altura, double esperado)
        {
            double resultado = Figura253E01.Area(@base, altura);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(12, 2, 24)]
        [InlineData(25, 3, 75)]
        [InlineData(28, 4, 112)]
        [InlineData(54, 2, 108)]
        [InlineData(15, 5, 75)]
        [InlineData(40, 3, 120)]
        [InlineData(21, 6, 126)]
        [InlineData(18, 2, 36)]
        [InlineData(10, 4, 40)]
        [InlineData(6, 5, 30)]
        public void TestVolumen(double area, double altura, double esperado)
        {
            double resultado = Figura253E01.Volumen(area, altura);
            Assert.Equal(esperado, resultado);
        }
    }
}