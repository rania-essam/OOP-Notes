using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Human : Creature
    {
      //  Creature c = new Creature();
        
        
        public Human()
        {
            // Console.WriteLine(c.Age); ---> c can’t access protected members   xxxxx
           // Console.WriteLine(c.Name);    // ---> c can access public members
        }
        public Human(string name,int age):base()
        {
            Console.WriteLine("non Parameterized Constructor of the Derived Class");
            Name = name;
            // OR base.Name=name
            base.Age = age;
            // base reference can access protected members 
        }


        public override void Move()
        {
            Console.WriteLine("move human ");
            move = false;
        }










    }
}
