using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Rectangle:Shape
    {
        public double length { set; get; }
        public double width { set; get; }
        public override double CAl_Area() 
        {
            if (length == width) Console.WriteLine("Area of the Square ");
            else Console.WriteLine("Area of the rectangle");
            return length * width;
        }

    }
}
