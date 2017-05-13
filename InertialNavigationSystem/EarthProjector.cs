using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class EarthProjector
    {
        protected MadgwickAHRS AHRS;

        public Sample EarthProjections
        {
            get
            {
                return new Sample(0,0);
            }
        }

        public EarthProjector(float SamplePeriod)
        {
            AHRS = new MadgwickAHRS(SamplePeriod);
            //to do
        }

    }
}
