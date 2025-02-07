using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Question1
{
    internal class Rectangle : IRectangle
    {
        public int Width { get ; set ; }
        public int Height { get ; set ; }
        public double Area => Width * Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;    
        }


        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Rectangle's width is {Width}, heght is {Height} and its Area = {Area}");
        }
    }
}
