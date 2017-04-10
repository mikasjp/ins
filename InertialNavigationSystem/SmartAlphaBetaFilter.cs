using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class SmartAlphaBetaFilter: IFilter
    {
        protected AlphaBetaFilter Filter { get; set; }

        protected List<Sample> Memory { get; set; } = new List<Sample>();
        protected uint MemoryCapacity { get; set; }
        protected double NoiseVariance { get; set; } = 0;

        protected double ProcessVariance
        {
            get
            {
                if (Memory.Count == 0)
                    return 0;
                double average = 0;
                foreach (Sample memorySample in Memory)
                    average += memorySample.Value;
                average /= Convert.ToDouble(Memory.Count);
                double variance = 0;
                foreach (Sample memorySample in Memory)
                    variance += Math.Pow((average - memorySample.Value), 2);
                variance /= Convert.ToDouble(Memory.Count);
                return variance;
            }
        }

        public SmartAlphaBetaFilter(double noiseVariance, uint memoryCapacity, double initialTime = 0)
        {
            Filter = new AlphaBetaFilter(1, 1);
            NoiseVariance = noiseVariance;
            MemoryCapacity = memoryCapacity;
        }

        protected void TuneFilter()
        {
            double lambda = Math.Sqrt(ProcessVariance) * Math.Pow(Filter.dt,2) / Math.Sqrt(NoiseVariance);
            double r = (4 + lambda - Math.Sqrt(8 * lambda + Math.Pow(lambda,2))) / 4;
            Filter.SetAlpha(1 - Math.Pow(r, 2));
            Filter.SetBeta(2 * ( 2 - Filter.Alpha) - 4 * Math.Sqrt(1 - Filter.Alpha));
        }

        public Sample AddSample(Sample sample)
        {
            Memory.Add(sample);
            if (Memory.Count > MemoryCapacity-1)
                Memory.RemoveAt(0);

            TuneFilter();

            return Filter.AddSample(sample);
        }

        public void Reset()
        {
            Filter.Reset();
        }
    }
}
