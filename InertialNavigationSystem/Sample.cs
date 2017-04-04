using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Sample
    {

        /// <summary>
        /// Initializes signal sample with given values.
        /// </summary>
        /// <param name="time">Sample time.</param>
        /// <param name="value">Sample value.</param>
        public Sample(double time, double value)
        {
            Time = time;
            Value = value;
        }

        /// <summary>
        /// Sample time.
        /// </summary>
        public double Time { get; set; }

        /// <summary>
        /// Sample value.
        /// </summary>
        public double Value { get; set; }
    }
}
