using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gravity
{
    public class NBodySystem
    {
        private NBodyParameters Parameters;
        private long Iterations;

        public NBodySystem(NBodyParameters parameters)
        {
            Parameters = parameters;
            Iterations = 0;
        }

        public async Task Start()
        {
            await Task.Run(() => DoCalculation());
        }

        private void DoCalculation()
        {
            var bodies = Parameters.Bodies;
            while (!Parameters.ShouldStop())
            {
                var calc = new MotionCalculator(Parameters.NewtonianCalculator);
                bodies = calc.Calculate(bodies);
                
                Parameters.UpdateUi(bodies);
                while (Parameters.PauseAt(Iterations) <= Iterations && !Parameters.ShouldStop())
                {
                    Task.Delay(1000);
                }
                Iterations++;
            }
            Parameters.Stopped();
        }        
    }

    public class NBodyParameters
    {
        public Action Stop { get; set; }
        public Action Stopped { get; set; }
        public Func<bool> ShouldStop { get; set; }
        public Func<long, long> PauseAt { get; set; }
        public ICollection<Body> Bodies { get; set; }
        public Action<ICollection<Body>> UpdateUi { get; set; }
        public Func<double> TimeInterval { get; set; }
        public INewtonianCalculator NewtonianCalculator { get; set; }
        public Action Next { get; set; }
    }
}
