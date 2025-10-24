using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review1
{
    internal class _3Dpoint
    {
      // create 3 coordinates for the 3D point
      public double x { set; get; }
      public double y { set; get; }
       public double z { set; get; }

        public _3Dpoint() : this(0, 1, 2) // constructor chaining
        {

        }
        public _3Dpoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void display()
        {
            Console.WriteLine($" {x} {y} {z} ");
        }
        // calculate distance between two points using x coordinate only
        public double cal_distance(_3Dpoint p2)
        {
            //sqrt( (p2.x-x)^2 )   
            //x  ----> of the current object , p2.x ----> for the parameter object
            double res = Math.Sqrt(Math.Pow(p2.x - x, 2));
            return res;
            
        }
        public static bool operator==(_3Dpoint p1,_3Dpoint p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;

        }
        public static bool operator !=(_3Dpoint p1, _3Dpoint p2)
        {
            return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;

        }


    }
}
