using GeometryFigure.AbstractClasses;
using GeometryFigure.Interfaces;

namespace GeometryFigure.Classes
{
	public class Triangle : Figure, ITriangle
	{
		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }


        public Triangle(double sideA, double sideB, double sideC)
        {
			if (sideA <= 0)
				throw new Exception("The side A value should be >, then 0");

			if (sideB <= 0)
				throw new Exception("The side B value should be >, then 0");

			if (sideC <= 0)
				throw new Exception("The side C value should be >, then 0");

			if (sideA + sideB <= sideC && sideA + sideC <= sideB && sideC + sideB <= sideA)
				throw new Exception("Such a triangle cannot exist");

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}


		public override double Square()
		{
			if (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
				return SideB * SideC * 0.5;

			if (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
				return SideA * SideC * 0.5;

			if (Math.Pow(SideC, 2) == Math.Pow(SideB, 2) + Math.Pow(SideA, 2))
				return SideB * SideA * 0.5;

			double p = (SideA + SideB + SideC) / 2.0;

			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}

	}
}
