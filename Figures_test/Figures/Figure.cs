namespace Figures_test.Figures
{
    public abstract class Figure
    {
        protected double[] props;
        protected Figure(params double[] props)
        {
            this.props = props;

            foreach (var prop in props) {
                if (prop <= 0)
                {
                    throw new ArgumentException("The params must be greater than zero");
                }
            }
        }

        public abstract string getName();

        public abstract double Square();
    }
}
