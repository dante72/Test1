using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_test.Figures.Impl
{
    public class Triangle : Figure
    {
        public Triangle(double p1, double p2, double p3) : base(p1, p2, p3) { }
        public override string getName()
        {
            return "Triangle";
        }

        public override double Square()
        {
            var p = 0.5 * (props[0] + props[1] + props[2]);
            var sq = Math.Sqrt(p * (p - props[0]) * (p - props[1]) * (p - props[2]));
            return Math.Sqrt(p * (p - props[0]) * (p - props[1]) * (p - props[2]));
        }

        public bool isRightAngled()
        {
            var maxIndex = Array.FindIndex(props, p => p == props.Max());
            
            var tmp = props[maxIndex];
            props[maxIndex] = props[0];
            props[0] = tmp;

            return props[0] * props[0] == props[1] * props[1] + props[2] * props[2];
        }
    }
}
