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
    class FIRFilter_Test
    {

        [TestCase]
        public void FIRFilter_CreateNewObject()
        {
            FIRFilter Filter = new FIRFilter(new List<double>() { 0.25, 0.25, 0.25, 0.25 });
        }


        [TestCase]
        public void FIRFilter_FilterFewSamples()
        {

            FIRFilter Filter = new FIRFilter(new List<double>() { 0.25, 0.25, 0.25, 0.25 });

            Filter.AddSample(new Sample(0, 0));
            Filter.AddSample(new Sample(1, 1));
            Filter.AddSample(new Sample(2, 2));
            Filter.AddSample(new Sample(3, 4));
            Sample filteredSample = Filter.AddSample(new Sample(4, 8));

            Assert.AreEqual((1*0.25 + 2*0.25 + 4*0.25 + 8*0.25), filteredSample.Value);

            filteredSample = Filter.AddSample(new Sample(5, 2));

            Assert.AreEqual((2 * 0.25 + 4 * 0.25 + 8 * 0.25 + 2*0.25), filteredSample.Value);

        }

    }
}
