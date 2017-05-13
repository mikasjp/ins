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
    class Vector_Test
    {
        [TestCase]
        public void RotateVector()
        {
            double qi = 0.5;
            double qj = 0.5;
            double qk = 0.5;
            double qr = 0.5;

            Vector A = new Vector(1, 0, 0);

            Vector B = new Vector(0, 1, 0);

            Vector C = A.RotateByQuaternion(qi, qj, qk, qr);

            Assert.AreEqual(new double[] { B.X, B.Y, B.Z }, new double[] { C.X, C.Y, C.Z });

        }

        [TestCase]
        public void RotatedVectorShouldBeSame()
        {
            double w = 1;
            double x = 0;
            double y = 0;
            double z = 0;

            Vector A = new Vector(2, -8, 16);

            Vector B = A.RotateByQuaternion(w, x, y, z);

            Assert.AreEqual(new double[] { A.X, A.Y, A.Z }, new double[] { B.X, B.Y, B.Z });

        }

        [TestCase]
        public void VectorMultiplicationByMatrix()
        {
            Matrix3by3 m = new Matrix3by3(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Vector v1 = new Vector(10,15,20);
            Vector v2 = m * v1;
            Assert.AreEqual(new List<double> { 100, 235, 370 }, new List<double> { v2.X, v2.Y, v2.Z });
        }

    }
}
