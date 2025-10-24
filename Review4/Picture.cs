using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Picture 
    {
        public void Display_Area_of_all_shapes(Shape [] s)
        {
            for (int i = 0; i < s.Length; i++) Console.WriteLine(s[i].CAl_Area());
        }


    }
}
