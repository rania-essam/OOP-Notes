using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public struct LaunchStatus
    {
        public static LaunchStatus Green = new LaunchStatus(0);
        public static LaunchStatus Yellow = new LaunchStatus(1);
        public static LaunchStatus Red = new LaunchStatus(2);

        public void dispaly()
        {
            Console.WriteLine(operator true(Red));
        }

        private int status;
        private LaunchStatus(int status)
        {
            this.status = status;
        }
        public static bool operator true(LaunchStatus x) => x == Green || x == Yellow;
        public static bool operator false(LaunchStatus x) => x == Red;

        public static bool operator ==(LaunchStatus x, LaunchStatus y) => x.status == y.status;
        public static bool operator !=(LaunchStatus x, LaunchStatus y) => !(x == y);
    }
}
