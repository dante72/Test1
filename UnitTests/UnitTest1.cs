using Figures_test.Figures;
using Figures_test.Figures.Impl;

namespace UnitTests
{
    public class UnitTest1
    {   
        const int r = 2;
        const int a = 3, b = 4, c = 5;
        readonly List<Figure> figures = new List<Figure>()
            {
                new Circle(r),
                new Triangle(a, b, c)
            };

        [Fact]
        public void CircleTest()
        {
            Assert.True(figures[0].Square() == r * r * Math.PI);
        }

        [Fact]
        public void TriangleTest()
        {
            Assert.True(figures[1].Square() == a * b / 2);
            Assert.True(((Triangle)figures[1]).isRightAngled());
        }
    }
}