using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Instructor
    {
        public bool light_on = false;
        public void Write_on_board(Marker mk) // type of association
        {
            Console.WriteLine(mk.color);
        }
        public void on()
        {
            light_on = true;
        }
    }
}
