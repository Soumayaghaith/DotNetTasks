using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Question1
{
    internal class Circle: ICircle
    {
        public int Radius { get ; set; }
        public double Area =>  (3.14 * Radius * Radius);
        public Circle(int radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The circle is radius is {Radius} and its Area = {Area}");
        }
    }
}
