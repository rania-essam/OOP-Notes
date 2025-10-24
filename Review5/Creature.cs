using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    abstract class Creature
    {
        public string Name;
        public int Length;
        protected int Age;
        public int c = 0;
        public bool move = false;
        public Creature()
        {
            c++;
            Console.WriteLine("non Parameterized Constructor of the base Class");
        }
        public void print()
        {
            Console.WriteLine(c);
        }
        public Creature(int Age,string name)
        {
            Name = name;
            this.Age = Age;
            Console.WriteLine("Parameterized constructor of the base Class");

        }
     //   public abstract void Move();
        public virtual void Move()
        {
            Console.WriteLine("Creature move ");
        }

        //abstract function is a virtual function
    }
}
