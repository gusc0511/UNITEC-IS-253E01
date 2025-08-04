using Xunit;
using Application253E01;

namespace Application.IntegrationTest
{
    public class IntegrationTestFigura
    {
        [Theory]
        [InlineData(4, 6, 2, 24.0)]
        [InlineData(5, 10, 3, 75.0)]
        [InlineData(8, 7, 4, 112.0)]
        [InlineData(12, 9, 2, 108.0)]
        [InlineData(6, 5, 5, 75.0)]
        [InlineData(10, 8, 3, 120.0)]
        [InlineData(7, 6, 6, 126.0)]
        [InlineData(9, 4, 2, 36.0)]
        [InlineData(3, 5, 4, 30.0)]
        [InlineData(2, 6, 5, 30.0)]
        public void TestVolumenPorArea(double @base, double alturaTriangulo, double alturaPrisma, double volumenEsperado)
        {
            double area = Figura253E01.Area(@base, alturaTriangulo);
            double resultado = Figura253E01.Volumen(area, alturaPrisma);
            Assert.Equal(volumenEsperado, resultado);
        }
    }
}