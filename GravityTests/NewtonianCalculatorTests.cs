using System;
using System.Linq;
using Gravity;
using NUnit.Framework;

namespace GravityTests
{
    // Todo: Fix re-write or delete these tests.
   /*
    [TestFixture]
    public class NewtonianCalculatorTests
    {
        private const double TwoPi = Math.PI * 2;
        private const double HalfPi = Math.PI / 2;
        private const double QuarterPi = Math.PI / 4;
        private const double EighthPi = Math.PI / 8;

        public double ExpectedEarthG = 9.81;

        [Test]
        public void GivenBodiesTheEarthAndA1kgPayload_At1mAboveSurface_ShouldReturnEarthGravity()
        {
            var earth = new Body { Coord = new Coord(0, 0), Mass = 5.972E+24, Radius = 6371000 };
            var payload = new Body { Coord = new Coord(0, earth.Radius + 1), Mass = 1, Radius = 1 };
            var sut = new NewtonianCalculator(1);
            sut.PopulateForces(earth, payload);
            Assert.AreEqual(1, earth.InfluencingVectors.Count);
            Assert.AreEqual(1, payload.InfluencingVectors.Count);
            Assert.AreEqual(ExpectedEarthG, earth.InfluencingVectors.First().Velocity, 0.01);
            Assert.AreEqual(ExpectedEarthG, payload.InfluencingVectors.First().Velocity, 0.01);
        }

        /* to keep these tests means refactoring the code to be slower.
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(100000)]
        public void GivenBodiesTheEarthAndAPayload_ThePayloadShouldAccelerateAt1G(double payloadMass)
        {
            var earth = new Body { Coord = new Coord(0, 0), Mass = 5.972E+24, Radius = 6371000 };
            var payload = new Body { Coord = new Coord(0, earth.Radius + 1), Mass = payloadMass, Radius = 1 };
            var sut = new NewtonianCalculator(1);
            var result = sut.Body2Vector;
            Assert.AreEqual(ExpectedEarthG, result.Velocity, 0.01, "actual delta {0}", ExpectedEarthG - result.Velocity);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(100000)]
        public void GivenBodiesTheEarthAndAPayload_EarthShouldNotAccelerate(double payloadMass)
        {
            var earth = new Body { Coord = new Coord(0, 0), Mass = 5.972E+24, Radius = 6371000 };
            var payload = new Body { Coord = new Coord(0, earth.Radius + 1), Mass = payloadMass, Radius = 1 };
            var sut = new NewtonianCalculator(earth, payload);
            var result = sut.Body1Vector;
            Assert.AreEqual(0, result.Velocity, 0.000001, "actual delta {0}", result.Velocity);
        }

        // Expected angles in degrees
        [TestCase(0, 0,  10,   0,  90, 270)]
        [TestCase(0, 0,  10,  10,  45, 225)]
        [TestCase(0, 0,   0,  10,   0, 180)]
        [TestCase(0, 0, -10,  10, 315, 135)]
        // [TestCase(0, 0, -10,   0, 270,  90)] //rounding error
        [TestCase(0, 0, -10, -10, 225,  45)]
        [TestCase(0, 0,   0, -10, 180,   0)]
        [TestCase(0, 0,  10, -10, 135, 315)]
        [TestCase(10, 10,  20,  10,  90, 270)]
        [TestCase(10, 10,  20,  20,  45, 225)]
        [TestCase(10, 10,  10,  20,   0, 180)]
        [TestCase(10, 10,   0,  20, 315, 135)]
        // [TestCase(10, 10, -10,   0, 270,  90)] rounding error
        [TestCase(10, 10,   0,   0, 225,  45)]
        [TestCase(10, 10,  10,   0, 180,   0)]
        [TestCase(10, 10,  20,   0, 135, 315)]
        public void GivenBodiesAtSpecifiedPositionsTheVectorsLookCorrect(
            long b1x, long b1y, long b2x, long b2y, double expectedB1Degrees, double expectedB2Degrees)
        {
            var body1 = new Body { Coord = new Coord(b1x, b1y), Mass = 0, Radius = 0 };
            var body2 = new Body { Coord = new Coord(b2x, b2y), Mass = 0, Radius = 0 };
            var sut = new NewtonianCalculator(body1, body2);

            var expectedB1Radians = DegressToRadians(expectedB1Degrees);
            var expectedB2Radians = DegressToRadians(expectedB2Degrees);
            Assert.AreEqual(expectedB1Radians, sut.Body1Vector.Direction, 0.000001);
            Assert.AreEqual(expectedB2Radians, sut.Body2Vector.Direction, 0.000001);
        }

        [TestCase(0, Math.PI + HalfPi)]
        [TestCase(90, 0)]
        [TestCase(180, HalfPi)]
        [TestCase(270, Math.PI)]
        public void TestMyDegressToRadians(double degrees, double expectedRadians)
        {
            Assert.AreEqual(expectedRadians, DegressToRadians(degrees));
        }

        // 0 radians = 90 degrees, moves clockwise
        private double DegressToRadians(double degress)
        {
            return FixAngle(((degress - 90) / 180) * Math.PI);
        }
        private static double FixAngle(double angle)
        {
            angle = angle > TwoPi ? angle - TwoPi : angle;
            angle = angle < 0 ? angle + TwoPi : angle;
            return angle;
        }
    }*/
}
