using System;
using System.Collections.Generic;
using System.Linq;

namespace Gravity
{
    public class NewtonianCalculator : INewtonianCalculator
    {
        private double TimeInterval;
        private const double TwoPi = Math.PI * 2;
        private const double HalfPi = Math.PI / 2;
        private double G = 6.674E-11; //0.00000000006674

        public NewtonianCalculator(double timeInterval)
        {
            TimeInterval = timeInterval;
        }

        public void PopulateForces(Body body1, Body body2)
        {
            body1.InfluencingVectors = body1.InfluencingVectors ?? new List<Influence>();
            body2.InfluencingVectors = body2.InfluencingVectors ?? new List<Influence>();

            var distance = PythagoreanDistance(body1, body2);
            var force = Newtons(body1, body2, distance);
            var body1ToBody2Direction = FixAngle(Body1ToBody2Direction(body1, body2));
            var body2ToBody1Direction = FixAngle(body1ToBody2Direction + Math.PI);
            var body1To2Vector = new Vector(Acceleration(body1, force), body1ToBody2Direction);
            var body2To1Vector = new Vector(Acceleration(body2, force), body2ToBody1Direction);
            body1.InfluencingVectors.Add(new Influence { BodyId = body2.Id, Vector = body1To2Vector });
            body2.InfluencingVectors.Add(new Influence { BodyId = body1.Id, Vector = body2To1Vector });
        }

        public void CalcFutureBody(Body body)
        {
            var totalInfluenceCoord = new Coord(0, 0);
            var totalInfluence = new Vector();

            foreach (var influence in body.InfluencingVectors.Where(v => v.Vector.Velocity != 0))
            {
                var influceAsCoord = VectorToCoord(influence.Vector);
                totalInfluenceCoord += influceAsCoord;
            }

            var inertialInfluence = VectorToCoord(body.CurrentVector);
            totalInfluenceCoord += inertialInfluence;
            totalInfluence = CoordToVector(totalInfluenceCoord);
            var currentInertia = FixVector(totalInfluence);
            var futureCoord = new Coord(
                body.Coord.x + (totalInfluenceCoord.x * TimeInterval),
                body.Coord.y + (totalInfluenceCoord.y * TimeInterval));

            body.FutureCoord = futureCoord;
            body.FutureVector = currentInertia;
        }


        /// <summary>
        /// Returns the gravitic attraction between 2 bodies in newtons
        /// </summary>
        /// <returns></returns>
        private double Newtons(Body body1, Body body2, double distance)
        {
            return G * ((body1.Mass * body2.Mass) / (distance * distance));
        }

        /// <summary>
        /// Returns the acceleration exerted on body1 by body2
        /// </summary>
        /// <param name="body1"></param>
        /// <param name="body2"></param>
        /// <returns></returns>
        private double Acceleration(Body body, double force)
        {
            var a = force / body.Mass;
            return a;
        }

        /// <summary>
        /// Returns the distance between 2 bodies.
        /// </summary>
        /// <param name="body1"></param>
        /// <param name="body2"></param>
        /// <returns></returns>
        public static double PythagoreanDistance(Body body1, Body body2)
        {
            var xDiff = body1.Coord.x - body2.Coord.x;
            var yDiff = body1.Coord.y - body2.Coord.y;
            if (xDiff == 0 && yDiff == 0)
            {
                return 0;
            }

            return Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
        }

        /// <summary>
        /// Returns the direction to body 2 from body 1 in radians
        /// </summary>
        /// <returns></returns>
        private double Body1ToBody2Direction(Body body1, Body body2)
        {
            var coord = body2.Coord - body1.Coord;
            if (coord.x == 0 && coord.y == 0)
            {
                return 0;
            }

            var angle = Math.Atan2(coord.x, coord.y) - HalfPi;
            return FixAngle(angle);
        }
        
        /// <summary>
        /// Returns a radian constrained to a single circle, e.g. no negative and not > 2 pi
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double FixAngle(double angle)
        {
            angle = angle > TwoPi ? angle - TwoPi : angle;
            angle = angle < 0 ? angle + TwoPi : angle;
            return angle;
        }        

        private Coord VectorToCoord(Vector vector)
        {
            if (vector.Velocity == 0 || double.IsNaN(vector.Velocity))
            {
                return new Coord();
            }

            var direction = TwoPi - vector.Direction;
            var x = vector.Velocity * Math.Cos(direction);
            var y = vector.Velocity * Math.Sin(direction);

            if (double.IsNaN(x) || double.IsNaN(y))
            {
                throw new InvalidProgramException();
            }

            return new Coord(x, y);
        }

        private Vector CoordToVector(Coord coord)
        {
            if (coord.x == 0 && coord.y == 0)
            {
                return new Vector();
            }

            var angle = Math.Atan2(coord.x, coord.y) - HalfPi;
            var distance = Math.Sqrt((coord.x * coord.x) + (coord.y * coord.y));
            return FixVector(new Vector { Direction = angle, Velocity = distance });
        }

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
    }
}
