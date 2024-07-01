using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_test.Figures.Impl
{
    public class Circle : Figure
    {
        public Circle(double radius) : base(radius) { }
        public override string getName()
        {
            return "Circle";
        }

        public override double Square()
        {
            return Math.PI * props[0] * props[0];
        }
    }
}
