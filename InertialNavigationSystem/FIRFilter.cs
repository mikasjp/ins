using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class FIRFilter: IFilter
    {

        private List<Sample> Memory { get; set; }

        private List<double> Coefficients { get; set; }

        public FIRFilter(List<double> FilterCoefficients)
        {
            double sum = 0;
            foreach(double Coefficient in FilterCoefficients)
                sum += Coefficient;

            if (sum != 1)
                throw new Exception("Sum of coefficients must be 1.");

            Coefficients = FilterCoefficients;

            Memory = new List<Sample>(Coefficients.Count);
            
        }

        public Sample AddSample(Sample sample)
        {
            if (Memory.Count == Memory.Capacity)
                Memory.Remove(Memory.Last());

            Memory.Insert(0, sample);

            Sample resultSample = new Sample(sample.Time, 0);

            for(int i=0; i<Memory.Count; i++)
                resultSample.Value += Memory[i].Value * Coefficients[i];

            return resultSample;
        }

    }
}
