using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6.Project1
{
    internal class Point3D : ICloneable
    {
        public int D1 { get; set; }
        public int D2 { get; set; }
        public int D3 { get; set; }
        public Point3D()
        {
            
        }
        public Point3D(int d1, int d2, int d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({D1}, {D2}, {D3})";
        }

        public object Clone()
        {
            return new Point3D(D1 = D1, D2= D2,  D3= D3);
        }

        public static bool operator ==(Point3D left, Point3D right)
        { 
            return (left.D1 == right.D1) && (left.D2 == right.D2) && (left.D3 == right.D3);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return (left.D1 != right.D1) && (left.D2 != right.D2) && (left.D3 != right.D3);
        }


    }
}
