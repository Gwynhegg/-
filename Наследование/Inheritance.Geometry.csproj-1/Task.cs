using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Geometry
{
	public abstract class Body
	{

		public abstract double GetVolume();
		public abstract void Accept(IVisitor visitor);

	}

	public class Ball : Body
	{
		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
		public override double GetVolume()
		{
			return 4.0 * Math.PI * Math.Pow(((Ball)this).Radius, 3) / 3;
		}

		public double Radius { get; set; }
	}

	public class Cube : Body
	{
		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
		public override double GetVolume()
		{
			return Math.Pow(((Cube)this).Size, 3);
		}
		public double Size { get; set; }
	}

	public class Cylinder : Body
	{
		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
		public override double GetVolume()
		{
			var c = this as Cylinder;
			return Math.PI * Math.Pow(c.Radius, 2) * c.Height;
		}
		public double Height { get; set; }
		public double Radius { get; set; }
	}

	public interface IVisitor
	{
		void Visit(Ball ball);
		void Visit(Cube cube);
		void Visit(Cylinder cylinder);
	}
	// Заготовка класса для задачи на Visitor
	public class SurfaceAreaVisitor : IVisitor
	{
		public  void Visit(Ball ball)
		{
			SurfaceArea = 4 * Math.Pow(ball.Radius,2) * Math.PI;
		}

		public  void Visit(Cube cube)
		{
			SurfaceArea = 6 * Math.Pow(cube.Size, 2);
		}

		public  void Visit(Cylinder cylinder)
		{
			SurfaceArea = 2 * Math.PI * Math.Pow(cylinder.Radius, 2) + 2 * Math.PI * cylinder.Radius * cylinder.Height;
		}
		public double SurfaceArea { get; private set; }
	}
	public class DimensionsVisitor : IVisitor
	{
		public void Visit(Ball ball)
		{
			Dimensions = new Dimensions(ball.Radius * 2, ball.Radius * 2);
		}

		public void Visit(Cube cube)
		{
			Dimensions = new Dimensions(cube.Size, cube.Size);
		}

		public void Visit(Cylinder cylinder)
		{
			Dimensions = new Dimensions(cylinder.Radius * 2, cylinder.Height);
		}
		public Dimensions Dimensions { get; private set; }
	}
}
