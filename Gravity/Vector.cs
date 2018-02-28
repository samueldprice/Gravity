
namespace Gravity
{
	public struct Vector
	{
        public Vector(double velocity, double direction)
        {
            Velocity = velocity;
            Direction = direction;
        }

		/// <summary>
		/// Meters per second or meters per second squared for forces.
		/// </summary>
		public double Velocity { get; set; }

		/// <summary>
		/// Inertial direction in radians.
		/// </summary>
		public double Direction { get; set; }
	}
}
