using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal interface IPredator : IAnimal
    {
        public int AttackSpeed { get; set; }



    void Attack(IPrey prey);
    }
}
