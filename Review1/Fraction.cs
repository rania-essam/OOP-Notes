using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review1
{
    internal class Fractionn
    {

        public int price;
        public int cnt;
        public int nom { get; set; }

        private int _dom;
        public int dom
        {
            set
            {
                //  Console.WriteLine(value);
                if (value == 0)
                {
                    Console.WriteLine("the value is not valid ans we will set it to one as divison by zero isn’t valid");
                    _dom = 1;
                }
                else
                {

                    _dom = value;
                }
            }
            get
            {
                return _dom;
            }

        }
        //  public int dom { get; set; }
        public Fractionn(int nom, int dom)
        {

            this.nom = nom;
            if (dom > 0) this.dom = dom;
            else
            {
                this.dom = 1;
                Console.WriteLine("Division by zero isn’t valid");
            }
        }

        public static void  f()
        {
            Console.WriteLine("static function ");
            Fractionn dd = new Fractionn(7, 7);
            dd.name();
        }
        public void name()
        {
            Console.WriteLine("non static function");
         
        }

        // constructor overloading is avaliable
        public Fractionn(int nom) : this(nom, 1)
        {

        }


        // function to add two fractions and return a new fraction

        public Fractionn add1(Fractionn f1, Fractionn f2)
        {
            // nom = n1*d2 + n2 * d1 , dom = d1*d2
            int n1 = f1.nom, d1 = f1.dom, n2 = f2.nom, d2 = f2.dom;
            Fractionn ret = new Fractionn(0, 0);
            ret.nom = n1 * d2 + n2 * d1; ret.dom = d1 * d2;
            return ret;
        }

        public static Fractionn operator +(Fractionn f1, Fractionn f2)
        {
            int n1 = f1.nom, d1 = f1.dom, n2 = f2.nom, d2 = f2.dom;
            Fractionn ret = new Fractionn(0, 0);
            ret.nom = n1 * d2 + n2 * d1; ret.dom = d1 * d2;
            return ret;
        }

        public static implicit operator Fractionn (int n){
            return (new Fractionn(n, n));
        }

        public static explicit operator int (Fractionn f)
        {
            return f.nom;
        }
        public static Fractionn operator ++(Fractionn f)
        {

            f.cnt++;
            return f;
        }
      


    }
}
