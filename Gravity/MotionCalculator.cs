using System;
using System.Collections.Generic;
using System.Linq;

namespace Gravity
{
    public class MotionCalculator
    {
        INewtonianCalculator NewtonianCalculator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodies"></param>
        /// <param name="timeInterval">Fractions of a second</param>
        public MotionCalculator(INewtonianCalculator newtonianCalculator)
        {
            NewtonianCalculator = newtonianCalculator;
        }

        public ICollection<Body> Calculate(ICollection<Body> bodies)
        {
            var bodyList = bodies.ToArray();
            for (int i = 0; i < bodyList.Length; i++)
            {
                for (int c = i + 1; c < bodyList.Length; c++)
                {
                    NewtonianCalculator.PopulateForces(bodyList[i], bodyList[c]);
                }

                NewtonianCalculator.CalcFutureBody(bodyList[i]);
            }

            foreach(var body in bodies)
            {
                body.Coord = body.FutureCoord;
                body.CurrentVector = body.FutureVector;
            }

            foreach (var body in bodies)
            {
                body.InfluencingVectors = new List<Influence>();
            }

            return bodies;
        }
    }
}
