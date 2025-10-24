using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal interface IPrey :IAnimal
    {

        int FleeSpeed { get; set; }
        void Flee();
        string Name { get; set; }
        void dis();

    }
}
