namespace triangulo.testes
{
    public class trianguloteste
    {
        [Fact]
        public void ehtriangulo()
        {
            //nao eh trtiangulo
            Assert.False(Triangulo.ehTriangulo(-3,-3,-3));
            Assert.False(Triangulo.ehTriangulo(0,0,0));
            Assert.False(Triangulo.ehTriangulo(50, 0, 0));
            Assert.False(Triangulo.ehTriangulo(0, 50, 0));
            Assert.False(Triangulo.ehTriangulo(0, 0, 50));
            
            //forma triangulo
            Assert.True(Triangulo.ehTriangulo(4, 5, 5));
            Assert.True(Triangulo.ehTriangulo(5, 5, 5));
            Assert.True(Triangulo.ehTriangulo(7, 5, 6));

        }
        [Fact]
        public void tipotriangulo()
        {
            Assert.Equal("Nao e Triangulo", Triangulo.tipoTriangulo(0, 0, 0));
            Assert.Equal("O triangulo e do tipo: Equilatero", Triangulo.tipoTriangulo(5, 5, 5));
            Assert.Equal("O triangulo e do tipo: Isosceles", Triangulo.tipoTriangulo(4, 5, 5));
            Assert.Equal("O triangulo e do tipo: Escaleno", Triangulo.tipoTriangulo(4, 5, 6));
        }

    }
}