
namespace Gravity
{
    /// <summary>
    /// X/Y meters from centre of universe
    /// </summary>
	public struct Coord
	{
		public Coord(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

        /// <summary>
        /// In meters from centre of universe
        /// </summary>
		public readonly double x;

        /// <summary>
        /// In meters from centre of universe
        /// </summary>
		public readonly double y;

		public static Coord operator +(Coord a, Coord b)
		{
			return new Coord(a.x + b.x, a.y + b.y);
        }

        public static Coord operator -(Coord a, Coord b)
        {
            return new Coord(a.x - b.x, a.y - b.y);
        }
    }
}
