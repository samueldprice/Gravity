using System.Collections.Generic;

namespace Gravity
{
	public class Body
	{
        public Body()
        {
        }

        public int Id;

        /// <summary>
        /// Where it is
        /// </summary>
		public Coord Coord;

        /// <summary>
        /// Where it will be in the next interval
        /// </summary>
        public Coord FutureCoord;

        /// <summary>
        /// Mass in kg
        /// </summary>
		public double Mass;

        /// <summary>
        /// How big it is
        /// </summary>
        public double Radius;

        /// <summary>
        /// Its current movement
        /// </summary>
        public Vector CurrentVector;

        /// <summary>
        /// Its vector after the current interval
        /// </summary>
        public Vector FutureVector;

        public ICollection<Influence> InfluencingVectors;
	}
}
