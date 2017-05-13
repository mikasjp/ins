using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Quaternion
    {
        public double W { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Quaternion(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        public Quaternion()
        {
            W = 1;
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Matrix3by3 GetRotationMatrix()
        {
            double A = 1 - 2 * Y * Y - 2 * Z * Z;
            double B = 2 * X * Y - 2 * Z * W;
            double C = 2 * X * Z + 2 * Y * W;
            double D = 2 * X * Y + 2 * Z * W;
            double E = 1 - 2 * X * X - 2 * Z * Z;
            double F = 2 * Y * Z - 2 * X * W;
            double G = 2 * X * Z - 2 * Y * W;
            double H = 2 * Y * Z + 2 * X * W;
            double I = 1 - 2 * X * X - 2 * Y * Y;

            return new Matrix3by3(A, B, C, D, E, F, G, H, I);
        }
    }
}
