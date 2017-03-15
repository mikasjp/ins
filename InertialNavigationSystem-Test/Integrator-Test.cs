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
    public class Integrator_Test
    {
        [Test]
        public void IntegrateSamples()
        {

            List<Sample> samples = new List<Sample>()
            {
                new Sample(0,1),
                new Sample(1,1),
                new Sample(2,1)
            };

            Integrator integrator = new Integrator(samples);

            Assert.AreEqual(2, integrator.Value);

        }

        [Test]
        public void AddSampleAndIntegrate()
        {
            Integrator integrator = new Integrator();
            integrator.AddSample(new Sample(0,1));

            //Assert.AreEqual(0, integrator.Value);

            integrator.AddSample(new Sample(1, 1));
            
            Assert.AreEqual(1, integrator.Value);

        }
    }
}
