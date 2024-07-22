using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05Assignment.First_Project
{
    internal class _3DPoint: ICloneable
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; } 
        #endregion

        #region Constructors
        public _3DPoint() : this(0, 0, 0) { }
        public _3DPoint(double _x) : this(_x, 0, 0) { }

        public _3DPoint(double _x, double _y) : this(_x, _y, 0) { }
        public _3DPoint(double _x, double _y, double _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        } 
        #endregion

        public override string ToString()
        {
            return $"Point3D Coordinates (X: {X}, Y: {Y}, Z: {Z})";
        }

        public object Clone()
        {
            return new _3DPoint(X, Y, Z);
        }

        #region Comparison Operator overloading
        public static bool operator ==(_3DPoint a, _3DPoint b)
        {
            return (a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }
        public static bool operator !=(_3DPoint a, _3DPoint b)
        {
            return (a.X != b.X || a.Y != b.Y || a.Z != b.Z);
        } 
        #endregion


    }
}
