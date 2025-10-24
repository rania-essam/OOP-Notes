using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Triangle : Shape
    {
        public double Base{set; get;}
        public double height{set; get;}

        public override double CAl_Area()
        {
            Console.WriteLine("Area of the TRiangle");
            return (0.5 * Base * height);
        }
    }
}
