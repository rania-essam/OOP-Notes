using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Human
    {
        public string name;
        public int id;
        bankaccont bk;

        public override bool Equals(object obj)
        {
            // Human h = (Human)obj; // not a safe casting 
            // if the obj is not of type HUMAN the casting isnot applied
            //// to solve this problem
            //Human h = obj as Human;
            //// if the obj is not from class human
            //// h == NULL
            //if (h == null) return false;
            //return this.id == h.id;

            // to check if obj from class humna 
            if (obj is Human)
            {
                Human h = obj as Human;
                return this.id == h.id;
            }
            else return false;

        }
        public override string ToString()
        {
            return $"{name} {id}";
        }

        public Human Clone()
        {
            Human h = this.MemberwiseClone() as Human;
            h.bk = new bankaccont(); // deep copy 
            h.bk.id = this.bk.id;
            h.bk.name = this.bk.name;
            return h;

        }
    }
}
