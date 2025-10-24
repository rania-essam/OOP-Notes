using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal class Cat : IPredator
    {
        private int _attackSpeed;
        public string Name { get; set; }
        public int AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }
        public void Attack(IPrey prey)
        {
            if (_attackSpeed > prey.FleeSpeed)
                Console.WriteLine("Caught prey");
            else
                Console.WriteLine("Prey escaped");
        }

        public void Purr()
        {
            Console.WriteLine("Cat purred");
        }
    }
}
