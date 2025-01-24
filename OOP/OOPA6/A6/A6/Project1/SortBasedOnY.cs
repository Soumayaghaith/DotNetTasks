using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6.Project1
{
    internal class SortBasedOnY : IComparer<Point3D>
    {
        public int Compare(Point3D? p1, Point3D? p2)
        {
            if (p1?.D2 > p2?.D2)
            {
                return 1;
            }
            else if (p1?.D2 < p2?.D2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
