using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Sample
    {

        public Sample(double time, double value)
        {
            Time = time;
            Value = value;
        }

        public double Time { get; set; }
        public double Value { get; set; }
    }
}
