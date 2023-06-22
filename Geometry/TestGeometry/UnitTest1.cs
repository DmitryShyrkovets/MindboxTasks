using GeometryFigure.AbstractClasses;
using GeometryFigure.Classes;

namespace TestGiometry
{
	public class Tests
	{

		[Test]
		public void TestTriangleSquare()
		{
			Figure triangle = new Triangle(3.5, 2.1, 2.8);

			double square = triangle.Square();

			Assert.AreEqual(2.94, square);
		}

		[Test]
		public void TestCirculeSquare()
		{
			Figure circle = new Circle(5.0);

			double square = circle.Square();

			Assert.AreEqual(78.53981633974483, square);
		}
	}
}