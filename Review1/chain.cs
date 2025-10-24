using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review1
{
    // constructor chaining
    internal class chain
    {
        public string name;
        public int age;

        public chain()
        {
            name = " Rania ";
            age = 20;
        }

        public chain(string name) : this()  // call the first constructor in this constructor
        {
            this.name = name;
        }

        public chain(string name , int age) : this(name)
        {
            this.age = age;
        }
    }
}
