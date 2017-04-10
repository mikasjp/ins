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
    class SmartAlphaBetaFilter_Test
    {

        [TestCase]
        public void SmartAlphaBetaFilter_FilterFewSamples()
        {
            Sample sample = new Sample(0, 1);

            Sample filteredSample = new Sample(0, 0);

            SmartAlphaBetaFilter abf = new SmartAlphaBetaFilter(0.0033,10);

            for (int i = 0; i < 50; i++)
            {
                filteredSample = abf.AddSample(new Sample(i * 0.5, -0.5 +(new Random()).NextDouble()));
                sample.Time++;
            }

            Assert.AreEqual(1, Math.Round(sample.Value));

        }

    }
}
