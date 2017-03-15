using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class AlphaBetaFilter : IFilter
    {

        private double Alpha { get; set; }
        private double Beta { get; set; }
        private Sample LastSample { get; set; }

        public AlphaBetaFilter(double alpha, double beta, double InitialTime = 0)
        {
            Alpha = alpha;
            Beta = beta;
            LastSample = new Sample(InitialTime, 0);
        }

        public Sample AddSample(Sample sample)
        {
            throw new NotImplementedException();
        }
    }
}
