using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public interface IFilter
    {

        Sample AddSample(Sample sample);
        void Reset();

    }
}
