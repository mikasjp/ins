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
    public class MadgwickAHRS_Test
    {

        [TestCase]
        public void AHRS_Test()
        {

            MadgwickAHRS AHRS = new MadgwickAHRS(0.00000001f);

            AHRS.Update(0f, 0f, 0f, 0f, 1f, 0f);

            List<float> q = AHRS.Quaternion.ToList();

            Assert.AreEqual(1, Math.Sqrt(q[0]* q[0] + q[1]* q[1] + q[2]* q[2] + q[3]* q[3]));

        }

    }
}
