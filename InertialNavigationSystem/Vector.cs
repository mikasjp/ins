using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector RotateByQuaternion(double w, double x, double y, double z)
        {
            return (new Quaternion(w, x, y, z)).GetRotationMatrix() * this;
        }

        #region properties
        public double SquaresSum()
        {
            return X * X + Y * Y + Z * Z;
        }

        public double Magnitude()
        {
            return Math.Sqrt(SquaresSum());
        }
        #endregion

        #region operators
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator *(double n, Vector v)
        {
            return new Vector(n * v.X, n * v.Y, n * v.Z);
        }

        public static Vector operator *(Matrix3by3 matrix, Vector v)
        {
            return new Vector(matrix.A * v.X + matrix.B * v.Y + matrix.C * v.Z, matrix.D * v.X + matrix.E * v.Y + matrix.F * v.Z, matrix.G * v.X + matrix.H * v.Y + matrix.I * v.Z);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return (v1.X==v2.X && v1.Y==v2.Y && v1.Z==v2.Z);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1==v2);
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            return v1.SquaresSum() < v2.SquaresSum();
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            return v1.SquaresSum() > v2.SquaresSum();
        }

        public static bool operator <=(Vector v1, Vector v2)
        {
            return v1.SquaresSum() <= v2.SquaresSum();
        }

        public static bool operator >=(Vector v1, Vector v2)
        {
            return v1.SquaresSum() >= v2.SquaresSum();
        }
        #endregion

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.X.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Y.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Z.GetHashCode();
                return hashCode;
            }
        }

        public override bool Equals(object other)
        {
            // Check object other is a Vector3 object
            if (other is Vector)
            {
                // Convert object to Vector3
                Vector otherVector = (Vector)other;

                // Check for equality
                return otherVector.Equals(this);
            }
            else
            {
                return false;
            }
        }
    }
}
