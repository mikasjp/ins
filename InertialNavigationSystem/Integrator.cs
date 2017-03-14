using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Integrator
    {

        public Integrator()
        {
            Samples = new List<Sample>();
        }

        public Integrator(List<Sample> sampleList)
        {
            Samples = sampleList;
            Recalculate();
        }

        public List<Sample> Samples { get; private set; }

        public double Value { get; private set; } = 0;

        public void Recalculate()
        {
            Value = 0;
            for (int i = 0; i < Samples.Count - 1; i++)
            {
                Value += (Samples[i].Value + Samples[i + 1].Value) * (Samples[i + 1].Time - Samples[i].Time) * 0.5;
            }
        }

        public void AddSample(Sample sample)
        {
            Samples.Add(sample);
            if(Samples.Count>1)
                Value += (Samples[Samples.Count-2].Value + sample.Value) * (sample.Time - Samples[Samples.Count-2].Time) * 0.5;
        }

    }
}
