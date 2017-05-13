using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Matrix3by3
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double E { get; set; }
        public double F { get; set; }
        public double G { get; set; }
        public double H { get; set; }
        public double I { get; set; }


        /// <summary>
        /// [a   b   c]
        /// [d   e   f]
        /// [g   h   i]
        /// </summary>
        public Matrix3by3(double a, double b, double c, double d, double e, double f, double g, double h, double i)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
            F = f;
            G = g;
            H = h;
            I = i;
        }
    }
}
