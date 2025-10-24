using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal class Fish:IPrey
    {
        private int _fleeSpeed;

        public String Name { get; set; }
        public int FleeSpeed
        {
            get { return _fleeSpeed; }
            set { _fleeSpeed = value; }
        }

        public void Flee()
        {
            Console.WriteLine("Fish fleeing");
        }
        public void dis()
        {
            Console.WriteLine(Name);
        }


    }
}
