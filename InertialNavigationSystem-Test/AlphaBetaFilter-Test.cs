using InertialNavigationSystem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem_Test
{
    [TestFixture]
    class AlphaBetaFilter_Test
    {

        [TestCase]
        public void AlphaBetaFilter_CreateNewObject()
        {
            AlphaBetaFilter abf = new AlphaBetaFilter(1.5, 0.5);
        }

        [TestCase]
        public void AlphaBetaFilter_FilterFewSamples()
        {
            Sample sample = new Sample(0, 1);

            Sample filteredSample = new Sample(0, 0);

            AlphaBetaFilter abf = new AlphaBetaFilter(1.5, 0.5);

            for (int i = 0; i < 50; i++)
            {
                filteredSample = abf.AddSample(new Sample(i*0.5,1));
                sample.Time++;
            }

            Assert.AreEqual(1,Math.Round(sample.Value));

        }

    }
}
