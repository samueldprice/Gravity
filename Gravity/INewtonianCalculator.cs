namespace Gravity
{
    public interface INewtonianCalculator
    {
        void CalcFutureBody(Body body);
        void PopulateForces(Body body1, Body body2);
    }
}