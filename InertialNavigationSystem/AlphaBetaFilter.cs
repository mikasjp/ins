using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class AlphaBetaFilter: IFilter
    {

        private double Alpha { get; set; }
        private double Beta { get; set; }
        private Sample LastSample { get; set; }
        private double InitialTime = 0;
        private double LastDerivative { get; set; } = 0;

        /// <summary>
        /// Initializes filter parameters.
        /// </summary>
        /// <param name="alpha">Alpha coefficient</param>
        /// <param name="beta">Beta coefficient</param>
        /// <param name="initialTime">Optional</param>
        public AlphaBetaFilter(double alpha, double beta, double initialTime = 0)
        {
            Alpha = alpha;
            Beta = beta;
            InitialTime = initialTime;
            ResetFilter();
        }

        /// <summary>
        /// Returns filtered sample.
        /// </summary>
        /// <param name="sample">New sample</param>
        /// <returns></returns>
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

        /// <summary>
        /// Sets Alpha coefficient.
        /// </summary>
        /// <param name="alpha">New Alpha coefficient.</param>
        public void SetAlpha(double alpha)
        {
            Alpha = alpha;
        }

        /// <summary>
        /// Sets Beta coefficient.
        /// </summary>
        /// <param name="beta">New Beta coefficient.</param>
        public void SetBeta(double beta)
        {
            Beta = beta;
        }

        /// <summary>
        /// Resets filter state.
        /// </summary>
        public void ResetFilter()
        {
            LastSample = new Sample(InitialTime, 0);
        }

    }
}
