using System.Globalization;

namespace triangulo.testes
{
    public class trianguloteste
    {
        [Fact]
        public void ehtriangulo()
        {
            //nao eh trtiangulo
            Assert.False(program.ehTriangulo(-3,-3,-3));
            Assert.False(program.ehTriangulo(0,0,0));
            Assert.False(program.ehTriangulo(50, 0, 0));
            Assert.False(program.ehTriangulo(0, 50, 0));
            Assert.False(program.ehTriangulo(0, 0, 50));
            
            //forma triangulo
            Assert.True(program.ehTriangulo(4, 5, 5));
            Assert.True(program.ehTriangulo(5, 5, 5));
            Assert.True(program.ehTriangulo(7, 5, 6));

        }
        [Fact]
        public void tipotriangulo()
        {
            Assert.Equal("Nao e Triangulo", program.tipoTriangulo(0, 0, 0));
            Assert.Equal("O triangulo e do tipo: Equilatero", program.tipoTriangulo(5, 5, 5));
            Assert.Equal("O triangulo e do tipo: Isosceles", program.tipoTriangulo(4, 5, 5));
            Assert.Equal("O triangulo e do tipo: Escaleno", program.tipoTriangulo(4, 5, 6));
        }

        [Fact]
        public void numValido()
        {
            double d = 0;
            
            Assert.True(program.numValido("1",d));
            Assert.False(program.numValido("d", d));
            Assert.False(program.numValido("", d));
        }
    }
}