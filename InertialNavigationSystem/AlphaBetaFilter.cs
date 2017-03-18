using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class AlphaBetaFilter
    {

        private double Alpha { get; set; }
        private double Beta { get; set; }
        private Sample LastSample { get; set; }

        double LastDerivative { get; set; } = 0;

        public AlphaBetaFilter(double alpha, double beta, double InitialTime = 0)
        {
            Alpha = alpha;
            Beta = beta;
            LastSample = new Sample(InitialTime, 0);
        }

        public Sample AddSample(Sample sample)
        {

            double dt = sample.Time - LastSample.Time;

            if (dt == 0)
                return sample;

            Sample estSample = new Sample(sample.Time,LastSample.Value);

            estSample.Value += LastDerivative * dt;

            double error = sample.Value - estSample.Value;

            estSample.Value += Alpha * error;

            LastDerivative += (Beta * error) / dt;

            LastSample = estSample;

            return estSample;

        }
    }
}
