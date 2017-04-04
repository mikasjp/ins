using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Integrator
    {

        /// <summary>
        /// Initializes integrator with empty sample list.
        /// </summary>
        public Integrator()
        {
            Samples = new List<Sample>();
        }

        /// <summary>
        /// Initializes integrator with given sample list and calculate its value.
        /// </summary>
        /// <param name="sampleList"></param>
        public Integrator(List<Sample> sampleList)
        {
            Samples = sampleList;
            Recalculate();
        }

        /// <summary>
        /// List of samples.
        /// </summary>
        public List<Sample> Samples { get; private set; }

        /// <summary>
        /// Value of the integral of the given samples.
        /// </summary>
        public double Value { get; private set; } = 0;

        /// <summary>
        /// Recalculates value of integral.
        /// </summary>
        public void Recalculate()
        {
            Value = 0;
            for (int i = 0; i < Samples.Count - 1; i++)
            {
                Value += (Samples[i].Value + Samples[i + 1].Value) * (Samples[i + 1].Time - Samples[i].Time) * 0.5;
            }
        }

        /// <summary>
        /// Adds sample to sample list and calculates value of integral.
        /// </summary>
        /// <param name="sample"></param>
        public void AddSample(Sample sample)
        {
            Samples.Add(sample);
            if(Samples.Count>1)
                Value += (Samples[Samples.Count-2].Value + sample.Value) * (sample.Time - Samples[Samples.Count-2].Time) * 0.5;
        }

        /// <summary>
        /// Clears sample list and sets integral value to zero.
        /// </summary>
        public void Reset()
        {
            Samples.Clear();
            Value = 0;
        }

    }
}
