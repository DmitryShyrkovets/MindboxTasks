using GeometryFigure.AbstractClasses;
using GeometryFigure.Interfaces;

namespace GeometryFigure.Classes
{
	public class Circle : Figure, ICircle
	{
		public double Radius { get; }

        public Circle(double radius)
        {
			if (radius <= 0)
				throw new Exception("Wrong radius value. The radius value should be >, then 0");

			Radius = radius;

		}

        public override double Square()
		{
			var result = Math.PI * Math.Pow(Radius, 2);

			return result;
		}
	}
}

