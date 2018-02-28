using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity
{
	class Mass
	{
		private Vector CurrentInertia { get; set; }
		public Coord CurrentCoord { get; set; }
		public Coord FutureCoord { get; private set; }
		private const double TwoPi = Math.PI * 2;
		private const double HalfPi = Math.PI / 2;
		private const double Area = Math.PI;// * (1 * 1); pi r 2 for r = 1 = pi
		private const double AreaFactor = 0.5;//Area / TwoPi
		public int Id { get; private set; }

		/// <summary>
		/// Non-empty space directions only.
		/// </summary>
		private ICollection<Vector> InfluencingForces { get; set; }
		private ICollection<Mass> InfluencingMasses { get; set; }

		public Mass(int id)
		{
			this.Id = id;
			this.InfluencingMasses = new List<Mass>();
			this.CurrentInertia = new Vector { Direction = 0, Velocity = 0 };
		}

		public void CalculateFutureCoord()
		{
			//this.InfluencingForces = new List<Vector>();

			//foreach (var mass in InfluencingMasses)
			//{
			//	InfluencingForces.Add(CalculateMassInfluence(mass));
			//}

			//var totalInfluenceCoord = new Coord(0,0);
			//var totalInfluence = new Vector();
			//foreach (var vector in InfluencingForces.Where(f => f != null))
			//{
			//	var influence = VectorToCoord(vector);
			//	totalInfluenceCoord += influence;
			//}
			//totalInfluence = CoordToVector(totalInfluenceCoord);
			//var inertialInfluence = VectorToCoord(CurrentInertia);
			//totalInfluenceCoord += inertialInfluence;
			//totalInfluence = CoordToVector(totalInfluenceCoord);
			//CurrentInertia = FixVector(CoordToVector(totalInfluenceCoord));
			//if (double.IsNaN(totalInfluenceCoord.x) || double.IsNaN(totalInfluenceCoord.y))
			//{
			//	throw new InvalidProgramException();
			//}
			//FutureCoord = new Coord(
			//	CurrentCoord.x + (totalInfluenceCoord.x * Factors.ForceFactor),
			//	CurrentCoord.y + (totalInfluenceCoord.y * Factors.ForceFactor));
			////FutureCoord.x = FutureCoord.x > 1 ? 1 : FutureCoord.x;
			////FutureCoord.y = FutureCoord.y > 1 ? 1 : FutureCoord.y;
			////FutureCoord.x = FutureCoord.x < -1 ? -1 : FutureCoord.x;
			////FutureCoord.y = FutureCoord.y < -1 ? -1 : FutureCoord.y;
			//if(double.IsNaN(FutureCoord.x) || double.IsNaN(FutureCoord.y))
			//{
			//	throw new InvalidProgramException();
			//}
		}

		public void Iterate()
		{
			if (FutureCoord.x == double.NaN || FutureCoord.y == double.NaN ||
				CurrentCoord.x == double.NaN || CurrentCoord.y == double.NaN)
			{
				throw new InvalidProgramException();
			}
			this.CurrentCoord = FutureCoord;
		}

		//private Coord VectorToCoord(Vector vector)
		//{
		//	if(vector.Velocity == 0 || double.IsNaN(vector.Velocity))
		//	{
		//		return new Coord
		//		{
		//			x = 0,
		//			y = 0
		//		};
		//	}
		//	var direction = TwoPi - vector.Direction;
		//	var x = vector.Velocity * Math.Cos(direction);
		//	var y = vector.Velocity * Math.Sin(direction);

		//	if (double.IsNaN(x) || double.IsNaN(y))
		//	{
		//		throw new InvalidProgramException();
		//	}

		//	return new Coord
		//	{
		//		x = x,
		//		y = y
		//	};
		//}
        		

		//private Vector CoordToVector(Coord coord)
		//{
		//	if (coord.x == 0 && coord.y == 0)
		//	{
		//		return null;
		//	}
		//	var angle = Math.Atan2(coord.x, coord.y) - HalfPi;
		//	var distance = Math.Sqrt((coord.x * coord.x) + (coord.y * coord.y));
		//	return double.IsNaN(distance) || distance == 0 
		//		? null 
		//		: FixVector(new Vector { Direction = angle, Velocity = distance });
		//}

		//private Vector CalculateMassInfluence(Mass mass)
		//{
		//	var xDiff = this.CurrentCoord.x - mass.CurrentCoord.x;
		//	var yDiff = this.CurrentCoord.y - mass.CurrentCoord.y;
		//	if (xDiff == 0 && yDiff == 0)
		//	{
		//		return null;
		//	}
		//	var angle = Math.Atan2(xDiff, yDiff) + HalfPi;
		//	var distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
		//	var edgeCoord = FindLineCircleIntersection(mass.CurrentCoord, this.CurrentCoord, xDiff, yDiff);
		//	var edgeXdiff = this.CurrentCoord.x - edgeCoord.x;
		//	var edgeYdiff = this.CurrentCoord.y - edgeCoord.y;
		//	var edgeDistance = Math.Sqrt((edgeXdiff * edgeXdiff) + (edgeYdiff * edgeYdiff));
		//	return FixVector(new Vector
		//	{
		//		Direction = angle,
		//		Velocity = (edgeDistance - distance) / Factors.PlankVsUniverseMultiplier
		//	});

		//}

		private static Vector FixVector(Vector vector)
		{
			if (vector.Velocity < 0)
			{
				vector.Velocity = 0 - vector.Velocity;
				vector.Direction += Math.PI;
			}

			vector.Direction = FixAngle(vector.Direction);

			return vector;
		}

		private static double FixAngle(double angle)
		{
			angle = angle > TwoPi ? angle - TwoPi : angle;
			angle = angle < 0 ? angle + TwoPi : angle;
			return angle;
		}

		public void AddInfluence(Mass mass)
		{
			this.InfluencingMasses.Add(mass);
		}

		private double CalculateSegmentArea(double radius)
		{
			var hh = Math.Sqrt(1-(radius * radius));
			var triArea = hh * radius;
			var angle = Math.Asin(hh);
			var sectorArea = angle * 2 * AreaFactor;
			return sectorArea - triArea;
		}

		//private Coord FindLineCircleIntersection(
		//	Coord point1, Coord point2, double dx, double dy)
		//{
		//	var A = dx * dx + dy * dy;
		//	var B = 2 * ((dx * point1.x) + (dy * point1.y));
		//	var t = -B / (2 * A);
		//	var C = (point1.x * point1.x) + (point1.y * point1.y) - 1;
		//	var det = B * B - 4 * A * C;

		//	//var t2 = (float)((-B + Math.Sqrt(det)) / (2 * A));
		//	//var a = new Coord(point1.x + t2 * dx, point1.y + t2 * dy);
		//	var t3 = (float)((-B - Math.Sqrt(det)) / (2 * A));
		//	var b = new Coord(point1.x + t3 * dx, point1.y + t3 * dy);

		//	return b;
		//}
	}
}
